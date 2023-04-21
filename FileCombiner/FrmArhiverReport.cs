using FileProcessor.Archiver;
using FileProcessor;
using System.Text.Json;
using System.Windows.Forms;

namespace FileCombiner
{
    public partial class FrmArhiverReport : Form
    {
        private ArhiverReport ArhiverReport { get; set; }
        private List<AdaptedReportItem> adaptedReportList = new List<AdaptedReportItem>();

        public FrmArhiverReport(ArhiverReport report)
        {
            InitializeComponent();
            ArhiverReport = report;
        }

        private void FrmArhiverReport_Load(object sender, EventArgs e)
        {
            InitAdaptedReportList();
            InitListViewArhiverReport();
        }

        private void InitListViewArhiverReport()
        {
            lvwArhiverReport.Columns.Clear();
            lvwArhiverReport.Items.Clear();

            lvwArhiverReport.View = View.Details;

            lvwArhiverReport.Scrollable = true;
            lvwArhiverReport.MultiSelect = false;
            lvwArhiverReport.GridLines = true;
            lvwArhiverReport.FullRowSelect = true;

            lvwArhiverReport.Columns.Add("Processed Directory", 150, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("Directory Size, Kb", 150, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("ArhiveFileName", 150, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("ArhiveSize, Kb", 120, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("Path", 370, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("Status", 120, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("Last AccesTime", 150, HorizontalAlignment.Left);
            lvwArhiverReport.Columns.Add("Exception", 500, HorizontalAlignment.Left);

            lvwArhiverReport.Groups.Add(new ListViewGroup("Directories", HorizontalAlignment.Left));
            lvwArhiverReport.Groups.Add(new ListViewGroup("Files", HorizontalAlignment.Left));

            foreach (AdaptedReportItem item in adaptedReportList)
            {
                GenerateListViewItem(item);
            }
        }

        private void InitAdaptedReportList()
        {
            foreach (ArhiverReportItem item in ArhiverReport.Items)
            {
                AdaptedReportItem adaptedItem = new AdaptedReportItem();

                adaptedItem.Name = item.ProcessedDirectory.Name.ToString();
                adaptedItem.GroupIndex = 0;
                adaptedItem.ImageIndex = 1;

                Calculator calculator = new Calculator();
                // вычисление размера исходной папки
                adaptedItem.Size = (double)calculator.CalcDirSize(item.ProcessedDirectory) / 1000;

                if (item.ArhiveFileName != "") // если архив создан
                {
                    // выделение имени архива из полного имени
                    int slashInd = item.ArhiveFileName.LastIndexOf('\\');  //поиск индекса последнего слеша
                    adaptedItem.ArhiveName = item.ArhiveFileName.Substring(slashInd + 1, item.ArhiveFileName.Length - slashInd - 1);

                    // вычисление размера архива
                    FileInfo file = new FileInfo(item.ArhiveFileName);
                    adaptedItem.ArhiveSize = (double)file.Length / 1000;
                }

                adaptedItem.Path = item.ArhiveFileName.ToString();

                if (item.Failed)
                    adaptedItem.Status = "not arhived";
                else
                    adaptedItem.Status = "arhived";

                adaptedItem.LastAccessTime = item.ProcessedDirectory.LastAccessTime.ToString();

                if (item.Exception != null)
                    adaptedItem.Exception = item.Exception.ToString();

                adaptedReportList.Add(adaptedItem);
            }
        }

        private void GenerateListViewItem(AdaptedReportItem item)
        {
            ListViewItem lvItem = new ListViewItem();

            lvItem.Group = lvwArhiverReport.Groups[item.GroupIndex];
            lvItem.ImageIndex = item.ImageIndex;

            lvItem.Text = item.Name;
            lvItem.SubItems[0].Text = item.Name;
            lvItem.SubItems.Add($"{item.Size}");
            lvItem.SubItems.Add($"{item.ArhiveName}");
            lvItem.SubItems.Add($"{item.ArhiveSize}");
            lvItem.SubItems.Add($"{item.Path}");
            lvItem.SubItems.Add($"{item.Status}");
            lvItem.SubItems.Add($"{item.LastAccessTime}");
            lvItem.SubItems.Add($"{item.Exception}");

            lvwArhiverReport.Items.Add(lvItem);
        }

        // сохранение в файл
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialogArhiver = new SaveFileDialog();
            saveFileDialogArhiver.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, "ArhiverReports");// привязка папки по умолчанию относительно папки приложения
            saveFileDialogArhiver.RestoreDirectory = true;

            if (saveFileDialogArhiver.ShowDialog() == DialogResult.Cancel)
                return;
            
            string fileName = $"{saveFileDialogArhiver.FileName}_arhiver.json";

            if (ArhiverReport.Items == null)
                return;

            using FileStream fs = new FileStream(fileName, FileMode.Create);

            JsonSerializer.Serialize(fs, adaptedReportList, new JsonSerializerOptions()
            {
                WriteIndented = true
            });

            fs.Close();
            MessageBox.Show("Report saved");
        }

        //загрузка из файла
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogArhiver = new OpenFileDialog();
            openFileDialogArhiver.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, "ArhiverReports");
            openFileDialogArhiver.RestoreDirectory = true;

            if (openFileDialogArhiver.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialogArhiver.FileName;
            if (!filename.Contains("arhiver"))
            {
                MessageBox.Show("Error. Select the archiver file");
                return;
            }

            try
            {
                using FileStream fs = new FileStream(filename, FileMode.Open);

                adaptedReportList = JsonSerializer.Deserialize<List<AdaptedReportItem>>(fs);

                fs.Close();
                InitListViewArhiverReport();
            }

            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // изменение цвета кнопок при наведении курсора
        private void btnSetRootDir_MouseEnter(object sender, EventArgs e)
        {
            if (sender as Button == btnClose || sender as Button == btnSave || sender as Button == btnLoad)
                (sender as Button)!.BackColor = Color.MediumSeaGreen;
        }
        private void btnSetRootDir_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button)!.BackColor = Color.DarkSeaGreen;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

