using FileProcessor.Cleaner;
using System.Text.Json;


namespace FileCombiner
{
    public partial class FrmCleanerReport : Form
    {
        private CleanerReport CleanerReport { get; set; }

        private List<AdaptedReportItem> adaptedReportList = new List<AdaptedReportItem>();



        public FrmCleanerReport(CleanerReport cleanReport)
        {
            InitializeComponent();
            CleanerReport = cleanReport;
        }

        private void FrmCleanerReport_Load(object sender, EventArgs e)
        {
            InitAdaptedReportList();
            InitListViewCleanerReport();
        }

        private void InitListViewCleanerReport()
        {
            lvwCleanerReport.Columns.Clear();
            lvwCleanerReport.Items.Clear();

            lvwCleanerReport.View = View.Details;

            lvwCleanerReport.Scrollable = true;
            lvwCleanerReport.MultiSelect = false;
            lvwCleanerReport.GridLines = true;
            lvwCleanerReport.FullRowSelect = true;

            lvwCleanerReport.Columns.Add("Name", 200, HorizontalAlignment.Left);
            lvwCleanerReport.Columns.Add("Size, Kb", 80, HorizontalAlignment.Left);
            lvwCleanerReport.Columns.Add("Status", 85, HorizontalAlignment.Left);
            lvwCleanerReport.Columns.Add("Last AccesTime", 150, HorizontalAlignment.Left);
            lvwCleanerReport.Columns.Add("Exception", 750, HorizontalAlignment.Left);

            lvwCleanerReport.Groups.Add(new ListViewGroup("Directories", HorizontalAlignment.Left));
            lvwCleanerReport.Groups.Add(new ListViewGroup("Files", HorizontalAlignment.Left));

            foreach (AdaptedReportItem item in adaptedReportList)
            {
                GenerateListViewItem(item);
            }
        }

        private void InitAdaptedReportList()
        {
            foreach (CleanerReportItem item in CleanerReport.Items)
            {
                AdaptedReportItem adaptedItem = new AdaptedReportItem();

                adaptedItem.Name = item.ProcessedItem.Name.ToString();

                if (item.ProcessedItem is FileInfo f)
                {
                    adaptedItem.GroupIndex = 1;
                    adaptedItem.ImageIndex = 0;

                    adaptedItem.Size = (double)f.Length / 1000;
                }
                else if (item.ProcessedItem is DirectoryInfo)
                {
                    adaptedItem.GroupIndex = 0;
                    adaptedItem.ImageIndex = 1;

                    adaptedItem.Size = 0;
                }

                if (item.Failed)
                    adaptedItem.Status = "not deleted";
                else
                    adaptedItem.Status = "deleted";

                adaptedItem.LastAccessTime = item.ProcessedItem.LastAccessTime.ToString();

                if (item.Exception != null)
                    adaptedItem.Exception = item.Exception.ToString();

                adaptedReportList.Add(adaptedItem);
            }
        }

        private void GenerateListViewItem(AdaptedReportItem item)
        {
            ListViewItem lvItem = new ListViewItem();

            lvItem.Group = lvwCleanerReport.Groups[item.GroupIndex];
            lvItem.ImageIndex = item.ImageIndex;

            lvItem.Text = item.Name;
            lvItem.SubItems[0].Text = item.Name;
            lvItem.SubItems.Add($"{item.Size}");
            lvItem.SubItems.Add($"{item.Status}");
            lvItem.SubItems.Add($"{item.LastAccessTime}");
            lvItem.SubItems.Add($"{item.Exception}");

            lvwCleanerReport.Items.Add(lvItem);
        }

        //сохранение в файл
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialogCleaner = new SaveFileDialog();
            saveFileDialogCleaner.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, "CleanerReports");
            saveFileDialogCleaner.RestoreDirectory = true;

            try
            {
                if (saveFileDialogCleaner.ShowDialog() == DialogResult.Cancel)
                    return;

                string fileName = $"{saveFileDialogCleaner.FileName}_cleaner.json";

                saveFileDialogCleaner.InitialDirectory = Directory.GetParent(fileName)?.Name;

                if (lvwCleanerReport.Items == null)
                    return;

                using FileStream fs = new FileStream(fileName, FileMode.Create);

                JsonSerializer.Serialize(fs, adaptedReportList, new JsonSerializerOptions()
                {
                    WriteIndented = true
                });

                fs.Close();
                MessageBox.Show("Report saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //загрузка из файла
        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogCleaner = new OpenFileDialog();
            openFileDialogCleaner.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, "CleanerReports");
            openFileDialogCleaner.RestoreDirectory = true;

            if (openFileDialogCleaner.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialogCleaner.FileName;

            if (!filename.Contains("cleaner"))
            {
                MessageBox.Show("Error. Select the cleaner file");
                return;
            }

            try
            {
                using FileStream fs = new FileStream(filename, FileMode.Open);

                adaptedReportList = JsonSerializer.Deserialize<List<AdaptedReportItem>>(fs);

                fs.Close();
                InitListViewCleanerReport();
            }

            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // изменение цвета кнопок при наведении курсора
        private void btnSetRootDir_MouseEnter(object sender, EventArgs e)
        {
            if (sender as Button == btnClose || sender as Button == btnSave || sender as Button == btnLoad)
                (sender as Button)!.BackColor = Color.IndianRed;
        }
        private void btnSetRootDir_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button)!.BackColor = Color.RosyBrown;
        }
    }
}
