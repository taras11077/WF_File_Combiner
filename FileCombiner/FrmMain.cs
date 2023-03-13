using FileCombiner.FileCleaner;

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
            FrmFileCleanerMain frm = new FrmFileCleanerMain();
            frm.ShowDialog();
        }
    }
}