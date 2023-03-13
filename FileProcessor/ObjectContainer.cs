using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor
{
    public class ObjectContainer
    {
        public List<DirectoryInfo> Dirs { get; set; } = new List<DirectoryInfo>();
        public List<FileInfo> Files { get; set; } = new List<FileInfo>();

        public ObjectContainer()
        { }
    }
}
