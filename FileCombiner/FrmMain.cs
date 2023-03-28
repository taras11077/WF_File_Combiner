using FileCombiner.Enums;
using FileCombiner.FileCleaner;
using FileProcessor.Renamer;
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
            FrmFileCombinerMain frmMain = new FrmFileCombinerMain(FileCombinerMode.Cleaner);
            frmMain.ShowDialog();
        }

        private void btnRenamer_Click(object sender, EventArgs e)
        {
            FrmFileCombinerMain frmMain = new FrmFileCombinerMain(FileCombinerMode.Renamer);
            frmMain.ShowDialog();
        }
        private void btnArhiver_Click(object sender, EventArgs e)
        {
            FrmFileCombinerMain frmMain = new FrmFileCombinerMain(FileCombinerMode.Arhiver);
            frmMain.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // изменение цвета кнопок при наведении курсора
        private void btnSetRootDir_MouseEnter(object sender, EventArgs e)
        {
            if (sender as Button == btnFileCleaner)
                (sender as Button)!.BackColor = Color.IndianRed;
            else if (sender as Button == btnRenamer)
                (sender as Button)!.BackColor = Color.SteelBlue;
            else if (sender as Button == btnArhive)
                (sender as Button)!.BackColor = Color.MediumSeaGreen;
            else if (sender as Button == btnClose)
                (sender as Button)!.BackColor = Color.LightSteelBlue;

        }

        private void btnSetRootDir_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button)!.BackColor = Color.LightSteelBlue;
        }




    }
}