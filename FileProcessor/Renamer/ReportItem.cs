using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Renamer
{
    public class ReportItem
    {
        public FileInfo ProcessedFile { get; set; }
        public bool Failed { get; set; } = false;
        public Exception? Exception { get; set; } = null;

        public ReportItem(FileInfo processedFile, bool failed = false, Exception? exception = null)
        {
            ProcessedFile = processedFile;
            Failed = failed;
            Exception = exception;
        }
    }
}
