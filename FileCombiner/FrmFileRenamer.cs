using FileCombiner.FileCleaner;
using FileProcessor.Renamer;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace FileCombiner
{
    public partial class FrmFileRenamer : Form
    {
        private List<FileInfo> RenamedFiles;
        public Report renamerReport = new Report();

        private string[]? modes;
        private string[]? masks;
        private string renameMode = string.Empty;
        string prefix = string.Empty;

        private Renamer renamer;
        public FrmFileRenamer(List<FileInfo> renamedFiles)
        {
            InitializeComponent();
            RenamedFiles = renamedFiles;
            renamer = new Renamer(renamedFiles);
        }

        private void InitListViewRenamedItems()
        {
            lvwRenamedItems.View = View.Details;

            lvwRenamedItems.Scrollable = true;
            lvwRenamedItems.MultiSelect = false;
            lvwRenamedItems.GridLines = true;
            lvwRenamedItems.FullRowSelect = true;

            lvwRenamedItems.Columns.Add("Name", 300, HorizontalAlignment.Left);
            lvwRenamedItems.Columns.Add("Modification date", 150, HorizontalAlignment.Left);
            lvwRenamedItems.Columns.Add("Path", 500, HorizontalAlignment.Left);
            lvwRenamedItems.Columns.Add("Status", 100, HorizontalAlignment.Left);

            foreach (FileInfo file in RenamedFiles)
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = file.Name;
                lvItem.Tag = file;

                lvItem.SubItems[0].Text = file.Name;
                lvItem.SubItems.Add(file.LastAccessTime.ToString());
                lvItem.SubItems.Add(file.FullName);

                lvwRenamedItems.Items.Add(lvItem);
            }
        }

        private void FrmFileRenamer_Load(object sender, EventArgs e)
        {

            string[] modes = { "ordinal number", "random string", "UUID", "by Mask" };
            cmbRenameMode.Items.AddRange(modes);

            string[] masks = { "{prefix}{UUID}", "{prefix}{autoincrement}" };
            cmbRenameMask.Items.AddRange(masks);

            InitListViewRenamedItems();
        }

        private void cmbRenameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRenameMode.SelectedItem?.ToString() != null)
                renameMode = cmbRenameMode.SelectedItem?.ToString()!;

            if (renameMode == "by Mask")
            {
                txtbSetPrefix.Enabled = true;
                lblSetMask.ForeColor = Color.Black;
                cmbRenameMask.Enabled = true;
                MessageBox.Show("Set Prefix & Rename Mask");
                txtbSetPrefix.Focus();
            }
        }

        private void cmbRenameMask_SelectedIndexChanged(object sender, EventArgs e)
        {
            prefix = txtbSetPrefix.Text;
            if (prefix == null) return;

            if (cmbRenameMask.SelectedItem.ToString() == "{prefix}{UUID}")
                renamer.SetMask(RenamerMask.UUID);

            else if (cmbRenameMask.SelectedItem.ToString() == "{prefix}{autoincrement}")
                renamer.SetMask(RenamerMask.AUTOINCREMENT);
        }

        private Report RenameByMode(string renameMode)
        {
            if (renameMode == "ordinal number")
                renamerReport = renamer.NumberModeRename();
            else if (renameMode == "random string")
                renamerReport = renamer.RandomStringModeRename();
            else if (renameMode == "UUID")
                renamerReport = renamer.UUIDModeRename();

            return renamerReport;
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (cmbRenameMask.SelectedIndex == -1)
                renamerReport = RenameByMode(renameMode);
            else
                renamerReport = renamer.RenameByMask(prefix);

            Data.renamerReport = renamerReport;

            MessageBox.Show("Renaming the selected items was a success");
            Close();
        }


        // изменение цвета кнопок при наведении курсора
        private void btnSetRootDir_MouseEnter(object sender, EventArgs e)
        {
            if (sender as Button == btnRename)
                (sender as Button)!.BackColor = Color.Khaki;
        }

        private void btnSetRootDir_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button)!.BackColor = Color.Silver;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
