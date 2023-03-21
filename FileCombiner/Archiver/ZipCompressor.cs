using FileProcessor.Archiver.Exceptions;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Archiver
{
    internal class ZipCompressor : ICompressor
    {
        private const string EXTENSION = ".zip";
        public CompressionLevel compressionLevel { get; set; } = CompressionLevel.SmallestSize;
        public bool IncludeBaseDirectory { get; set; } = false;

        public string CompressDir(string target, string receiveDir, string fileName)
        {
            if (!Directory.Exists(target))
                throw new FileProcessor.Archiver.Exceptions.DirectoryNotFoundException($"Directory {target} not found");

            string outFile = Path.Combine(receiveDir, $"{fileName}{EXTENSION}");

            if (File.Exists(outFile))
                throw new FileAlreadyExistsException($"File {receiveDir} already exists");

            ZipFile.CreateFromDirectory(target, outFile, compressionLevel, IncludeBaseDirectory);

            return outFile;
        }

        public void DecompressDir()
        {
            throw new NotImplementedException();
        }
    }
}
