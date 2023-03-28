using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Renamer
{
    public class RenamerReport
    {
        public List<RenamerReportItem> Items { get; set; } = new List<RenamerReportItem>();

        public void PushSuccess(FileInfo processedFile)
        {
            Items.Add(new RenamerReportItem(processedFile));
        }

        public void PushError(FileInfo processedFile, Exception? ex)
        {
            Items.Add(new RenamerReportItem(processedFile, true, ex));
        }

    }
}
