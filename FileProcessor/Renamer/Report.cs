using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Renamer
{
    public class Report
    {
        public List<ReportItem> Items { get; set; } = new List<ReportItem>();

        public void PushSuccess(FileInfo processedFile)
        {
            Items.Add(new ReportItem(processedFile));
        }

        public void PushError(FileInfo processedFile, Exception? ex)
        {
            Items.Add(new ReportItem(processedFile, true, ex));
        }

    }
}
