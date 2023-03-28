using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Cleaner
{
    public class CleaningReport
    {
        public List<CleaningReportItem> Items { get; set; } = new List<CleaningReportItem>();

        public void PushSuccess(FileSystemInfo processedItem)
        {
            Items.Add(new CleaningReportItem(processedItem));
        }

        public void PushError(FileSystemInfo processedItem, Exception? ex)
        {
            Items.Add(new CleaningReportItem(processedItem, true, ex));
        }

    }
}
