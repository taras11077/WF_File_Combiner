namespace FileCombiner
{
    partial class FrmCleaningReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCleaningReport));
            btnClose = new Button();
            lvwCleaningReport = new ListView();
            iconImgList = new ImageList(components);
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(694, 409);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 0;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lvwCleaningReport
            // 
            lvwCleaningReport.Location = new Point(2, 36);
            lvwCleaningReport.Name = "lvwCleaningReport";
            lvwCleaningReport.Size = new Size(794, 343);
            lvwCleaningReport.SmallImageList = iconImgList;
            lvwCleaningReport.TabIndex = 1;
            lvwCleaningReport.UseCompatibleStateImageBehavior = false;
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
            // FrmCleaningReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(lvwCleaningReport);
            Controls.Add(btnClose);
            Name = "FrmCleaningReport";
            Text = "FrmCleaningReport";
            Load += FrmCleaningReport_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private ListView lvwCleaningReport;
        private ImageList iconImgList;
    }
}