using FileProcessor.Archiver;
using FileProcessor.Archiver.Exceptions;

namespace FileCombiner
{
    public partial class FrmArhiver : Form
    {
        private List<DirectoryInfo> Dirs { get; set; }
        //private List<string> arhiveFiles { get; set; } = new List<string>();

        private string arhiveMode = string.Empty;
        private ArchiveEngineMode mode;

        public FrmArhiver(List<DirectoryInfo> arhivedDirs)
        {
            InitializeComponent();
            Dirs = arhivedDirs;
        }

        private void FrmArhiver_Load_1(object sender, EventArgs e)
        {
            string[] modes = { "zip", };
            cmbArhiveMode.Items.AddRange(modes);

            InitListViewArhivedItems();
        }
        private void InitListViewArhivedItems()
        {
            lvwArhivedItems.View = View.Details;

            lvwArhivedItems.Scrollable = true;
            lvwArhivedItems.MultiSelect = false;
            lvwArhivedItems.GridLines = true;
            lvwArhivedItems.FullRowSelect = true;

            lvwArhivedItems.Columns.Add("Name", 300, HorizontalAlignment.Left);
            lvwArhivedItems.Columns.Add("Size, Kb", 100, HorizontalAlignment.Left);
            lvwArhivedItems.Columns.Add("Modification date", 150, HorizontalAlignment.Left);
            lvwArhivedItems.Columns.Add("Path", 500, HorizontalAlignment.Left);
            lvwArhivedItems.Columns.Add("Status", 100, HorizontalAlignment.Left);

            GenerateArhivedItems();
        }

        private void GenerateArhivedItems()
        {
            lvwArhivedItems.Items.Clear();

            Dirs.ForEach(dir =>
            {
                dirSize = 0;
                GenerateItem(dir);
            });
        }

        private void GenerateItem(DirectoryInfo dir)
        {

            if (dir == null)
                return;

            ListViewItem item = new ListViewItem()
            {
                Text = dir.Name,
                ImageIndex = 1,
            };

            int itemSize = CalcDirSize(dir);

            item.Tag = itemSize;

            item.SubItems[0].Text = dir.Name;
            item.SubItems.Add(((double)itemSize / 1000).ToString());
            item.SubItems.Add(dir.LastAccessTime.ToString());
            item.SubItems.Add(dir.FullName);

            lvwArhivedItems.Items.Add(item);
        }

        int dirSize = 0;
        private int CalcDirSize(DirectoryInfo d) //расчет размера директории
        {
            DirectoryInfo[] dirs = d.GetDirectories();
            FileInfo[] files = d.GetFiles();

            foreach (FileInfo file in files)
            {
                dirSize += (int)file.Length;
            }

            foreach (DirectoryInfo dir in dirs)
            {
                CalcDirSize(dir);
            }

            return dirSize;
        }


        private void btnArhive_Click(object sender, EventArgs e)
        {
            ArchiveEngine archiveEngine = new ArchiveEngine(mode);

            ArhiverReport arhiverReport = new ArhiverReport();

            foreach (DirectoryInfo dir in Dirs)
            {
                try
                {
                    string outFile = archiveEngine.CompressDirectory(dir.FullName);
                    //arhiveFiles.Add(outFile);

                    arhiverReport.PushSuccess(dir, outFile);
                }
                catch (ArchiverException ex)
                {
                    MessageBox.Show(ex.Message);
                    arhiverReport.PushError(dir, ex);
                }
            }

            Data.arhiverReport = arhiverReport;
            MessageBox.Show("\tArhiving completed\nYou can see the results by clicking VIEW REPORT");

            Close();
        }

        private void cmbArhiveMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArhiveMode.SelectedItem?.ToString() != null)
                arhiveMode = cmbArhiveMode.SelectedItem?.ToString()!;

            if (arhiveMode == "zip")
            {
                mode = ArchiveEngineMode.Zip;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        // изменение цвета кнопок при наведении курсора
        private void btnSetRootDir_MouseEnter(object sender, EventArgs e)
        {
            if (sender as Button == btnArhive || sender as Button == btnClose)
                (sender as Button)!.BackColor = Color.MediumSeaGreen;
        }

        private void btnSetRootDir_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button)!.BackColor = Color.LightSteelBlue;
        }
    }
}
