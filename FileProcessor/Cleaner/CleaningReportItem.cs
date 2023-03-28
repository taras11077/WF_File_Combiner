using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Cleaner
{
    public class CleaningReportItem
    {
        //public DirectoryInfo ProcessedDirectory { get; set; }
        //public FileInfo ProcessedFile { get; set; }
        public FileSystemInfo ProcessedItem { get; set; }

        public bool Failed { get; set; } = false;
        public Exception? Exception { get; set; } = null;

        public CleaningReportItem(FileSystemInfo processedItem, bool failed = false, Exception? exception = null)
        {
            ProcessedItem = processedItem;
            Failed = failed;
            Exception = exception;
        }
    }
}
