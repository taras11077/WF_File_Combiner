using FileProcessor;
using FileProcessor.Archiver;
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
    public partial class FrmArhiverReport : Form
    {
        ArhiveReport Report { get; set; }

        int dirSize = 0;

        public FrmArhiverReport(ArhiveReport report)
        {
            InitializeComponent();
            Report = report;
        }


        private void FrmArhiverReport_Load(object sender, EventArgs e)
        {
            InitListViewArhiverReport();
        }

        private void InitListViewArhiverReport()
        {
            lvwArhiverReport.View = View.Details;

            lvwArhiverReport.Scrollable = true;
            lvwArhiverReport.MultiSelect = false;
            lvwArhiverReport.GridLines = true;
            lvwArhiverReport.FullRowSelect = true;

            lvwArhiverReport.Columns.Add("ProcessedDirectory", 150, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("DirSize, Kb", 100, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("ArhiveFileName", 150, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("ArhiveSize, Kb", 120, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("Path", 370, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("Failed archiving", 120, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("Exception", 500, HorizontalAlignment.Left);

            foreach (ArhiveReportItem item in Report.Items)
            {
                dirSize = 0;
                GenerateItem(item);
            }
        }

        private void GenerateItem(ArhiveReportItem item)
        {
            ListViewItem lvItem = new ListViewItem();
            lvItem.Text = item.ProcessedDirectory.ToString();
            lvItem.Tag = item;

            Calculator calculator = new Calculator();
            // вичисление размера исходной папки

            double dirSize = (double)calculator.CalcDirSize(item.ProcessedDirectory) / 1000;

            string arhiveName = string.Empty;
            double arhiveSize = 0;

            if (item.ArhiveFileName != "") // если архив создан
            {
                // виделение имени архива из полного имени
                int slashInd = item.ArhiveFileName.LastIndexOf('\\');  //поиск индекса последнего слеша
                arhiveName = item.ArhiveFileName.Substring(slashInd + 1, item.ArhiveFileName.Length - slashInd - 1);

                // вичисление размера архива
                System.IO.FileInfo file = new System.IO.FileInfo(item.ArhiveFileName);
                arhiveSize = (double)file.Length / 1000;
            }

            lvItem.ImageIndex = 1;
            lvItem.SubItems[0].Text = item.ProcessedDirectory.Name.ToString();
            lvItem.SubItems.Add($"{dirSize}");
            lvItem.SubItems.Add(arhiveName.ToString());
            lvItem.SubItems.Add($"{arhiveSize}");
            lvItem.SubItems.Add(item.ArhiveFileName);
            lvItem.SubItems.Add(item.Failed.ToString());
            lvItem.SubItems.Add(item.Exception?.ToString());

            lvwArhiverReport.Items.Add(lvItem);
        }

        // изменение цвета кнопок при наведении курсора
        private void btnSetRootDir_MouseEnter(object sender, EventArgs e)
        {
            if (sender as Button == btnClose)
                (sender as Button)!.BackColor = Color.MediumSeaGreen;
        }

        private void btnSetRootDir_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button)!.BackColor = Color.Silver;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }




}

