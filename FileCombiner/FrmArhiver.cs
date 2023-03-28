using FileProcessor.Archiver;
using FileProcessor.Archiver.Exceptions;
using FileProcessor.Renamer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCombiner
{
    public partial class FrmArhiver : Form
    {
        //public Report renamerReport = new Report();
        private List<DirectoryInfo> Dirs { get; set; }
        private List<string> arhiveFiles { get; set; } = new List<string>();

        private string arhiveMode = string.Empty;
        private ArchiveEngineMode mode;

        public FrmArhiver(List<DirectoryInfo> arhivedDirs)
        {
            InitializeComponent();
            Dirs = arhivedDirs;
        }

        private void FrmArhiver_Load_1(object sender, EventArgs e)
        {
            string[] modes = { "zip", "rar" };
            cmbArhiveMode.Items.AddRange(modes);

            InitListViewArhivedItems();
        }
        private void InitListViewArhivedItems()
        {
            lvwArhivedItems.View = View.Details;

            lvwArhivedItems.Scrollable = true;
            lvwArhivedItems.MultiSelect = false;
            lvwArhivedItems.GridLines = true;
            lvwArhivedItems.FullRowSelect = true;

            lvwArhivedItems.Columns.Add("Name", 300, HorizontalAlignment.Left);
            lvwArhivedItems.Columns.Add("Size, Kb", 100, HorizontalAlignment.Left);
            lvwArhivedItems.Columns.Add("Modification date", 150, HorizontalAlignment.Left);
            lvwArhivedItems.Columns.Add("Path", 500, HorizontalAlignment.Left);
            lvwArhivedItems.Columns.Add("Status", 100, HorizontalAlignment.Left);

            GenerateArhivedItems();
        }

        private void GenerateArhivedItems()
        {
            lvwArhivedItems.Items.Clear();

            Dirs.ForEach(dir =>
            {
                dirSize = 0;
                GenerateItem(dir);
            });
        }

        private void GenerateItem(DirectoryInfo dir)
        {

            if (dir == null)
                return;

            ListViewItem item = new ListViewItem()
            {
                Text = dir.Name,
                ImageIndex = 1,
            };

            int itemSize = CalcDirSize(dir);

            item.Tag = itemSize;

            item.SubItems[0].Text = dir.Name;
            item.SubItems.Add(((double)itemSize/1000).ToString());
            item.SubItems.Add(dir.LastAccessTime.ToString());
            item.SubItems.Add(dir.FullName);

            lvwArhivedItems.Items.Add(item);
        }

        //Calculation
        int dirSize = 0;
        private int CalcDirSize(DirectoryInfo d) //расчет размера директории
        {
            DirectoryInfo[] dirs = d.GetDirectories();
            FileInfo[] files = d.GetFiles();

            foreach (FileInfo file in files)
            {
                dirSize += (int)file.Length;
            }

            foreach (DirectoryInfo dir in dirs)
            {
                CalcDirSize(dir);
            }

            return dirSize;
        }


        private void btnArhive_Click(object sender, EventArgs e)
        {
            ArchiveEngine archiveEngine = new ArchiveEngine(mode);

            ArhiveReport arhiverReport = new ArhiveReport();

            foreach (DirectoryInfo dir in Dirs)
            {
                try
                {
                    string outFile = archiveEngine.CompressDirectory(dir.FullName);
                    arhiveFiles.Add(outFile);

                    arhiverReport.PushSuccess(dir, outFile);
                }
                catch (ArchiverException ex)
                {
                    MessageBox.Show(ex.Message);
                    arhiverReport.PushError(dir, ex);
                }
            }

            Data.arhiverReport = arhiverReport;
            MessageBox.Show("Arhiving completed");

            Close();
        }

        private void cmbArhiveMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArhiveMode.SelectedItem?.ToString() != null)
                arhiveMode = cmbArhiveMode.SelectedItem?.ToString()!;

            if (arhiveMode == "zip")
            {
                mode = ArchiveEngineMode.Zip;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
