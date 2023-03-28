namespace FileCombiner
{
    partial class FrmRenamer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRenamer));
            cmbRenameMode = new ComboBox();
            cmbRenameMask = new ComboBox();
            btnRename = new Button();
            lblSetMode = new Label();
            lblSetMask = new Label();
            txtbSetPrefix = new TextBox();
            lvwRenamedItems = new ListView();
            iconImgList = new ImageList(components);
            btnClose = new Button();
            SuspendLayout();
            // 
            // cmbRenameMode
            // 
            cmbRenameMode.FormattingEnabled = true;
            cmbRenameMode.Location = new Point(10, 404);
            cmbRenameMode.Name = "cmbRenameMode";
            cmbRenameMode.Size = new Size(200, 28);
            cmbRenameMode.TabIndex = 1;
            cmbRenameMode.SelectedIndexChanged += cmbRenameMode_SelectedIndexChanged;
            // 
            // cmbRenameMask
            // 
            cmbRenameMask.Enabled = false;
            cmbRenameMask.FormattingEnabled = true;
            cmbRenameMask.Location = new Point(245, 404);
            cmbRenameMask.Name = "cmbRenameMask";
            cmbRenameMask.Size = new Size(362, 28);
            cmbRenameMask.TabIndex = 2;
            cmbRenameMask.SelectedIndexChanged += cmbRenameMask_SelectedIndexChanged;
            // 
            // btnRename
            // 
            btnRename.BackColor = Color.LightSteelBlue;
            btnRename.Location = new Point(640, 363);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(150, 30);
            btnRename.TabIndex = 3;
            btnRename.Text = "RENAME";
            btnRename.UseVisualStyleBackColor = false;
            btnRename.Click += btnRename_Click;
            btnRename.MouseEnter += btnSetRootDir_MouseEnter;
            btnRename.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // lblSetMode
            // 
            lblSetMode.AutoSize = true;
            lblSetMode.Location = new Point(10, 373);
            lblSetMode.Name = "lblSetMode";
            lblSetMode.Size = new Size(134, 20);
            lblSetMode.TabIndex = 4;
            lblSetMode.Text = "Set Rename Mode:";
            // 
            // lblSetMask
            // 
            lblSetMask.AutoSize = true;
            lblSetMask.ForeColor = SystemColors.ActiveCaption;
            lblSetMask.Location = new Point(245, 373);
            lblSetMask.Name = "lblSetMask";
            lblSetMask.Size = new Size(135, 20);
            lblSetMask.TabIndex = 5;
            lblSetMask.Text = "Set Rename Masks:";
            // 
            // txtbSetPrefix
            // 
            txtbSetPrefix.Enabled = false;
            txtbSetPrefix.Location = new Point(482, 365);
            txtbSetPrefix.Name = "txtbSetPrefix";
            txtbSetPrefix.PlaceholderText = "Set prefix";
            txtbSetPrefix.Size = new Size(125, 27);
            txtbSetPrefix.TabIndex = 8;
            // 
            // lvwRenamedItems
            // 
            lvwRenamedItems.Location = new Point(12, 28);
            lvwRenamedItems.Name = "lvwRenamedItems";
            lvwRenamedItems.Size = new Size(780, 310);
            lvwRenamedItems.SmallImageList = iconImgList;
            lvwRenamedItems.TabIndex = 9;
            lvwRenamedItems.UseCompatibleStateImageBehavior = false;
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
            // btnClose
            // 
            btnClose.BackColor = Color.LightSteelBlue;
            btnClose.Location = new Point(692, 404);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 10;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnSetRootDir_MouseEnter;
            btnClose.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // FrmRenamer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(802, 453);
            Controls.Add(btnClose);
            Controls.Add(lvwRenamedItems);
            Controls.Add(txtbSetPrefix);
            Controls.Add(lblSetMask);
            Controls.Add(lblSetMode);
            Controls.Add(btnRename);
            Controls.Add(cmbRenameMask);
            Controls.Add(cmbRenameMode);
            Name = "FrmRenamer";
            Text = "FrmFileRenamer";
            Load += FrmFileRenamer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbRenameMode;
        private ComboBox cmbRenameMask;
        private Button btnRename;
        private Label lblSetMode;
        private Label lblSetMask;
        private TextBox txtbSetPrefix;
        private ListView lvwRenamedItems;
        private Button btnClose;
        private ImageList iconImgList;
    }
}