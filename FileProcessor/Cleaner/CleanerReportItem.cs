
namespace FileProcessor.Cleaner
{
    public class CleanerReportItem
    {
        public FileSystemInfo ProcessedItem { get; set; }

        public bool Failed { get; set; } = false;
        public Exception? Exception { get; set; } = null;

        public CleanerReportItem(FileSystemInfo processedItem, bool failed = false, Exception? exception = null)
        {
            ProcessedItem = processedItem;
            Failed = failed;
            Exception = exception;
        }
    }
}
