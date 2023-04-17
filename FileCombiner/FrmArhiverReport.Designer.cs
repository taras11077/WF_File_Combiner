namespace FileCombiner
{
    partial class FrmArhiverReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArhiverReport));
            btnClose = new Button();
            lvwArhiverReport = new ListView();
            iconImgList = new ImageList(components);
            btnSave = new Button();
            btnLoad = new Button();
            openFileDialogArhiver = new OpenFileDialog();
            saveFileDialogArhiver = new SaveFileDialog();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.DarkSeaGreen;
            btnClose.Location = new Point(1253, 396);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 0;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            btnClose.MouseEnter += btnSetRootDir_MouseEnter;
            btnClose.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // lvwArhiverReport
            // 
            lvwArhiverReport.Location = new Point(12, 12);
            lvwArhiverReport.Name = "lvwArhiverReport";
            lvwArhiverReport.Size = new Size(1358, 351);
            lvwArhiverReport.SmallImageList = iconImgList;
            lvwArhiverReport.TabIndex = 1;
            lvwArhiverReport.UseCompatibleStateImageBehavior = false;
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
            btnSave.BackColor = Color.DarkSeaGreen;
            btnSave.Location = new Point(43, 396);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "SAVE REPORT";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            btnSave.MouseEnter += btnSetRootDir_MouseEnter;
            btnSave.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.DarkSeaGreen;
            btnLoad.Location = new Point(240, 396);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(150, 29);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "LOAD REPORT";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            btnLoad.MouseEnter += btnSetRootDir_MouseEnter;
            btnLoad.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // openFileDialogArhiver
            // 
            openFileDialogArhiver.FileName = "openFileDialog1";
            // 
            // FrmArhiverReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1382, 453);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(lvwArhiverReport);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmArhiverReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmArhiverReport";
            Load += FrmArhiverReport_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private ListView lvwArhiverReport;
        private ImageList iconImgList;
        private Button btnSave;
        private Button btnLoad;
        private OpenFileDialog openFileDialogArhiver;
        private SaveFileDialog saveFileDialogArhiver;
    }
}