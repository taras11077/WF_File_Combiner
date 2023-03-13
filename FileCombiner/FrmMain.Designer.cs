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
            SuspendLayout();
            // 
            // btnFileCleaner
            // 
            btnFileCleaner.Location = new Point(297, 65);
            btnFileCleaner.Name = "btnFileCleaner";
            btnFileCleaner.Size = new Size(136, 29);
            btnFileCleaner.TabIndex = 1;
            btnFileCleaner.Text = "FILE CLEANER";
            btnFileCleaner.UseVisualStyleBackColor = true;
            btnFileCleaner.Click += btnFileCleaner_Click_1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 450);
            Controls.Add(btnFileCleaner);
            Name = "FrmMain";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnFileCleaner;
    }
}