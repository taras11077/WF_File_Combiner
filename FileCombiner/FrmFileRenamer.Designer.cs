namespace FileCombiner
{
    partial class FrmFileRenamer
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
            cmbRenameMode = new ComboBox();
            cmbRenameMask = new ComboBox();
            btnRename = new Button();
            lblSetMode = new Label();
            lblSetMask = new Label();
            txtbSetPrefix = new TextBox();
            lvwRenamedItems = new ListView();
            btnClose = new Button();
            SuspendLayout();
            // 
            // cmbRenameMode
            // 
            cmbRenameMode.FormattingEnabled = true;
            cmbRenameMode.Location = new Point(12, 323);
            cmbRenameMode.Name = "cmbRenameMode";
            cmbRenameMode.Size = new Size(200, 28);
            cmbRenameMode.TabIndex = 1;
            cmbRenameMode.SelectedIndexChanged += cmbRenameMode_SelectedIndexChanged;
            // 
            // cmbRenameMask
            // 
            cmbRenameMask.Enabled = false;
            cmbRenameMask.FormattingEnabled = true;
            cmbRenameMask.Location = new Point(247, 323);
            cmbRenameMask.Name = "cmbRenameMask";
            cmbRenameMask.Size = new Size(362, 28);
            cmbRenameMask.TabIndex = 2;
            cmbRenameMask.SelectedIndexChanged += cmbRenameMask_SelectedIndexChanged;
            // 
            // btnRename
            // 
            btnRename.BackColor = Color.LightSteelBlue;
            btnRename.Location = new Point(642, 282);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(150, 30);
            btnRename.TabIndex = 3;
            btnRename.Text = "RENAME";
            btnRename.UseVisualStyleBackColor = false;
            btnRename.Click += btnRename_Click;
            btnRename.MouseEnter += btnSetRootDir_MouseEnter;
            btnRename.MouseLeave += btnSetRootDir_MouseLeave;
            // 
            // lblSetMode
            // 
            lblSetMode.AutoSize = true;
            lblSetMode.Location = new Point(12, 292);
            lblSetMode.Name = "lblSetMode";
            lblSetMode.Size = new Size(134, 20);
            lblSetMode.TabIndex = 4;
            lblSetMode.Text = "Set Rename Mode:";
            // 
            // lblSetMask
            // 
            lblSetMask.AutoSize = true;
            lblSetMask.ForeColor = Color.LemonChiffon;
            lblSetMask.Location = new Point(247, 292);
            lblSetMask.Name = "lblSetMask";
            lblSetMask.Size = new Size(135, 20);
            lblSetMask.TabIndex = 5;
            lblSetMask.Text = "Set Rename Masks:";
            // 
            // txtbSetPrefix
            // 
            txtbSetPrefix.Enabled = false;
            txtbSetPrefix.Location = new Point(484, 284);
            txtbSetPrefix.Name = "txtbSetPrefix";
            txtbSetPrefix.PlaceholderText = "Set prefix";
            txtbSetPrefix.Size = new Size(125, 27);
            txtbSetPrefix.TabIndex = 8;
            // 
            // lvwRenamedItems
            // 
            lvwRenamedItems.Location = new Point(12, 2);
            lvwRenamedItems.Name = "lvwRenamedItems";
            lvwRenamedItems.Size = new Size(780, 262);
            lvwRenamedItems.TabIndex = 9;
            lvwRenamedItems.UseCompatibleStateImageBehavior = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightSteelBlue;
            btnClose.Location = new Point(694, 323);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 10;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // FrmFileRenamer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 370);
            Controls.Add(btnClose);
            Controls.Add(lvwRenamedItems);
            Controls.Add(txtbSetPrefix);
            Controls.Add(lblSetMask);
            Controls.Add(lblSetMode);
            Controls.Add(btnRename);
            Controls.Add(cmbRenameMask);
            Controls.Add(cmbRenameMode);
            Name = "FrmFileRenamer";
            Text = "FrmFileRenamer";
            Load += FrmFileRenamer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbRenameMode;
        private ComboBox cmbRenameMask;
        private Button btnRename;
        private Label lblSetMode;
        private Label lblSetMask;
        private TextBox txtbSetPrefix;
        private ListView lvwRenamedItems;
        private Button btnClose;
    }
}