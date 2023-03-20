using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Archiver
{
    public interface ICompressor
    {
        public string CompressDir(string target, string receiveDir, string fileName);
        public void DecompressDir();
    }
}
