using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Cleaner
{
    public class CleanerReport
    {
        public List<CleanerReportItem> Items { get; set; } = new List<CleanerReportItem>();

        public CleanerReport() { }

        public void PushSuccess(FileSystemInfo processedItem)
        {
            Items.Add(new CleanerReportItem(processedItem));
        }

        public void PushError(FileSystemInfo processedItem, Exception? ex)
        {
            Items.Add(new CleanerReportItem(processedItem, true, ex));
        }

    }
}
