using FileCombiner.FileCleaner;
using FileCombiner.FileRenamer;
using System.Security.Cryptography.X509Certificates;

namespace FileCombiner
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void btnFileCleaner_Click_1(object sender, EventArgs e)
        {
            FrmFileCombinerMain frm = new FrmFileCombinerMain(FileCombinerMode.Cleaner);
            frm.ShowDialog();

        }

        private void btnRenamer_Click(object sender, EventArgs e)
        {
            FrmFileCombinerMain frm = new FrmFileCombinerMain(FileCombinerMode.Renamer);
            frm.ShowDialog();

        }

        private void btnAnalyzer_Click(object sender, EventArgs e)
        {
            FrmFileCombinerMain frm = new FrmFileCombinerMain(FileCombinerMode.Arhiver);
            frm.ShowDialog();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}