
namespace FileProcessor.Archiver
{
    public class ArhiverReport
    {
        public List<ArhiverReportItem> Items { get; set; } = new List<ArhiverReportItem>();

        public void PushSuccess(DirectoryInfo processedDir, string arhiveFileName)
        {
            Items.Add(new ArhiverReportItem(processedDir, arhiveFileName));
        }

        public void PushError(DirectoryInfo processedDir, Exception? ex)
        {
            Items.Add(new ArhiverReportItem(processedDir, string.Empty, true, ex));
        }





    }
}
