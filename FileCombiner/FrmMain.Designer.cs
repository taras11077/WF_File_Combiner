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
            btnAnalyzer = new Button();
            btnRenamer = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnFileCleaner
            // 
            btnFileCleaner.Location = new Point(24, 37);
            btnFileCleaner.Name = "btnFileCleaner";
            btnFileCleaner.Size = new Size(136, 29);
            btnFileCleaner.TabIndex = 1;
            btnFileCleaner.Text = "FILE CLEANER";
            btnFileCleaner.UseVisualStyleBackColor = true;
            btnFileCleaner.Click += btnFileCleaner_Click_1;
            // 
            // btnAnalyzer
            // 
            btnAnalyzer.Location = new Point(24, 93);
            btnAnalyzer.Name = "btnAnalyzer";
            btnAnalyzer.Size = new Size(136, 29);
            btnAnalyzer.TabIndex = 2;
            btnAnalyzer.Text = "ANALYZER";
            btnAnalyzer.UseVisualStyleBackColor = true;
            btnAnalyzer.Click += btnAnalyzer_Click;
            // 
            // btnRenamer
            // 
            btnRenamer.Location = new Point(24, 157);
            btnRenamer.Name = "btnRenamer";
            btnRenamer.Size = new Size(139, 29);
            btnRenamer.TabIndex = 3;
            btnRenamer.Text = "RENAMER";
            btnRenamer.UseVisualStyleBackColor = true;
            btnRenamer.Click += btnRenamer_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.SteelBlue;
            btnClose.Location = new Point(357, 399);
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
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(473, 450);
            Controls.Add(btnClose);
            Controls.Add(btnRenamer);
            Controls.Add(btnAnalyzer);
            Controls.Add(btnFileCleaner);
            Name = "FrmMain";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnFileCleaner;
        private Button btnAnalyzer;
        private Button btnRenamer;
        private Button btnClose;
    }
}