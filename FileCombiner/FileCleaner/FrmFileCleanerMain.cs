using FileProcessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Security.Policy;
using Button = System.Windows.Forms.Button;
using System.Text.Json;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualBasic.ApplicationServices;

namespace FileCombiner.FileCleaner
{
    public partial class FrmFileCleanerMain : Form
    {
        private ObjectContainer ResultContainer = new();
        private int findedCount = 0;
        private int findedSize = 0;
        private int checkedCount = 0;
        private int checkedSize = 0;

        private List<string> dirPatterns = new()
            {
                //".vs",
                //".DS_Store",
                //"Debug",
                //"bin",
                //"debug",
                //"obj"
                "icons"
            };

        private List<string> filePatterns = new()
            {
                //"*.resx",
                //"*.cs",
                "*.png",
            };




        public FrmFileCleanerMain()
        {
            InitializeComponent();
        }

        private void InitListViewRemovedItems()
        {
            lvwRemovedItems.View = View.Details;
            lvwRemovedItems.CheckBoxes = true;

            lvwRemovedItems.Scrollable = true;
            lvwRemovedItems.MultiSelect = false;
            lvwRemovedItems.GridLines = true;
            lvwRemovedItems.FullRowSelect = true;

            lvwRemovedItems.Columns.Add("Name", 200, HorizontalAlignment.Left);
            lvwRemovedItems.Columns.Add("Size", 100, HorizontalAlignment.Left);
            lvwRemovedItems.Columns.Add("Modification date", 150, HorizontalAlignment.Left);
            lvwRemovedItems.Columns.Add("Path", 500, HorizontalAlignment.Left);
            lvwRemovedItems.Columns.Add("Status", 100, HorizontalAlignment.Left);

            lvwRemovedItems.Groups.Add(new ListViewGroup("Directories", HorizontalAlignment.Left));
            lvwRemovedItems.Groups.Add(new ListViewGroup("Files", HorizontalAlignment.Left));
        }

        private void InitListViewResultInfo()
        {
            lvwResultInfo.View = View.Details;
            lvwResultInfo.MultiSelect = false;
            lvwResultInfo.GridLines = true;
            lvwResultInfo.FullRowSelect = true;

            lvwResultInfo.Columns.Clear();
            lvwResultInfo.Items.Clear();

            lvwResultInfo.Columns.Add("STATUS", 100, HorizontalAlignment.Left);
            lvwResultInfo.Columns.Add("COUNT", 100, HorizontalAlignment.Left);
            lvwResultInfo.Columns.Add("FULL SIZE", 100, HorizontalAlignment.Left);

            ListViewItem finded = new ListViewItem();
            finded.SubItems[0].Text = "Finded";
            finded.SubItems.Add(lvwRemovedItems.Items.Count.ToString());
            finded.SubItems.Add(CalcFindedFullSize().ToString());
            lvwResultInfo.Items.Add(finded);

            ListViewItem @checked = new ListViewItem();
            @checked.SubItems[0].Text = "Checked";
            @checked.SubItems.Add(lvwRemovedItems.CheckedItems.Count.ToString());
            @checked.SubItems.Add(CalcCheckItemsFullSize().ToString());
            lvwResultInfo.Items.Add(@checked);
        }


        private void FrmFileCleanerMain_Load(object sender, EventArgs e)
        {
            InitListViewRemovedItems();
            InitListViewResultInfo();
            lstbDirPatterns.Items.AddRange(dirPatterns.ToArray());
            lstbFilePatterns.Items.AddRange(filePatterns.ToArray());
        }

        private void btnSetRootDir_Click(object sender, EventArgs e)
        {
            if (fbSetRootDirDialog.ShowDialog() == DialogResult.Cancel)
                return;

            lblPathRootDir.Text = fbSetRootDirDialog.SelectedPath;
            lblPathRootDir.BackColor = Color.Bisque;
            lblPathRootDir.ForeColor = Color.Black;
        }
        private void btnAddDirPatterns_Click(object sender, EventArgs e)
        {
            if (txtbDirPatterns.Text.Length == 0)
                return;

            dirPatterns.Add(txtbDirPatterns.Text);
            lstbDirPatterns.Items.Add(txtbDirPatterns.Text);

            txtbDirPatterns.Clear();
        }
        private void btnRemoveDirPatterns_Click(object sender, EventArgs e)
        {
            if (lstbDirPatterns.SelectedItem == null)
                return;

            dirPatterns?.Remove(lstbDirPatterns.SelectedItem.ToString()!);
            lstbDirPatterns.Items?.Remove(lstbDirPatterns.SelectedItem.ToString()!);
        }
        private void btnAddFilePatterns_Click(object sender, EventArgs e)
        {
            if (txtbFilePatterns.Text.Length == 0)
                return;

            filePatterns.Add(txtbFilePatterns.Text);
            lstbFilePatterns.Items.Add(txtbFilePatterns.Text);

            txtbFilePatterns.Clear();
        }
        private void btnRemoveFilePatterns_Click(object sender, EventArgs e)
        {
            if (lstbFilePatterns.SelectedItem == null)
                return;

            filePatterns?.Remove(lstbFilePatterns.SelectedItem.ToString()!);
            lstbFilePatterns.Items?.Remove(lstbFilePatterns.SelectedItem.ToString()!);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            StartProgressBar();

            string path = lblPathRootDir.Text;
            Finder finder = new Finder();
            finder.DirMasks = dirPatterns.ToArray();
            finder.FileMasks = filePatterns.ToArray();

            finder.FindAll(path);

            ResultContainer = finder.ResultContainer;

            GenerateItem();
            InitListViewResultInfo();
            MessageBox.Show("Search ended");
        }
        private void GenerateItem()
        {
            ResultContainer.Dirs.ForEach(dir =>
            {
                ListViewItem item = new ListViewItem()
                {
                    Text = dir.Name,
                    Tag = dir,
                    Group = lvwRemovedItems.Groups[0],
                    ImageIndex = 1,
                };

                item.SubItems[0].Text = dir.Name;
                item.SubItems.Add(CalcDirSize(dir).ToString());
                item.SubItems.Add(dir.LastAccessTime.ToString());
                item.SubItems.Add(dir.FullName);

                lvwRemovedItems.Items.Add(item);
            });

            ResultContainer.Files.ForEach(file =>
            {
                ListViewItem item = new ListViewItem()
                {
                    Text = file.Name,
                    Tag = file,
                    Group = lvwRemovedItems.Groups[1],
                    ImageIndex = 0,
                };

                item.SubItems[0].Text = file.Name;
                item.SubItems.Add(file.Length.ToString());
                item.SubItems.Add(file.LastAccessTime.ToString());
                item.SubItems.Add(file.FullName);

                lvwRemovedItems.Items.Add(item);
            });
        }

        int dirSize = 0;
        public int CalcDirSize(DirectoryInfo d) //расчет размера директории
        {
            DirectoryInfo[] dirs = d.GetDirectories();
            FileInfo[] files = d.GetFiles();

            foreach (FileInfo file in files)
                dirSize += (int)file.Length;

            foreach (DirectoryInfo dir in dirs)
                CalcDirSize(dir);

            return dirSize;
        }
        private int CalcFindedFullSize() // расчет размера всех finded елементов
        {
            int size = 0;
            dirSize = 0;

            if (lvwRemovedItems.Items == null)
                return 0;

            foreach (ListViewItem item in lvwRemovedItems.Items)
            {
                DirectoryInfo? d = item.Tag as DirectoryInfo;
                if (d != null)
                    size += CalcDirSize(d);

                //FileInfo? f = item.Tag as FileInfo;
                //   if (f != null)
                //     size += (int)f.Length;
            }

            return size;
        }
        private int CalcCheckItemsFullSize() // расчет размера checked елементов
        {
            int size = 0;
            dirSize = 0;

            if (lvwRemovedItems.CheckedItems == null)
                return 0;

            foreach (ListViewItem item in lvwRemovedItems.CheckedItems)
            {
                //DirectoryInfo? d = item.Tag as DirectoryInfo;
                //if (d != null)
                //   size += CalcDirSize(d);

                FileInfo? f = item.Tag as FileInfo;
                if (f != null)
                    size += (int)f.Length;
            }
            return size;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Remove", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;

            try
            {
                StartProgressBar();

                foreach (ListViewItem item in lvwRemovedItems.CheckedItems)
                {
                    string? filename = item.Tag.ToString();

                    if (filename != null && item.Tag is FileInfo)
                    {
                        if (chbMoveToTrash.Checked)
                            Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(filename, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                        else
                            File.Delete(filename);

                        lvwRemovedItems.Items.Remove(item);
                    }
                }

                foreach (ListViewItem item in lvwRemovedItems.CheckedItems)
                {
                    string? filename = item.Tag.ToString();

                    if (filename != null && item.Tag is DirectoryInfo)
                    {
                        if (chbMoveToTrash.Checked)
                            Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(filename, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                        else
                            Directory.Delete(filename);

                        lvwRemovedItems.Items.Remove(item);
                    }
                }
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n File or directory not found!");
            }

            //findedCount = lvwRemovedItems.Items.Count;
            //findedSize = CalcFindedFullSize();

            InitListViewResultInfo();
        }




        private void CheckFiles(DirectoryInfo d)
        {
            DirectoryInfo[] dirs = d.GetDirectories();
            FileInfo[] files = d.GetFiles();

            //foreach (FileInfo file in files)
            foreach (ListViewItem item in lvwRemovedItems.Items)
                if (files.Contains(item.Tag))
                    //if (file == item.Tag)
                    item.Checked = true;


            foreach (DirectoryInfo dir in dirs)
                CheckFiles(dir);
        }

        private void lvwRemovedItems_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Tag is DirectoryInfo d)
                CheckFiles(d);

            InitListViewResultInfo();
        }







        private void StartProgressBar()
        {
            lblProgress.Text = "Progress status: 0%";
            progressBar1.Value = 0;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;

            for (int i = 0; i <= 100; ++i)
            {
                progressBar1.PerformStep();

                lblProgress.Text = $"Progress status: {i}%";

                Update();
                Thread.Sleep(10);
            }
        }

        private void chbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwRemovedItems.Items)
                item.Checked = chbSelectAll.Checked;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // изменение цвета кнопок при наведении курсора
        private void btnSetRootDir_MouseEnter(object sender, EventArgs e)
        {
            if (sender as Button == btnSetRootDir || sender as Button == btnAddDirPatterns || sender as Button == btnRemoveDirPatterns || sender as Button == btnAddFilePatterns || sender as Button == btnRemoveFilePatterns || sender as Button == btnClose)
                (sender as Button)!.BackColor = Color.SteelBlue;
            else if (sender as Button == btnFind)
                (sender as Button)!.BackColor = Color.DarkSeaGreen;
            else if (sender as Button == btnClear)
                (sender as Button)!.BackColor = Color.IndianRed;
        }

        private void btnSetRootDir_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button)!.BackColor = Color.LightSteelBlue;
        }


    }
}
