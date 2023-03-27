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

            lvwArhiverReport.Columns.Add("ProcessedDirectory", 200, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("ArhiveName", 200, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("Failed", 75, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("Exception", 750, HorizontalAlignment.Left);

            foreach (ArhiveReportItem item in Report.Items)
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = item.ProcessedDirectory.ToString();
                lvItem.Tag = item;

                lvItem.SubItems[0].Text = item.ProcessedDirectory.Name.ToString();
                lvItem.SubItems.Add(item.ArhiveFileName.ToString());
                lvItem.SubItems.Add(item.Failed.ToString());
                lvItem.SubItems.Add(item.Exception?.ToString());

                lvwArhiverReport.Items.Add(lvItem);
            }
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

