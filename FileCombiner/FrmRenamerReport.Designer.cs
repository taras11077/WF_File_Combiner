namespace FileCombiner
{
    partial class FrmRenamerReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRenamerReport));
            btnClose = new Button();
            lvwRenamedReport = new ListView();
            iconImgList = new ImageList(components);
            btnSave = new Button();
            btnLoad = new Button();
            saveFileDialogRenamer = new SaveFileDialog();
            openFileDialogRenamer = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightSteelBlue;
            btnClose.Location = new Point(681, 400);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 0;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnSetRootDir_MouseEnter;
            btnClose.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // lvwRenamedReport
            // 
            lvwRenamedReport.Location = new Point(0, 38);
            lvwRenamedReport.Name = "lvwRenamedReport";
            lvwRenamedReport.Size = new Size(800, 336);
            lvwRenamedReport.SmallImageList = iconImgList;
            lvwRenamedReport.TabIndex = 0;
            lvwRenamedReport.UseCompatibleStateImageBehavior = false;
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
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.Location = new Point(33, 400);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "SAVE REPORT";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            btnSave.Enter += btnSetRootDir_MouseEnter;
            btnSave.Leave += btnSetRootDir_MouseLeave;
            btnSave.MouseEnter += btnSetRootDir_MouseEnter;
            btnSave.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.LightSteelBlue;
            btnLoad.Location = new Point(219, 400);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(150, 29);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "LOAD REPORT";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            btnLoad.Enter += btnSetRootDir_MouseEnter;
            btnLoad.Leave += btnSetRootDir_MouseLeave;
            btnLoad.MouseEnter += btnSetRootDir_MouseEnter;
            btnLoad.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // openFileDialogRenamer
            // 
            openFileDialogRenamer.FileName = "openFileDialog1";
            // 
            // FrmRenamerReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(lvwRenamedReport);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmRenamerReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRenamerReport";
            Load += FrmRenamerReport_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private ListView lvwRenamedReport;
        private ImageList iconImgList;
        private Button btnSave;
        private Button btnLoad;
        private SaveFileDialog saveFileDialogRenamer;
        private OpenFileDialog openFileDialogRenamer;
    }
}