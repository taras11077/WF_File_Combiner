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

            lvwArhiverReport.Columns.Add("ProcessedDirectory", 150, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("ArhiveFileName", 200, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("ArhiveSize", 100, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("Failed archiving", 100,HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("Exception", 300, HorizontalAlignment.Left);

            foreach (ArhiveReportItem item in Report.Items)
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = item.ProcessedDirectory.ToString();
                lvItem.Tag = item;


                if(item.Failed)
                {
                    lvItem.SubItems[0].Text = item.ProcessedDirectory.Name.ToString();
                    lvItem.SubItems.Add(string.Empty);
                    lvItem.SubItems.Add(string.Empty);
                    lvItem.SubItems.Add(item.Failed.ToString());
                    lvItem.SubItems.Add(item.Exception?.ToString());
                }
                else
                {
                    lvItem.SubItems[0].Text = item.ProcessedDirectory.Name.ToString();
                    lvItem.SubItems.Add(item.ArhiveFileName.ToString());
                    lvItem.SubItems.Add(string.Empty);
                    lvItem.SubItems.Add(item.Failed.ToString());
                    lvItem.SubItems.Add(string.Empty);
                }
               
                

                lvwArhiverReport.Items.Add(lvItem);
            }
        }
        /*
        private void GenerateItem(DirectoryInfo dir)
        {

            if (dir == null)
                return;

            ListViewItem item = new ListViewItem()
            {
                Text = dir.Name,
                Tag = dir,
                ImageIndex = 1,
            };

            int itemSize = CalcDirSize(dir);

            item.SubItems[0].Text = dir.Name;
            item.SubItems[0].Tag = itemSize; // присвоил size елемента свойству Tag нулевого SubItem
            item.SubItems.Add(itemSize.ToString());
            item.SubItems.Add(dir.LastAccessTime.ToString());
            item.SubItems.Add(dir.FullName);

            lvwArhivedItems.Items.Add(item);
        }
        */


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

