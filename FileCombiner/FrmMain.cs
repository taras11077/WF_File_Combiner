using FileCombiner.Enums;
using FileCombiner.FileCleaner;

namespace FileCombiner
{
    public partial class FrmMain : Form
    {
        private double X { get; set; } = 0.0;
        private double Y { get; set; } = 0.0;
        private Point startClick;

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
                (sender as Button)!.BackColor = Color.DeepPink;
            else if (sender as Button == btnRenamer)
                (sender as Button)!.BackColor = Color.DeepSkyBlue;
            else if (sender as Button == btnArhive)
                (sender as Button)!.BackColor = Color.SpringGreen;
            else if (sender as Button == btnClose)
                (sender as Button)!.BackColor = Color.DarkOrange;
        }
        private void btnSetRootDir_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button)!.BackColor = Color.RoyalBlue;
        }

        //перетаскивание окна
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                startClick = new(e.X, e.Y);
        }
        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point delta = new(e.X - startClick.X, e.Y - startClick.Y);
                Location = new(Location.X + delta.X, Location.Y + delta.Y);
            }
        }


    }
}