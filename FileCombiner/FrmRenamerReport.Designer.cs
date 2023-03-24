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
            btnClose = new Button();
            lvwRenamedReport = new ListView();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightSteelBlue;
            btnClose.Location = new Point(694, 409);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 0;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lvwRenamedReport
            // 
            lvwRenamedReport.Location = new Point(0, 38);
            lvwRenamedReport.Name = "lvwRenamedReport";
            lvwRenamedReport.Size = new Size(800, 336);
            lvwRenamedReport.TabIndex = 0;
            lvwRenamedReport.UseCompatibleStateImageBehavior = false;
            // 
            // FrmRenamerReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 450);
            Controls.Add(lvwRenamedReport);
            Controls.Add(btnClose);
            Name = "FrmRenamerReport";
            Text = "FrmRenamerReport";
            Load += FrmRenamerReport_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private ListView lvwRenamedReport;
    }
}