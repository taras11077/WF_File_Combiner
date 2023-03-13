using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor
{
    public class Finder
    {
        public string[] DirPatterns { get; set; } = { };
        public string[] FilePatterns { get; set; } = { };
        public ObjectContainer ResultContainer { get; set; } = new ObjectContainer();

        public void Analyze(string rootPath)
        {
            DirectoryInfo dir = new DirectoryInfo(rootPath);

            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();

            foreach (DirectoryInfo d in dirs)
            {
                if (DirPatterns.Contains(d.Name))
                    ResultContainer.Dirs.Add(d);
                else
                    Analyze(d.FullName);
            }
        }


    }
}
