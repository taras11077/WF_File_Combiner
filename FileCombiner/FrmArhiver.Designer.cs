namespace FileCombiner
{
    partial class FrmArhiver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArhiver));
            lvwArhivedItems = new ListView();
            iconImgList = new ImageList(components);
            btnArhive = new Button();
            btnClose = new Button();
            cmbArhiveMode = new ComboBox();
            fbSetRootDirDialog = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // lvwArhivedItems
            // 
            lvwArhivedItems.Location = new Point(10, 29);
            lvwArhivedItems.Name = "lvwArhivedItems";
            lvwArhivedItems.Size = new Size(780, 310);
            lvwArhivedItems.SmallImageList = iconImgList;
            lvwArhivedItems.TabIndex = 0;
            lvwArhivedItems.UseCompatibleStateImageBehavior = false;
            lvwArhivedItems.View = View.Details;
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
            // btnArhive
            // 
            btnArhive.BackColor = Color.DarkSeaGreen;
            btnArhive.Location = new Point(249, 402);
            btnArhive.Name = "btnArhive";
            btnArhive.Size = new Size(150, 30);
            btnArhive.TabIndex = 1;
            btnArhive.Text = "ARHIVE";
            btnArhive.UseVisualStyleBackColor = false;
            btnArhive.Click += btnArhive_Click;
            btnArhive.MouseEnter += btnSetRootDir_MouseEnter;
            btnArhive.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.DarkSeaGreen;
            btnClose.Location = new Point(696, 403);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnSetRootDir_MouseEnter;
            btnClose.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // cmbArhiveMode
            // 
            cmbArhiveMode.FormattingEnabled = true;
            cmbArhiveMode.Location = new Point(12, 402);
            cmbArhiveMode.Name = "cmbArhiveMode";
            cmbArhiveMode.Size = new Size(200, 28);
            cmbArhiveMode.TabIndex = 3;
            cmbArhiveMode.Text = "Set Arhive Mode:";
            // 
            // FrmArhiver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(802, 453);
            Controls.Add(cmbArhiveMode);
            Controls.Add(btnClose);
            Controls.Add(btnArhive);
            Controls.Add(lvwArhivedItems);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmArhiver";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmArhiver";
            Load += FrmArhiver_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private ListView lvwArhivedItems;
        private Button btnArhive;
        private Button btnClose;
        private ComboBox cmbArhiveMode;
        private FolderBrowserDialog fbSetRootDirDialog;
        private ImageList iconImgList;
    }
}