using FileProcessor.Renamer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCombiner
{
    public partial class FrmRenamerReport : Form
    {
        RenamerReport Report { get; set; }

        public FrmRenamerReport(RenamerReport report)
        {
            InitializeComponent();
            Report = report;
        }

        private void FrmRenamerReport_Load(object sender, EventArgs e)
        {
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

            foreach (RenamerReportItem item in Report.Items)
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = item.ProcessedFile.ToString();
                lvItem.Tag = item;
                lvItem.ImageIndex = 0;

                lvItem.SubItems[0].Text = item.ProcessedFile.Name.ToString();
                if (item.Failed)
                    lvItem.SubItems.Add("not renamed");
                else
                    lvItem.SubItems.Add("renamed");

                lvItem.SubItems.Add(item.ProcessedFile.LastAccessTime.ToString());
                lvItem.SubItems.Add(item.Exception?.ToString());

                lvwRenamedReport.Items.Add(lvItem);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // изменение цвета кнопок при наведении курсора
        private void btnSetRootDir_MouseEnter(object sender, EventArgs e)
        {
            if (sender as Button == btnClose)
                (sender as Button)!.BackColor = Color.SteelBlue;
        }

        private void btnSetRootDir_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button)!.BackColor = Color.LightGray;
        }
    }
}
