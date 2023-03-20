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
using System.Reflection;
using System.IO;
using ListView = System.Windows.Forms.ListView;
using FileCombiner.FileRenamer;

namespace FileCombiner.FileCleaner
{
    public partial class FrmFileCombinerMain : Form
    {
        private ObjectContainer resultContainer = new();

        private List<string> dirPatterns = new()
            {
                ".vs",
                ".DS_Store",
                "Debug",
                "bin",
                "debug",
                "obj",
                "0_intro",
                "1_controls",
                "FileCombine",
                "icons",
            };
        private List<string> filePatterns = new()
            {
                "*.resx",
                "*.cs",
                "*.png",
            };


        public FrmFileCombinerMain(FileCombinerMode mode = FileCombinerMode.Cleaner)
        {
            InitializeComponent();

            switch(mode)
            {
                case FileCombinerMode.Cleaner:
                    BackColor = Color.RosyBrown;
                    btnRename.Enabled = false;
                    btnArhiver.Enabled = false;
                   break;

                case FileCombinerMode.Renamer:
                    BackColor = Color.LemonChiffon;
                    btnArhiver.Enabled = false;
                    btnClear.Enabled = false;
                    chbMoveToTrash.Enabled = false;
                    break;

                case FileCombinerMode.Arhiver:
                    BackColor = Color.DarkSeaGreen;
                    btnRename.Enabled = false;
                    btnClear.Enabled = false;
                    chbMoveToTrash.Enabled = false;
                    break;
            }

        }
        //Init
        private void InitListViewRemovedItems()
        {
            lvwRemovedItems.View = View.Details;
            //lvwRemovedItems.CheckBoxes = true;

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
            lvwResultInfo.Columns.Clear();
            lvwResultInfo.Items.Clear();

            lvwResultInfo.View = View.Details;
            lvwResultInfo.MultiSelect = false;
            lvwResultInfo.GridLines = true;
            lvwResultInfo.FullRowSelect = true;

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
            @checked.SubItems.Add(CalcCheckedFullSize().ToString());
            lvwResultInfo.Items.Add(@checked);
        }
        private void FrmFileCleanerMain_Load(object sender, EventArgs e)
        {
            InitListViewRemovedItems();
            InitListViewResultInfo();
            lstbDirPatterns.Items.AddRange(dirPatterns.ToArray());
            lstbFilePatterns.Items.AddRange(filePatterns.ToArray());
        }

        // Settings
        private void btnSetRootDir_Click(object sender, EventArgs e)
        {
            if (fbSetRootDirDialog.ShowDialog() == DialogResult.Cancel)
                return;

            txtbPathRootDir.Text = fbSetRootDirDialog.SelectedPath;
            txtbPathRootDir.BackColor = Color.Bisque;
            txtbPathRootDir.ForeColor = Color.Black;
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

        //Finding
        private void btnFind_Click(object sender, EventArgs e)
        {
            StartProgressBar();

            string path = txtbPathRootDir.Text;
            try
            {
                if (!Directory.Exists(path))
                    throw new DirectoryNotFoundException();

                Finder finder = new Finder();
                finder.DirMasks = dirPatterns.ToArray();
                finder.FileMasks = filePatterns.ToArray();

                finder.FindAll(path);
                resultContainer = finder.ResultContainer;

                GenerateFindedItems();
                InitListViewResultInfo();
                lvwRemovedItems.CheckBoxes = true;

                MessageBox.Show("Search completed successfully");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(($"Directory {path} not found"));
            }
        }
        private void GenerateFindedItems()
        {
            lvwRemovedItems.Items.Clear();
           
            resultContainer.Dirs.ForEach(dir =>
            {
                dirSize = 0;
                GenerateItem(dir);

            });

            resultContainer.Files.ForEach(file =>
            {
                GenerateItem(file);
            });
        }
        private void GenerateItem(FileSystemInfo type)
        {

            if (type == null)
                return;

            ListViewItem item = new ListViewItem()
            {
                Text = type.Name,
                Tag = type,
            };

            int itemSize;
            if (type is DirectoryInfo)
            {
                item.Group = lvwRemovedItems.Groups[0];
                item.ImageIndex = 1;
                itemSize = CalcDirSize(type as DirectoryInfo);
            }
            else
            {
                item.Group = lvwRemovedItems.Groups[1];
                item.ImageIndex = 0;
                itemSize = (int)(type as FileInfo).Length;
            }

            item.SubItems[0].Text = type.Name;
            item.SubItems[0].Tag = itemSize; // присвоил size елемента свойству Tag нулевого SubItem
            item.SubItems.Add(itemSize.ToString());
            item.SubItems.Add(type.LastAccessTime.ToString());
            item.SubItems.Add(type.FullName);

            lvwRemovedItems.Items.Add(item);
        }

        //Checked

        // изменение свойства Checked вложенних файлов в соответствии с родительской папкой
        private void CheckFiles(DirectoryInfo d, ItemCheckedEventArgs e)
        {
            resultContainer.Files.ForEach(file =>
            {
                if (file.FullName.Contains(d.FullName))
                {
                    foreach (ListViewItem item in lvwRemovedItems.Items)
                    {
                        if (file == (item.Tag as FileInfo))
                            item.Checked = e.Item.Checked;
                    }
                }
            });

            resultContainer.Dirs.ForEach(dir =>
            {
                if (dir.FullName.Contains(d.FullName) && dir.FullName != d.FullName)
                    CheckFiles(dir, e);
            });
        }
        private void lvwRemovedItems_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Tag is DirectoryInfo d)
                CheckFiles(d, e);

            //InitListViewResultInfo(); // !!! сильно тормозит процесс, может просто переделать на кнопку Update?
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
        private int CalcFindedFullSize() // расчет размера всех найдених елементов
        {
            int size = 0;

            foreach (ListViewItem item in lvwRemovedItems.Items)
            {
                if (item.Tag is DirectoryInfo d) // если елемент - папка
                    size += (int)item.SubItems[0].Tag!;

                else if (item.Tag is FileInfo f) // если елемент - файл и не принадлежит ни одной папке, то его size+ 
                {
                    bool flag = true;
                    foreach (DirectoryInfo dir in resultContainer.Dirs)
                    {
                        if (f.FullName.Contains(dir.FullName)) // проверка на непринадлежность файла папке из списка найдених папок
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                        size += (int)f.Length;
                }
            }
            return size;
        }
        private int CalcCheckedFullSize() // расчет размера всех checked-елементов
        {
            int size = 0;

            foreach (ListViewItem item in lvwRemovedItems.CheckedItems)
            {
                if (item.Tag is DirectoryInfo d) // если елемент - папка
                    size += (int)item.SubItems[0].Tag!;

                else if (item.Tag is FileInfo f) // если елемент - файл и не принадлежит ни одной папке, то его size+ 
                {
                    bool flag = true;
                    // если в CheckedItems есть папка(она чекнутая) и ее имя в имени файла, 
                    // то цикл преривается (с флагом=false) и его размер не учитивается в сумму чекнутих елементов
                    // если такой папки нет, то цикл проходит до конца (flag=true) и размер файла добавляется в сумму

                    foreach (ListViewItem item2 in lvwRemovedItems.CheckedItems)
                    {
                        if ((item2.Tag is DirectoryInfo dir) && f.FullName.Contains(dir.FullName)) // проверка на непринадлежность файла папке из списка найдених папок
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                        size += (int)f.Length;
                }
            }
            return size;
        }


        //Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Remove", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            StartProgressBar();

            Remover remover = new Remover();

            if (chbMoveToTrash.Checked) // если в корзину
                remover.trash = true;

            // создание списков для Remover (привязка к Listview)
            foreach (ListViewItem item in lvwRemovedItems.Items)
            {
                if (item.Tag is DirectoryInfo d)
                    remover.ListItems.Dirs.Add(d);
                else if (item.Tag is FileInfo f)
                    remover.ListItems.Files.Add(f);
            }

            foreach (ListViewItem item in lvwRemovedItems.CheckedItems)
            {
                if (item.Tag is DirectoryInfo d)
                    remover.RemovedItems.Dirs.Add(d);
                else if (item.Tag is FileInfo f)
                    remover.RemovedItems.Files.Add(f);
            }


            try
            {
                remover.Remove(remover.trash);

                resultContainer = new(remover.ListItems.Dirs, remover.ListItems.Files); // создание нового resulContainer после удаления елементов
                GenerateFindedItems();                                                  // генепация елементов и создание нового ListView

                MessageBox.Show("Selected items removed");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n File or directory not found!");
            }

            InitListViewResultInfo();
        }




        //Small details
        private void StartProgressBar()
        {
            progressBar1.Value = 0;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;

            for (int i = 0; i <= 100; ++i)
            {
                progressBar1.PerformStep();

                Update();
                Thread.Sleep(10);
            }
        }

        private void chbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            StartProgressBar();

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
                (sender as Button)!.BackColor = Color.SteelBlue;
            else if (sender as Button == btnClear)
                (sender as Button)!.BackColor = Color.IndianRed;
            else if (sender as Button == btnRename)
                (sender as Button)!.BackColor = Color.Khaki;
            else if (sender as Button == btnArhiver)
                (sender as Button)!.BackColor = Color.MediumSeaGreen;
        }

        private void btnSetRootDir_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button)!.BackColor = Color.LightSteelBlue;
        }




        private void btnRename_Click(object sender, EventArgs e)
        {
            FrmFileRenamer frm = new FrmFileRenamer();
            frm.ShowDialog();
        }
    }
}
