using FileProcessor.Archiver;
using FileProcessor.Renamer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCombiner
{
    public partial class FrmRenamerReport : Form
    {
        RenamerReport Report { get; set; }
        private List<AdaptedReportItem> adaptedReportList = new List<AdaptedReportItem>();

        public FrmRenamerReport(RenamerReport report)
        {
            InitializeComponent();
            Report = report;
        }

        private void FrmRenamerReport_Load(object sender, EventArgs e)
        {
            InitAdaptedReportList();
            InitListViewRenamedReport();
        }



        private void InitListViewRenamedReport()
        {
            lvwRenamedReport.View = View.Details;

            lvwRenamedReport.Scrollable = true;
            lvwRenamedReport.MultiSelect = false;
            lvwRenamedReport.GridLines = true;
            lvwRenamedReport.FullRowSelect = true;

            lvwRenamedReport.Columns.Add("Processed files", 330, HorizontalAlignment.Left);
            lvwRenamedReport.Columns.Add("Status", 75, HorizontalAlignment.Left);
            lvwRenamedReport.Columns.Add("Last AccesTime", 150, HorizontalAlignment.Left);
            lvwRenamedReport.Columns.Add("Exception", 750, HorizontalAlignment.Left);

            foreach (AdaptedReportItem item in adaptedReportList)
            {
                GenerateListViewItem(item);
            }
        }

        private void InitAdaptedReportList()
        {
            foreach (RenamerReportItem item in Report.Items)
            {
                AdaptedReportItem adaptedItem = new AdaptedReportItem();

                adaptedItem.Name = item.ProcessedFile.Name.ToString();
                adaptedItem.ImageIndex = 0;

                adaptedItem.LastAccessTime = item.ProcessedFile.LastAccessTime.ToString();

                if (item.Failed)
                    adaptedItem.Status = "not renamed";
                else
                    adaptedItem.Status = "renamed";

                if (item.Exception != null)
                    adaptedItem.Exception = item.Exception.ToString();

                adaptedReportList.Add(adaptedItem);
            }
        }

        private void GenerateListViewItem(AdaptedReportItem item)
        {
            ListViewItem lvItem = new ListViewItem();

            lvItem.ImageIndex = item.ImageIndex;

            lvItem.Text = item.Name;
            lvItem.SubItems[0].Text = item.Name;
            lvItem.SubItems.Add($"{item.Status}");
            lvItem.SubItems.Add($"{item.LastAccessTime}");
            lvItem.SubItems.Add($"{item.Exception}");

            lvwRenamedReport.Items.Add(lvItem);
        }

        // сохранение в файл
        private void btnSave_Click(object sender, EventArgs e)
        {
            openFileDialogRenamer.InitialDirectory = "D:\\step\\repos\\HW\\FileCombiner (my)\\FileCombiner\\ReportsRenamer";

            if (saveFileDialogRenamer.ShowDialog() == DialogResult.Cancel)
                return;

            string fileName = saveFileDialogRenamer.FileName;
            saveFileDialogRenamer.InitialDirectory = Directory.GetParent(fileName)?.Name;


            if (Report.Items == null)
                return;

            using FileStream fs = new FileStream(fileName, FileMode.Create);

            JsonSerializer.Serialize(fs, adaptedReportList, new JsonSerializerOptions()
            {
                WriteIndented = true
            });

            fs.Close();
            MessageBox.Show("Report saved");
        }

        //загрузка из файла
        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialogRenamer.InitialDirectory = "D:\\step\\repos\\HW\\FileCombiner (my)\\FileCombiner\\ReportsRenamer";

            if (openFileDialogRenamer.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialogRenamer.FileName;
            
            try
            {
                using FileStream fs = new FileStream(filename, FileMode.Open);

                adaptedReportList = JsonSerializer.Deserialize<List<AdaptedReportItem>>(fs);

                fs.Close();
                InitListViewRenamedReport();
            }

            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        // изменение цвета кнопок при наведении курсора
        private void btnSetRootDir_MouseEnter(object sender, EventArgs e)
        {
            if (sender as Button == btnClose || sender as Button == btnSave || sender as Button == btnLoad)
                (sender as Button)!.BackColor = Color.SteelBlue;
        }
        private void btnSetRootDir_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button)!.BackColor = Color.LightSteelBlue;
        }        
    }
}
