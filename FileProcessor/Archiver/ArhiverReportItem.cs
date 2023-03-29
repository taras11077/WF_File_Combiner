using FileProcessor.Renamer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Archiver
{
    public class ArhiverReportItem
    {
        public DirectoryInfo ProcessedDirectory { get; set; }
        public string ArhiveFileName { get; set; }
        public bool Failed { get; set; } = false;
        public Exception? Exception { get; set; } = null;

        public ArhiverReportItem(DirectoryInfo processedDir, string arhiveFileName, bool failed = false, Exception? exception = null)
        {
            ProcessedDirectory = processedDir;
            ArhiveFileName = arhiveFileName;
            Failed = failed;
            Exception = exception;
        }

    }
}
