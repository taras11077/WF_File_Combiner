namespace FileCombiner
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFileCleaner = new Button();
            btnArhive = new Button();
            btnRenamer = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnFileCleaner
            // 
            btnFileCleaner.BackColor = Color.RosyBrown;
            btnFileCleaner.Location = new Point(24, 37);
            btnFileCleaner.Name = "btnFileCleaner";
            btnFileCleaner.Size = new Size(136, 29);
            btnFileCleaner.TabIndex = 1;
            btnFileCleaner.Text = "CLEANER";
            btnFileCleaner.UseVisualStyleBackColor = false;
            btnFileCleaner.Click += btnFileCleaner_Click_1;
            // 
            // btnArhive
            // 
            btnArhive.BackColor = Color.DarkSeaGreen;
            btnArhive.Location = new Point(27, 153);
            btnArhive.Name = "btnArhive";
            btnArhive.Size = new Size(136, 29);
            btnArhive.TabIndex = 2;
            btnArhive.Text = "ARHIVER";
            btnArhive.UseVisualStyleBackColor = false;
            btnArhive.Click += btnArhiver_Click;
            // 
            // btnRenamer
            // 
            btnRenamer.BackColor = SystemColors.ActiveCaption;
            btnRenamer.Location = new Point(24, 92);
            btnRenamer.Name = "btnRenamer";
            btnRenamer.Size = new Size(139, 29);
            btnRenamer.TabIndex = 3;
            btnRenamer.Text = "RENAMER";
            btnRenamer.UseVisualStyleBackColor = false;
            btnRenamer.Click += btnRenamer_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightGray;
            btnClose.Location = new Point(343, 391);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(473, 450);
            Controls.Add(btnClose);
            Controls.Add(btnRenamer);
            Controls.Add(btnArhive);
            Controls.Add(btnFileCleaner);
            Name = "FrmMain";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnFileCleaner;
        private Button btnArhive;
        private Button btnRenamer;
        private Button btnClose;
    }
}