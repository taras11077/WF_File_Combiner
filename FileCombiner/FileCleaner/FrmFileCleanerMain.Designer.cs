namespace FileCombiner.FileCleaner
{
    partial class FrmFileCleanerMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFileCleanerMain));
            iconImgList = new ImageList(components);
            btnSetDirPatterns = new Button();
            lstbDirPatterns = new ListBox();
            btnFind = new Button();
            lstbFilePatterns = new ListBox();
            btnSetFilePatterns = new Button();
            btnClear = new Button();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            chbMoveToTrash = new CheckBox();
            btnSetRootDir = new Button();
            lblPathRootDir = new Label();
            lblProgress = new Label();
            lblRemovedListTitle = new Label();
            fbSetRootDirDialog = new FolderBrowserDialog();
            lvwRemovedItems = new ListView();
            chbSelectAll = new CheckBox();
            lvwResultInfo = new ListView();
            btnClose = new Button();
            SuspendLayout();
            // 
            // iconImgList
            // 
            iconImgList.ColorDepth = ColorDepth.Depth8Bit;
            iconImgList.ImageStream = (ImageListStreamer)resources.GetObject("iconImgList.ImageStream");
            iconImgList.TransparentColor = Color.Transparent;
            iconImgList.Images.SetKeyName(0, "file.png");
            iconImgList.Images.SetKeyName(1, "folder-invoices--v1.png");
            iconImgList.Images.SetKeyName(2, "delete.png");
            iconImgList.Images.SetKeyName(3, "delete-sign--v1.png");
            iconImgList.Images.SetKeyName(4, "image-file.png");
            iconImgList.Images.SetKeyName(5, "picture--v1.png");
            iconImgList.Images.SetKeyName(6, "cancel--v1.png");
            iconImgList.Images.SetKeyName(7, "briefcase.png");
            // 
            // btnSetDirPatterns
            // 
            btnSetDirPatterns.BackColor = SystemColors.InactiveCaption;
            btnSetDirPatterns.Location = new Point(8, 420);
            btnSetDirPatterns.Name = "btnSetDirPatterns";
            btnSetDirPatterns.Size = new Size(200, 30);
            btnSetDirPatterns.TabIndex = 1;
            btnSetDirPatterns.Text = "Set Dir patterns";
            btnSetDirPatterns.UseVisualStyleBackColor = false;
            btnSetDirPatterns.Click += btnSetDirPatterns_Click;
            btnSetDirPatterns.MouseEnter += btnSetRootDir_MouseEnter;
            btnSetDirPatterns.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // lstbDirPatterns
            // 
            lstbDirPatterns.FormattingEnabled = true;
            lstbDirPatterns.ItemHeight = 20;
            lstbDirPatterns.Location = new Point(8, 459);
            lstbDirPatterns.Name = "lstbDirPatterns";
            lstbDirPatterns.Size = new Size(200, 104);
            lstbDirPatterns.TabIndex = 2;
            // 
            // btnFind
            // 
            btnFind.BackColor = SystemColors.InactiveCaption;
            btnFind.Location = new Point(842, 423);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(150, 35);
            btnFind.TabIndex = 3;
            btnFind.Text = "FIND";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            btnFind.MouseEnter += btnSetRootDir_MouseEnter;
            btnFind.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // lstbFilePatterns
            // 
            lstbFilePatterns.FormattingEnabled = true;
            lstbFilePatterns.ItemHeight = 20;
            lstbFilePatterns.Location = new Point(252, 459);
            lstbFilePatterns.Name = "lstbFilePatterns";
            lstbFilePatterns.Size = new Size(200, 104);
            lstbFilePatterns.TabIndex = 4;
            // 
            // btnSetFilePatterns
            // 
            btnSetFilePatterns.BackColor = SystemColors.InactiveCaption;
            btnSetFilePatterns.Location = new Point(250, 420);
            btnSetFilePatterns.Name = "btnSetFilePatterns";
            btnSetFilePatterns.Size = new Size(200, 30);
            btnSetFilePatterns.TabIndex = 5;
            btnSetFilePatterns.Text = "Set File patterns";
            btnSetFilePatterns.UseVisualStyleBackColor = false;
            btnSetFilePatterns.Click += btnSetFilePatterns_Click;
            btnSetFilePatterns.MouseEnter += btnSetRootDir_MouseEnter;
            btnSetFilePatterns.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.InactiveCaption;
            btnClear.Location = new Point(842, 528);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 35);
            btnClear.TabIndex = 6;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            btnClear.MouseEnter += btnSetRootDir_MouseEnter;
            btnClear.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(496, 430);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 8;
            label2.Text = "Result Info:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 607);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(792, 20);
            progressBar1.TabIndex = 9;
            // 
            // chbMoveToTrash
            // 
            chbMoveToTrash.AutoSize = true;
            chbMoveToTrash.Location = new Point(855, 498);
            chbMoveToTrash.Name = "chbMoveToTrash";
            chbMoveToTrash.RightToLeft = RightToLeft.Yes;
            chbMoveToTrash.Size = new Size(122, 24);
            chbMoveToTrash.TabIndex = 10;
            chbMoveToTrash.Text = "Move to trash";
            chbMoveToTrash.UseVisualStyleBackColor = true;
            // 
            // btnSetRootDir
            // 
            btnSetRootDir.BackColor = SystemColors.InactiveCaption;
            btnSetRootDir.Location = new Point(8, 373);
            btnSetRootDir.Name = "btnSetRootDir";
            btnSetRootDir.Size = new Size(200, 30);
            btnSetRootDir.TabIndex = 11;
            btnSetRootDir.Text = "Set Root Dir";
            btnSetRootDir.UseVisualStyleBackColor = false;
            btnSetRootDir.Click += btnSetRootDir_Click;
            btnSetRootDir.MouseEnter += btnSetRootDir_MouseEnter;
            btnSetRootDir.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // lblPathRootDir
            // 
            lblPathRootDir.AutoSize = true;
            lblPathRootDir.BackColor = SystemColors.InactiveCaption;
            lblPathRootDir.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPathRootDir.ForeColor = SystemColors.InactiveCaption;
            lblPathRootDir.Location = new Point(252, 376);
            lblPathRootDir.Name = "lblPathRootDir";
            lblPathRootDir.Size = new Size(198, 23);
            lblPathRootDir.TabIndex = 12;
            lblPathRootDir.Text = "C:\\Users\\Master\\Desktop";
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.BackColor = Color.Transparent;
            lblProgress.Location = new Point(357, 584);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(134, 20);
            lblProgress.TabIndex = 13;
            lblProgress.Text = "Progress status: 0%";
            // 
            // lblRemovedListTitle
            // 
            lblRemovedListTitle.AutoSize = true;
            lblRemovedListTitle.Location = new Point(19, 17);
            lblRemovedListTitle.Name = "lblRemovedListTitle";
            lblRemovedListTitle.Size = new Size(115, 20);
            lblRemovedListTitle.TabIndex = 14;
            lblRemovedListTitle.Text = "Removed Items:";
            // 
            // lvwRemovedItems
            // 
            lvwRemovedItems.CheckBoxes = true;
            lvwRemovedItems.Location = new Point(12, 53);
            lvwRemovedItems.Name = "lvwRemovedItems";
            lvwRemovedItems.Scrollable = false;
            lvwRemovedItems.Size = new Size(980, 299);
            lvwRemovedItems.SmallImageList = iconImgList;
            lvwRemovedItems.TabIndex = 15;
            lvwRemovedItems.UseCompatibleStateImageBehavior = false;
            lvwRemovedItems.ItemCheck += lvwRemovedItems_ItemCheck;
            lvwRemovedItems.ItemChecked += lvwRemovedItems_ItemChecked;
            // 
            // chbSelectAll
            // 
            chbSelectAll.AutoSize = true;
            chbSelectAll.Location = new Point(870, 358);
            chbSelectAll.Name = "chbSelectAll";
            chbSelectAll.RightToLeft = RightToLeft.Yes;
            chbSelectAll.Size = new Size(107, 24);
            chbSelectAll.TabIndex = 16;
            chbSelectAll.Text = "SELECT ALL";
            chbSelectAll.UseVisualStyleBackColor = true;
            chbSelectAll.CheckedChanged += chbSelectAll_CheckedChanged;
            // 
            // lvwResultInfo
            // 
            lvwResultInfo.Location = new Point(496, 461);
            lvwResultInfo.Name = "lvwResultInfo";
            lvwResultInfo.Scrollable = false;
            lvwResultInfo.Size = new Size(310, 105);
            lvwResultInfo.TabIndex = 17;
            lvwResultInfo.UseCompatibleStateImageBehavior = false;
            lvwResultInfo.View = View.Details;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.InactiveCaption;
            btnClose.Location = new Point(842, 598);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 35);
            btnClose.TabIndex = 19;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnSetRootDir_MouseEnter;
            btnClose.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // FrmFileCleanerMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1004, 645);
            Controls.Add(btnClose);
            Controls.Add(lvwResultInfo);
            Controls.Add(chbSelectAll);
            Controls.Add(lvwRemovedItems);
            Controls.Add(lblRemovedListTitle);
            Controls.Add(lblProgress);
            Controls.Add(lblPathRootDir);
            Controls.Add(btnSetRootDir);
            Controls.Add(chbMoveToTrash);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(btnClear);
            Controls.Add(btnSetFilePatterns);
            Controls.Add(lstbFilePatterns);
            Controls.Add(btnFind);
            Controls.Add(lstbDirPatterns);
            Controls.Add(btnSetDirPatterns);
            Name = "FrmFileCleanerMain";
            ShowInTaskbar = false;
            Text = "FrmFileCleanerMain";
            Load += FrmFileCleanerMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSetDirPatterns;
        private ListBox lstbDirPatterns;
        private Button btnFind;
        private ListBox lstbFilePatterns;
        private Button btnSetFilePatterns;
        private Button btnClear;
        private Label label2;
        private ProgressBar progressBar1;
        private CheckBox chbMoveToTrash;
        private Button btnSetRootDir;
        private Label lblPathRootDir;
        private Label lblProgress;
        private Label lblRemovedListTitle;
        private FolderBrowserDialog fbSetRootDirDialog;
        private ImageList iconImgList;
        private ListView lvwRemovedItems;
        private CheckBox chbSelectAll;
        private ListView lvwResultInfo;
        private Button btnClose;
    }
}