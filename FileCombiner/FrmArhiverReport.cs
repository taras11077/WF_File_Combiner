using FileProcessor.Archiver;
using FileProcessor.Renamer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileProcessor;
using FileProcessor.Cleaner;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FileCombiner
{
    public partial class FrmArhiverReport : Form
    {
        ArhiverReport ArhiverReport { get; set; }

        int dirSize = 0;

        public FrmArhiverReport(ArhiverReport report)
        {
            InitializeComponent();
            ArhiverReport = report;
        }

        private void FrmArhiverReport_Load(object sender, EventArgs e)
        {
            InitListViewArhiverReport();
        }

        private void InitListViewArhiverReport()
        {
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
            lvwArhiverReport.Columns.Add("Exception", 500, HorizontalAlignment.Left);

            foreach (ArhiverReportItem item in ArhiverReport.Items)
            {
                dirSize = 0;
                GenerateItem(item);
            }
        }

        private void GenerateItem(ArhiverReportItem item)
        {
            ListViewItem lvItem = new ListViewItem();
            lvItem.Text = item.ProcessedDirectory.Name.ToString();
            lvItem.Tag = item;

            Calculator calculator = new Calculator();
            // вичисление размера исходной папки

            double dirSize = (double)calculator.CalcDirSize(item.ProcessedDirectory) / 1000;

            string arhiveName = string.Empty;
            double arhiveSize = 0;

            if (item.ArhiveFileName != "") // если архив создан
            {
                // виделение имени архива из полного имени
                int slashInd = item.ArhiveFileName.LastIndexOf('\\');  //поиск индекса последнего слеша
                arhiveName = item.ArhiveFileName.Substring(slashInd + 1, item.ArhiveFileName.Length - slashInd - 1);

                // вичисление размера архива
                FileInfo file = new FileInfo(item.ArhiveFileName);
                arhiveSize = (double)file.Length / 1000;
            }

            lvItem.ImageIndex = 1;
            lvItem.SubItems[0].Text = item.ProcessedDirectory.Name.ToString();
            lvItem.SubItems.Add($"{dirSize}");
            lvItem.SubItems.Add(arhiveName.ToString());
            lvItem.SubItems.Add($"{arhiveSize}");
            lvItem.SubItems.Add(item.ArhiveFileName);

            if (item.Failed)
                lvItem.SubItems.Add("not arhived");
            else
                lvItem.SubItems.Add("arhived");

            lvItem.SubItems.Add(item.Exception?.ToString());

            lvwArhiverReport.Items.Add(lvItem);
        }

        // изменение цвета кнопок при наведении курсора
        private void btnSetRootDir_MouseEnter(object sender, EventArgs e)
        {
            if (sender as Button == btnClose  || sender as Button == btnSave || sender as Button == btnLoad)
                (sender as Button)!.BackColor = Color.MediumSeaGreen;
        }

        private void btnSetRootDir_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button)!.BackColor = Color.LightGray;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }




        // сохранение в файл
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ArhiverReport.Items == null)
                return;

            using FileStream fs = new FileStream($"arhiverReport1.json", FileMode.Create);

            JsonSerializer.Serialize(fs, ArhiverReport.Items, new JsonSerializerOptions()
            {
                //ReferenceHandler = ReferenceHandler.Preserve,
                //ReferenceHandler = ReferenceHandler.IgnoreCycles,
                WriteIndented = true
            });

            fs.Close();
            MessageBox.Show("Saved");
        }

        //загрузка из файла
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using FileStream fs = new FileStream("arhiverReport1.json", FileMode.Open);

                List<ArhiverReportItem>? reportItems = new();

                
                reportItems = JsonSerializer.Deserialize<List<ArhiverReportItem>>(fs);

                if (reportItems != null)
                    ArhiverReport?.Items.AddRange(reportItems);

                fs.Close();
                InitListViewArhiverReport();
            }

            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

