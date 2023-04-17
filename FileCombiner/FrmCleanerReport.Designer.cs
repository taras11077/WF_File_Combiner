namespace FileCombiner
{
    partial class FrmCleanerReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCleanerReport));
            btnClose = new Button();
            lvwCleanerReport = new ListView();
            iconImgList = new ImageList(components);
            btnSave = new Button();
            btnLoad = new Button();
            openFileDialogCleaner = new OpenFileDialog();
            saveFileDialogCleaner = new SaveFileDialog();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.RosyBrown;
            btnClose.Location = new Point(683, 400);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 0;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnSetRootDir_MouseEnter;
            btnClose.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // lvwCleanerReport
            // 
            lvwCleanerReport.Location = new Point(2, 36);
            lvwCleanerReport.Name = "lvwCleanerReport";
            lvwCleanerReport.Size = new Size(794, 343);
            lvwCleanerReport.SmallImageList = iconImgList;
            lvwCleanerReport.TabIndex = 1;
            lvwCleanerReport.UseCompatibleStateImageBehavior = false;
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
            btnSave.BackColor = Color.RosyBrown;
            btnSave.Location = new Point(28, 400);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "SAVE REPORT";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            btnSave.MouseEnter += btnSetRootDir_MouseEnter;
            btnSave.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.RosyBrown;
            btnLoad.Location = new Point(222, 400);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(150, 29);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "LOAD REPORT";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click_1;
            btnLoad.MouseEnter += btnSetRootDir_MouseEnter;
            btnLoad.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // openFileDialogCleaner
            // 
            openFileDialogCleaner.FileName = "openFileDialog1";
            // 
            // FrmCleanerReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(lvwCleanerReport);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmCleanerReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCleanerReport";
            Load += FrmCleanerReport_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private ListView lvwCleanerReport;
        private ImageList iconImgList;
        private Button btnSave;
        private Button btnLoad;
        private OpenFileDialog openFileDialogCleaner;
        private SaveFileDialog saveFileDialogCleaner;
    }
}