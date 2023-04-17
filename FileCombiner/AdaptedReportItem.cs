using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCombiner
{
    public class AdaptedReportItem
    {
        public string Name { get; set; } = string.Empty;
        public double Size { get; set; } = 0;
        public int ImageIndex { get; set; } = -1;
        public int GroupIndex { get; set; } = -1;
        public string LastAccessTime { get; set; } = string.Empty;
        public string ArhiveName { get; set; } = string.Empty;
        public double ArhiveSize { get; set; } = 0;
        public string Path { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Exception { get; set; } = string.Empty;

        public AdaptedReportItem() {}
    }
}
