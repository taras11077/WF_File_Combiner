using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Renamer
{
    public class RenamerReportItem
    {
        public FileInfo ProcessedFile { get; set; }
        public bool Failed { get; set; } = false;
        public Exception? Exception { get; set; } = null;

        public RenamerReportItem(FileInfo processedFile, bool failed = false, Exception? exception = null)
        {
            ProcessedFile = processedFile;
            Failed = failed;
            Exception = exception;
        }
    }
}
