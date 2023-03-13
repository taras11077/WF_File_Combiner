namespace FileCombiner.FileCleaner
{
    partial class FrmFileCleanerMain
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
            lvRemovedItems = new ListView();
            btnSetDirPatterns = new Button();
            listBox1 = new ListBox();
            btnAnalyze = new Button();
            listBox2 = new ListBox();
            btnSetFilePatterns = new Button();
            btnClear = new Button();
            label1 = new Label();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            chbMoveToTrash = new CheckBox();
            btnSetRootDir = new Button();
            lblPathRootDir = new Label();
            lblProcessing = new Label();
            lblRemovedListTitle = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // lvRemovedItems
            // 
            lvRemovedItems.CheckBoxes = true;
            lvRemovedItems.LabelWrap = false;
            lvRemovedItems.Location = new Point(5, 40);
            lvRemovedItems.Name = "lvRemovedItems";
            lvRemovedItems.Size = new Size(987, 319);
            lvRemovedItems.TabIndex = 0;
            lvRemovedItems.UseCompatibleStateImageBehavior = false;
            lvRemovedItems.View = View.List;
            // 
            // btnSetDirPatterns
            // 
            btnSetDirPatterns.Location = new Point(5, 418);
            btnSetDirPatterns.Name = "btnSetDirPatterns";
            btnSetDirPatterns.Size = new Size(131, 25);
            btnSetDirPatterns.TabIndex = 1;
            btnSetDirPatterns.Text = "Set Dir patterns";
            btnSetDirPatterns.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(5, 449);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(197, 84);
            listBox1.TabIndex = 2;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(249, 553);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(197, 25);
            btnAnalyze.TabIndex = 3;
            btnAnalyze.Text = "ANALYZE";
            btnAnalyze.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(249, 449);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(197, 84);
            listBox2.TabIndex = 4;
            // 
            // btnSetFilePatterns
            // 
            btnSetFilePatterns.Location = new Point(249, 418);
            btnSetFilePatterns.Name = "btnSetFilePatterns";
            btnSetFilePatterns.Size = new Size(131, 25);
            btnSetFilePatterns.TabIndex = 5;
            btnSetFilePatterns.Text = "Set File patterns";
            btnSetFilePatterns.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.Location = new Point(791, 560);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(190, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Location = new Point(529, 418);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 7;
            label1.Text = "Count";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(529, 438);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 8;
            label2.Text = "Full size:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(540, 603);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(441, 20);
            progressBar1.TabIndex = 9;
            // 
            // chbMoveToTrash
            // 
            chbMoveToTrash.AutoSize = true;
            chbMoveToTrash.Location = new Point(859, 530);
            chbMoveToTrash.Name = "chbMoveToTrash";
            chbMoveToTrash.Size = new Size(122, 24);
            chbMoveToTrash.TabIndex = 10;
            chbMoveToTrash.Text = "Move to trash";
            chbMoveToTrash.UseVisualStyleBackColor = true;
            // 
            // btnSetRootDir
            // 
            btnSetRootDir.Location = new Point(5, 375);
            btnSetRootDir.Name = "btnSetRootDir";
            btnSetRootDir.Size = new Size(155, 27);
            btnSetRootDir.TabIndex = 11;
            btnSetRootDir.Text = "Set Root Dir";
            btnSetRootDir.UseVisualStyleBackColor = true;
            // 
            // lblPathRootDir
            // 
            lblPathRootDir.AutoSize = true;
            lblPathRootDir.Location = new Point(184, 378);
            lblPathRootDir.Name = "lblPathRootDir";
            lblPathRootDir.Size = new Size(174, 20);
            lblPathRootDir.TabIndex = 12;
            lblPathRootDir.Text = "C:\\Users\\Master\\Desktop";
            // 
            // lblProcessing
            // 
            lblProcessing.AutoSize = true;
            lblProcessing.Location = new Point(540, 580);
            lblProcessing.Name = "lblProcessing";
            lblProcessing.Size = new Size(107, 20);
            lblProcessing.TabIndex = 13;
            lblProcessing.Text = "Progress status";
            // 
            // lblRemovedListTitle
            // 
            lblRemovedListTitle.AutoSize = true;
            lblRemovedListTitle.Location = new Point(19, 17);
            lblRemovedListTitle.Name = "lblRemovedListTitle";
            lblRemovedListTitle.Size = new Size(115, 20);
            lblRemovedListTitle.TabIndex = 14;
            lblRemovedListTitle.Text = "Removed Items:";
            // 
            // FrmFileCleanerMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 645);
            Controls.Add(lblRemovedListTitle);
            Controls.Add(lblProcessing);
            Controls.Add(lblPathRootDir);
            Controls.Add(btnSetRootDir);
            Controls.Add(chbMoveToTrash);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnSetFilePatterns);
            Controls.Add(listBox2);
            Controls.Add(btnAnalyze);
            Controls.Add(listBox1);
            Controls.Add(btnSetDirPatterns);
            Controls.Add(lvRemovedItems);
            Name = "FrmFileCleanerMain";
            ShowInTaskbar = false;
            Text = "FrmFileCleanerMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvRemovedItems;
        private Button btnSetDirPatterns;
        private ListBox listBox1;
        private Button btnAnalyze;
        private ListBox listBox2;
        private Button btnSetFilePatterns;
        private Button btnClear;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;
        private CheckBox chbMoveToTrash;
        private Button btnSetRootDir;
        private Label lblPathRootDir;
        private Label lblProcessing;
        private Label lblRemovedListTitle;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}