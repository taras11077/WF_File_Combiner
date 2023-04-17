using FileProcessor.Archiver;
using FileProcessor.Cleaner;
using FileProcessor.Renamer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;
using static System.Windows.Forms.ListView;
using System.Text.Json.Serialization;
using System.IO;
using FileProcessor;

namespace FileCombiner
{
    public partial class FrmCleanerReport : Form
    {
        private CleanerReport CleanerReport { get; set; }
        //private int dirSize = 0;
       
        private List<AdaptedReportItem> adaptedReportList = new List<AdaptedReportItem>();

        public FrmCleanerReport(CleanerReport cleanReport)
        {
            InitializeComponent();
            CleanerReport = cleanReport;
        }

        private void FrmCleanerReport_Load(object sender, EventArgs e)
        {
            InitAdaptedReportList();
            InitListViewCleanerReport();
        }

        private void InitAdaptedReportList()
        {
            foreach (CleanerReportItem item in CleanerReport.Items)
            {
                AdaptedReportItem adaptedItem = new AdaptedReportItem();

                adaptedItem.Name = item.ProcessedItem.Name.ToString();
                
                if (item.ProcessedItem is FileInfo f)
                {
                    adaptedItem.GroupIndex = 1;
                    adaptedItem.ImageIndex = 0;

                    adaptedItem.Size = (double)f.Length / 1000;
                }
                else if (item.ProcessedItem is DirectoryInfo)
                {
                    adaptedItem.GroupIndex = 0;
                    adaptedItem.ImageIndex = 1;

                    adaptedItem.Size = 0;
                }

                if (item.Failed)
                    adaptedItem.Status = "not deleted";
                else
                    adaptedItem.Status = "deleted";

                adaptedItem.LastAccessTime = item.ProcessedItem.LastAccessTime.ToString();

                if(item.Exception!=null)
                    adaptedItem.Exception = item.Exception.ToString();

                adaptedReportList.Add(adaptedItem);
            }
        }
        private void InitListViewCleanerReport()
        {
            lvwCleanerReport.Columns.Clear();
            lvwCleanerReport.Items.Clear();

            lvwCleanerReport.View = View.Details;

            lvwCleanerReport.Scrollable = true;
            lvwCleanerReport.MultiSelect = false;
            lvwCleanerReport.GridLines = true;
            lvwCleanerReport.FullRowSelect = true;

            lvwCleanerReport.Columns.Add("Name", 200, HorizontalAlignment.Left);
            lvwCleanerReport.Columns.Add("Size, Kb", 80, HorizontalAlignment.Left);
            lvwCleanerReport.Columns.Add("Status", 85, HorizontalAlignment.Left);
            lvwCleanerReport.Columns.Add("Last AccesTime", 150, HorizontalAlignment.Left);
            lvwCleanerReport.Columns.Add("Exception", 750, HorizontalAlignment.Left);

            lvwCleanerReport.Groups.Add(new ListViewGroup("Directories", HorizontalAlignment.Left));
            lvwCleanerReport.Groups.Add(new ListViewGroup("Files", HorizontalAlignment.Left));

            foreach (AdaptedReportItem item in adaptedReportList)
            {
              GenerateItem(item);
            }
        }

        private void GenerateItem(AdaptedReportItem item)
        {
            ListViewItem lvItem = new ListViewItem();
            
            lvItem.Group = lvwCleanerReport.Groups[item.GroupIndex];
            lvItem.ImageIndex = item.ImageIndex;

            lvItem.Text = item.Name;
            lvItem.SubItems[0].Text= item.Name;
            lvItem.SubItems.Add($"{item.Size}");
            lvItem.SubItems.Add($"{item.Status}");
            lvItem.SubItems.Add($"{item.LastAccessTime}");
            lvItem.SubItems.Add($"{item.Exception}");

            lvwCleanerReport.Items.Add(lvItem);
        }

        //private void GenerateSavedItem(AdaptedReportItem item)
        //{
        //    ListViewItem lvItem = new ListViewItem();

        //    lvItem.Group = lvwCleanerReport.Groups[item.GroupIndex];
        //    lvItem.ImageIndex = item.ImageIndex;

        //    lvItem.Text = item.Name;
        //    lvItem.SubItems.Add(item.Size.ToString());
        //    lvItem.SubItems.Add(item.Status.ToString());
        //    lvItem.SubItems.Add(item.LastAccessTime.ToString());
        //    lvItem.SubItems.Add(item.Exception?.ToString());

        //    lvwCleanerReport.Items.Add(lvItem);
        //}
/*
        private void GenerateItemFromReport(CleanerReportItem item)
        {
            ListViewItem lvItem = new ListViewItem();
            lvItem.Text = item.ProcessedItem.Name.ToString();
            lvItem.Tag = item;

            // вичисление размера исходной папки
            Calculator calculator = new Calculator();
            double itemSize = 0.0;

            if (item.ProcessedItem is FileInfo f)
            {
                itemSize = (double)f.Length / 1000;
                lvItem.Group = lvwCleanerReport.Groups[1];
                lvItem.ImageIndex = 0;
                lvItem.SubItems.Add($"{itemSize}");

            }
            else if (item.ProcessedItem is DirectoryInfo d)
            {
                //itemSize = (double)calculator.CalcDirSize(d) / 1000;
                lvItem.Group = lvwCleanerReport.Groups[0];
                lvItem.ImageIndex = 1;
                lvItem.SubItems.Add($"");
            }

            lvItem.SubItems[0].Text = item.ProcessedItem.Name.ToString();

            if (item.Failed)
                lvItem.SubItems.Add("not deleted");
            else
                lvItem.SubItems.Add("deleted");

            lvItem.SubItems.Add(item.ProcessedItem.LastAccessTime.ToString());
            lvItem.SubItems.Add(item.Exception?.ToString());

            lvwCleanerReport.Items.Add(lvItem);
        }
*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // изменение цвета кнопок при наведении курсора
        private void btnSetRootDir_MouseEnter(object sender, EventArgs e)
        {
            if (sender as Button == btnClose)
                (sender as Button)!.BackColor = Color.IndianRed;
        }

        private void btnSetRootDir_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button)!.BackColor = Color.LightGray;
        }

        //сохранение в файл
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (lvwCleanerReport.Items == null)
                return;
    
            using FileStream fs = new FileStream($"cleanerReport3.json", FileMode.Create);

            JsonSerializer.Serialize(fs, adaptedReportList, new JsonSerializerOptions()
            {
                WriteIndented = true
            });

            fs.Close();
            MessageBox.Show("Saved");
        }

        //загрузка из файла
        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            try
            {
                using FileStream fs = new FileStream("cleanerReport3.json", FileMode.Open);

                adaptedReportList = JsonSerializer.Deserialize<List<AdaptedReportItem>>(fs);
              
                fs.Close();
                InitListViewCleanerReport();
            }

            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
