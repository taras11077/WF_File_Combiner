﻿using FileProcessor.Renamer;

namespace FileCombiner
{
    public partial class FrmRenamer : Form
    {
        private List<FileInfo> RenamedFiles;
        public RenamerReport renamerReport = new RenamerReport();

       //private string[]? modes;
        //private string[]? masks;
        private string renameMode = string.Empty;
        string prefix = string.Empty;

        private Renamer renamer;
        public FrmRenamer(List<FileInfo> renamedFiles)
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
                lvItem.ImageIndex = 0;

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

        private RenamerReport RenameByMode(string renameMode)
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

            MessageBox.Show("\tRenaming complete\nYou can see the results by clicking VIEW REPORT");
            Close();
        }



        // изменение цвета кнопок при наведении курсора
        private void btnSetRootDir_MouseEnter(object sender, EventArgs e)
        {
            if (sender as Button == btnRename || sender as Button == btnClose)
                (sender as Button)!.BackColor = Color.SteelBlue;
        }

        private void btnSetRootDir_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button)!.BackColor = Color.LightSteelBlue;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
