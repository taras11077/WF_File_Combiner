﻿namespace FileCombiner
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
            label1 = new Label();
            SuspendLayout();
            // 
            // btnFileCleaner
            // 
            btnFileCleaner.BackColor = SystemColors.HotTrack;
            btnFileCleaner.FlatStyle = FlatStyle.Popup;
            btnFileCleaner.ForeColor = Color.MidnightBlue;
            btnFileCleaner.Location = new Point(642, 113);
            btnFileCleaner.Name = "btnFileCleaner";
            btnFileCleaner.Size = new Size(135, 30);
            btnFileCleaner.TabIndex = 1;
            btnFileCleaner.Text = "CLEANER";
            btnFileCleaner.UseVisualStyleBackColor = false;
            btnFileCleaner.Click += btnFileCleaner_Click_1;
            btnFileCleaner.MouseEnter += btnSetRootDir_MouseEnter;
            btnFileCleaner.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // btnArhive
            // 
            btnArhive.BackColor = SystemColors.HotTrack;
            btnArhive.FlatStyle = FlatStyle.Popup;
            btnArhive.ForeColor = Color.MidnightBlue;
            btnArhive.Location = new Point(639, 237);
            btnArhive.Name = "btnArhive";
            btnArhive.Size = new Size(135, 30);
            btnArhive.TabIndex = 2;
            btnArhive.Text = "ARHIVER";
            btnArhive.UseVisualStyleBackColor = false;
            btnArhive.Click += btnArhiver_Click;
            btnArhive.MouseEnter += btnSetRootDir_MouseEnter;
            btnArhive.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // btnRenamer
            // 
            btnRenamer.BackColor = SystemColors.HotTrack;
            btnRenamer.FlatStyle = FlatStyle.Popup;
            btnRenamer.ForeColor = Color.MidnightBlue;
            btnRenamer.Location = new Point(639, 175);
            btnRenamer.Name = "btnRenamer";
            btnRenamer.Size = new Size(135, 30);
            btnRenamer.TabIndex = 3;
            btnRenamer.Text = "RENAMER";
            btnRenamer.UseVisualStyleBackColor = false;
            btnRenamer.Click += btnRenamer_Click;
            btnRenamer.MouseEnter += btnSetRootDir_MouseEnter;
            btnRenamer.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.HotTrack;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.MidnightBlue;
            btnClose.Location = new Point(657, 425);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(95, 30);
            btnClose.TabIndex = 4;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnSetRootDir_MouseEnter;
            btnClose.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Console", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(521, 29);
            label1.Name = "label1";
            label1.Size = new Size(267, 34);
            label1.TabIndex = 5;
            label1.Text = "FileCombiner";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = Properties.Resources.image_7;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnRenamer);
            Controls.Add(btnArhive);
            Controls.Add(btnFileCleaner);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseDown += FrmMain_MouseDown;
            MouseMove += FrmMain_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFileCleaner;
        private Button btnArhive;
        private Button btnRenamer;
        private Button btnClose;
        private Label label1;
    }
}