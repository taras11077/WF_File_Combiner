using FileProcessor.Archiver;
using FileProcessor;
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

namespace FileCombiner
{
    public partial class FrmCleaningReport : Form
    {
        CleanerReport CleanerReport { get; set; }
        int dirSize = 0;
        public FrmCleaningReport(CleanerReport cleanReport)
        {
            InitializeComponent();
            CleanerReport = cleanReport;
        }

        private void FrmCleaningReport_Load(object sender, EventArgs e)
        {
            InitListViewCleaningReport();
        }

        private void InitListViewCleaningReport()
        {
            lvwCleaningReport.View = View.Details;

            lvwCleaningReport.Scrollable = true;
            lvwCleaningReport.MultiSelect = false;
            lvwCleaningReport.GridLines = true;
            lvwCleaningReport.FullRowSelect = true;

            lvwCleaningReport.Columns.Add("Name", 200, HorizontalAlignment.Left);
            lvwCleaningReport.Columns.Add("Size, Kb", 80, HorizontalAlignment.Left);
            lvwCleaningReport.Columns.Add("Status", 85, HorizontalAlignment.Left);
            lvwCleaningReport.Columns.Add("Last AccesTime", 150, HorizontalAlignment.Left);
            lvwCleaningReport.Columns.Add("Exception", 750, HorizontalAlignment.Left);

            lvwCleaningReport.Groups.Add(new ListViewGroup("Directories", HorizontalAlignment.Left));
            lvwCleaningReport.Groups.Add(new ListViewGroup("Files", HorizontalAlignment.Left));

            foreach (CleanerReportItem item in CleanerReport.Items)
            {
                dirSize = 0;
                GenerateItem(item);
            }
        }

        private void GenerateItem(CleanerReportItem item)
        {
            ListViewItem lvItem = new ListViewItem();
            lvItem.Text = item.ProcessedItem.ToString();
            lvItem.Tag = item;

            // вичисление размера исходной папки
            Calculator calculator = new Calculator();
            double itemSize = 0.0;


            if (item.ProcessedItem is FileInfo f)
            {
                itemSize = (double)f.Length / 1000;
                lvItem.Group = lvwCleaningReport.Groups[1];
                lvItem.ImageIndex = 0;
                lvItem.SubItems.Add($"{itemSize}");

            }
            else if (item.ProcessedItem is DirectoryInfo d)
            {
                //itemSize = (double)calculator.CalcDirSize(d) / 1000;
                lvItem.Group = lvwCleaningReport.Groups[0];
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

            lvwCleaningReport.Items.Add(lvItem);
        }

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
    }
}
