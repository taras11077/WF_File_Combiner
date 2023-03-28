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
            btnClose = new Button();
            lvwArhiverReport = new ListView();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1276, 396);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 0;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // lvwArhiverReport
            // 
            lvwArhiverReport.Location = new Point(12, 12);
            lvwArhiverReport.Name = "lvwArhiverReport";
            lvwArhiverReport.Size = new Size(1358, 351);
            lvwArhiverReport.TabIndex = 1;
            lvwArhiverReport.UseCompatibleStateImageBehavior = false;
            // 
            // FrmArhiverReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1382, 453);
            Controls.Add(lvwArhiverReport);
            Controls.Add(btnClose);
            Name = "FrmArhiverReport";
            Text = "FrmArhiverReport";
            Load += FrmArhiverReport_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private ListView lvwArhiverReport;
    }
}