using FileProcessor.Renamer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Archiver
{
    public class ArhiveReport
    {
        public List<ArhiveReportItem> Items { get; set; } = new List<ArhiveReportItem>();

        public void PushSuccess(DirectoryInfo processedDir, string arhiveFileName)
        {
            Items.Add(new ArhiveReportItem(processedDir, arhiveFileName));
        }

        public void PushError(DirectoryInfo processedDir, Exception? ex)
        {
            Items.Add(new ArhiveReportItem(processedDir, string.Empty, true, ex));
        }





    }
}
