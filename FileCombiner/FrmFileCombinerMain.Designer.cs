namespace FileCombiner.FileCleaner
{
    partial class FrmFileCombinerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFileCombinerMain));
            iconImgList = new ImageList(components);
            btnAddDirPatterns = new Button();
            lstbDirPatterns = new ListBox();
            btnFindRecursive = new Button();
            lstbFilePatterns = new ListBox();
            btnAddFilePatterns = new Button();
            btnClear = new Button();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            chbMoveToTrash = new CheckBox();
            btnSetRootDir = new Button();
            lblRemovedListTitle = new Label();
            fbSetRootDirDialog = new FolderBrowserDialog();
            lvwRemovedItems = new ListView();
            chbSelectAll = new CheckBox();
            lvwResultInfo = new ListView();
            btnClose = new Button();
            txtbDirPatterns = new TextBox();
            txtbFilePatterns = new TextBox();
            btnRemoveDirPatterns = new Button();
            btnRemoveFilePatterns = new Button();
            txtbPathRootDir = new TextBox();
            bindingSource1 = new BindingSource(components);
            btnRenamer = new Button();
            btnArhiver = new Button();
            btnFindSimple = new Button();
            btnRenamerReport = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
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
            // btnAddDirPatterns
            // 
            btnAddDirPatterns.BackColor = Color.LightSteelBlue;
            btnAddDirPatterns.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddDirPatterns.Location = new Point(12, 435);
            btnAddDirPatterns.Name = "btnAddDirPatterns";
            btnAddDirPatterns.Size = new Size(111, 30);
            btnAddDirPatterns.TabIndex = 1;
            btnAddDirPatterns.Text = "Add";
            btnAddDirPatterns.UseVisualStyleBackColor = false;
            btnAddDirPatterns.Click += btnAddDirPatterns_Click;
            btnAddDirPatterns.MouseEnter += btnSetRootDir_MouseEnter;
            btnAddDirPatterns.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // lstbDirPatterns
            // 
            lstbDirPatterns.FormattingEnabled = true;
            lstbDirPatterns.ItemHeight = 20;
            lstbDirPatterns.Location = new Point(12, 471);
            lstbDirPatterns.Name = "lstbDirPatterns";
            lstbDirPatterns.Size = new Size(220, 104);
            lstbDirPatterns.TabIndex = 2;
            // 
            // btnFindRecursive
            // 
            btnFindRecursive.BackColor = Color.LightSteelBlue;
            btnFindRecursive.Location = new Point(12, 581);
            btnFindRecursive.Name = "btnFindRecursive";
            btnFindRecursive.Size = new Size(220, 35);
            btnFindRecursive.TabIndex = 3;
            btnFindRecursive.Text = "RECURSIVE ALL SEARCH";
            btnFindRecursive.UseVisualStyleBackColor = false;
            btnFindRecursive.Click += btnFind_Click;
            btnFindRecursive.MouseEnter += btnSetRootDir_MouseEnter;
            btnFindRecursive.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // lstbFilePatterns
            // 
            lstbFilePatterns.FormattingEnabled = true;
            lstbFilePatterns.ItemHeight = 20;
            lstbFilePatterns.Location = new Point(258, 471);
            lstbFilePatterns.Name = "lstbFilePatterns";
            lstbFilePatterns.Size = new Size(220, 104);
            lstbFilePatterns.TabIndex = 4;
            // 
            // btnAddFilePatterns
            // 
            btnAddFilePatterns.BackColor = Color.LightSteelBlue;
            btnAddFilePatterns.Font = new Font("Segoe UI", 7.9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddFilePatterns.Location = new Point(258, 435);
            btnAddFilePatterns.Name = "btnAddFilePatterns";
            btnAddFilePatterns.Size = new Size(115, 30);
            btnAddFilePatterns.TabIndex = 5;
            btnAddFilePatterns.Text = "Add";
            btnAddFilePatterns.UseVisualStyleBackColor = false;
            btnAddFilePatterns.Click += btnAddFilePatterns_Click;
            btnAddFilePatterns.MouseEnter += btnSetRootDir_MouseEnter;
            btnAddFilePatterns.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightSteelBlue;
            btnClear.Cursor = Cursors.IBeam;
            btnClear.Location = new Point(842, 522);
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
            label2.Location = new Point(494, 288);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 8;
            label2.Text = "Result Info:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 631);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(801, 20);
            progressBar1.TabIndex = 9;
            // 
            // chbMoveToTrash
            // 
            chbMoveToTrash.AutoSize = true;
            chbMoveToTrash.Location = new Point(855, 492);
            chbMoveToTrash.Name = "chbMoveToTrash";
            chbMoveToTrash.RightToLeft = RightToLeft.Yes;
            chbMoveToTrash.Size = new Size(122, 24);
            chbMoveToTrash.TabIndex = 10;
            chbMoveToTrash.Text = "Move to trash";
            chbMoveToTrash.UseVisualStyleBackColor = true;
            // 
            // btnSetRootDir
            // 
            btnSetRootDir.BackColor = Color.LightSteelBlue;
            btnSetRootDir.Location = new Point(12, 363);
            btnSetRootDir.Name = "btnSetRootDir";
            btnSetRootDir.Size = new Size(150, 30);
            btnSetRootDir.TabIndex = 11;
            btnSetRootDir.Text = "Set Root Dir";
            btnSetRootDir.UseVisualStyleBackColor = false;
            btnSetRootDir.Click += btnSetRootDir_Click;
            btnSetRootDir.MouseEnter += btnSetRootDir_MouseEnter;
            btnSetRootDir.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // lblRemovedListTitle
            // 
            lblRemovedListTitle.AutoSize = true;
            lblRemovedListTitle.Location = new Point(19, 17);
            lblRemovedListTitle.Name = "lblRemovedListTitle";
            lblRemovedListTitle.Size = new Size(101, 20);
            lblRemovedListTitle.TabIndex = 14;
            lblRemovedListTitle.Text = "Finding Items:";
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
            lvwResultInfo.Location = new Point(503, 402);
            lvwResultInfo.Name = "lvwResultInfo";
            lvwResultInfo.Scrollable = false;
            lvwResultInfo.Size = new Size(310, 105);
            lvwResultInfo.TabIndex = 17;
            lvwResultInfo.UseCompatibleStateImageBehavior = false;
            lvwResultInfo.View = View.Details;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightSteelBlue;
            btnClose.Location = new Point(842, 616);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 35);
            btnClose.TabIndex = 19;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnSetRootDir_MouseEnter;
            btnClose.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // txtbDirPatterns
            // 
            txtbDirPatterns.Location = new Point(12, 402);
            txtbDirPatterns.Name = "txtbDirPatterns";
            txtbDirPatterns.PlaceholderText = "Set search Directory patterns:";
            txtbDirPatterns.Size = new Size(220, 27);
            txtbDirPatterns.TabIndex = 20;
            // 
            // txtbFilePatterns
            // 
            txtbFilePatterns.Location = new Point(258, 402);
            txtbFilePatterns.Name = "txtbFilePatterns";
            txtbFilePatterns.PlaceholderText = "Set searche File patterns:";
            txtbFilePatterns.Size = new Size(220, 27);
            txtbFilePatterns.TabIndex = 21;
            // 
            // btnRemoveDirPatterns
            // 
            btnRemoveDirPatterns.BackColor = Color.LightSteelBlue;
            btnRemoveDirPatterns.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveDirPatterns.Location = new Point(117, 435);
            btnRemoveDirPatterns.Name = "btnRemoveDirPatterns";
            btnRemoveDirPatterns.Size = new Size(115, 30);
            btnRemoveDirPatterns.TabIndex = 22;
            btnRemoveDirPatterns.Text = "Remove";
            btnRemoveDirPatterns.UseVisualStyleBackColor = false;
            btnRemoveDirPatterns.Click += btnRemoveDirPatterns_Click;
            btnRemoveDirPatterns.MouseEnter += btnSetRootDir_MouseEnter;
            btnRemoveDirPatterns.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // btnRemoveFilePatterns
            // 
            btnRemoveFilePatterns.BackColor = Color.LightSteelBlue;
            btnRemoveFilePatterns.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveFilePatterns.Location = new Point(363, 435);
            btnRemoveFilePatterns.Name = "btnRemoveFilePatterns";
            btnRemoveFilePatterns.Size = new Size(115, 30);
            btnRemoveFilePatterns.TabIndex = 23;
            btnRemoveFilePatterns.Text = "Remove";
            btnRemoveFilePatterns.UseVisualStyleBackColor = false;
            btnRemoveFilePatterns.Click += btnRemoveFilePatterns_Click;
            btnRemoveFilePatterns.MouseEnter += btnSetRootDir_MouseEnter;
            btnRemoveFilePatterns.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // txtbPathRootDir
            // 
            txtbPathRootDir.Location = new Point(183, 365);
            txtbPathRootDir.Name = "txtbPathRootDir";
            txtbPathRootDir.PlaceholderText = "Set Root Dir path";
            txtbPathRootDir.Size = new Size(630, 27);
            txtbPathRootDir.TabIndex = 26;
            txtbPathRootDir.Text = "C:\\Users\\Master\\Desktop";
            // 
            // btnRenamer
            // 
            btnRenamer.BackColor = Color.LightSteelBlue;
            btnRenamer.Location = new Point(503, 522);
            btnRenamer.Name = "btnRenamer";
            btnRenamer.Size = new Size(150, 35);
            btnRenamer.TabIndex = 28;
            btnRenamer.Text = "RENAMER";
            btnRenamer.UseVisualStyleBackColor = false;
            btnRenamer.Click += btnRename_Click;
            btnRenamer.MouseEnter += btnSetRootDir_MouseEnter;
            btnRenamer.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // btnArhiver
            // 
            btnArhiver.BackColor = Color.LightSteelBlue;
            btnArhiver.Location = new Point(663, 522);
            btnArhiver.Name = "btnArhiver";
            btnArhiver.Size = new Size(150, 35);
            btnArhiver.TabIndex = 29;
            btnArhiver.Text = "ARHIVER";
            btnArhiver.UseVisualStyleBackColor = false;
            btnArhiver.MouseEnter += btnSetRootDir_MouseEnter;
            btnArhiver.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // btnFindSimple
            // 
            btnFindSimple.BackColor = Color.LightSteelBlue;
            btnFindSimple.Location = new Point(258, 581);
            btnFindSimple.Name = "btnFindSimple";
            btnFindSimple.Size = new Size(220, 35);
            btnFindSimple.TabIndex = 30;
            btnFindSimple.Text = "SIMPLE FILES SEARCH";
            btnFindSimple.UseVisualStyleBackColor = false;
            btnFindSimple.Click += btnFindSimple_Click;
            btnFindSimple.MouseEnter += btnSetRootDir_MouseEnter;
            btnFindSimple.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // btnRenamerReport
            // 
            btnRenamerReport.BackColor = Color.LightSteelBlue;
            btnRenamerReport.Location = new Point(503, 563);
            btnRenamerReport.Name = "btnRenamerReport";
            btnRenamerReport.Size = new Size(150, 35);
            btnRenamerReport.TabIndex = 31;
            btnRenamerReport.Text = "VIEW REPORT";
            btnRenamerReport.UseVisualStyleBackColor = false;
            btnRenamerReport.Click += btnRenamerReport_Click;
            btnRenamerReport.MouseEnter += btnSetRootDir_MouseEnter;
            btnRenamerReport.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Location = new Point(663, 563);
            button2.Name = "button2";
            button2.Size = new Size(150, 35);
            button2.TabIndex = 32;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.MouseEnter += btnSetRootDir_MouseEnter;
            button2.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // FrmFileCombinerMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1004, 663);
            Controls.Add(button2);
            Controls.Add(btnRenamerReport);
            Controls.Add(btnFindSimple);
            Controls.Add(btnArhiver);
            Controls.Add(btnRenamer);
            Controls.Add(txtbPathRootDir);
            Controls.Add(btnRemoveFilePatterns);
            Controls.Add(btnRemoveDirPatterns);
            Controls.Add(txtbFilePatterns);
            Controls.Add(txtbDirPatterns);
            Controls.Add(btnClose);
            Controls.Add(lvwResultInfo);
            Controls.Add(chbSelectAll);
            Controls.Add(lvwRemovedItems);
            Controls.Add(lblRemovedListTitle);
            Controls.Add(btnSetRootDir);
            Controls.Add(chbMoveToTrash);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(btnClear);
            Controls.Add(btnAddFilePatterns);
            Controls.Add(lstbFilePatterns);
            Controls.Add(btnFindRecursive);
            Controls.Add(lstbDirPatterns);
            Controls.Add(btnAddDirPatterns);
            Name = "FrmFileCombinerMain";
            ShowInTaskbar = false;
            Text = "FrmFileCombainerMain";
            Load += FrmFileCleanerMain_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddDirPatterns;
        private ListBox lstbDirPatterns;
        private Button btnFindRecursive;
        private ListBox lstbFilePatterns;
        private Button btnAddFilePatterns;
        private Button btnClear;
        private Label label2;
        private ProgressBar progressBar1;
        private CheckBox chbMoveToTrash;
        private Button btnSetRootDir;
        private Label lblRemovedListTitle;
        private FolderBrowserDialog fbSetRootDirDialog;
        private ImageList iconImgList;
        private ListView lvwRemovedItems;
        private CheckBox chbSelectAll;
        private ListView lvwResultInfo;
        private Button btnClose;
        private TextBox txtbDirPatterns;
        private TextBox txtbFilePatterns;
        private Button btnRemoveDirPatterns;
        private Button btnRemoveFilePatterns;
        private TextBox txtbPathRootDir;
        private BindingSource bindingSource1;
        private Button btnRenamer;
        private Button btnArhiver;
        private Button btnFindSimple;
        private Button btnRenamerReport;
        private Button button2;
    }
}