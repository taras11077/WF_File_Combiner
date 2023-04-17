using FileProcessor.Archiver.Exceptions;

namespace FileProcessor.Archiver
{
    public class ArchiveEngine
    {
        private ICompressor? Compressor { get; set; }
        private void SetCompressor(ArchiveEngineMode mode)
        {
            Compressor = mode switch
            {
                ArchiveEngineMode.Zip => new ZipCompressor(),

                _ => new ZipCompressor()
            };
        }

        public ArchiveEngine(ArchiveEngineMode mode = ArchiveEngineMode.Zip)
        {
            SetCompressor(mode);
        }
        public void SetMode(ArchiveEngineMode mode)
        {
            SetCompressor(mode);
        }
        public string CompressDirectory(string path, string? receiveDir = "")
        {
            if (! Directory.Exists(path))
                throw new Exceptions.DirectoryNotFoundException($"Directory {path} not found");

            path = Path.TrimEndingDirectorySeparator(path);

            if (receiveDir == string.Empty) 
            {
                receiveDir = Directory.GetParent(path)?.FullName;

                if (receiveDir == null)
                    throw new ReceiveDirectoryNotAvailableException(null);
            }

            string outName = new DirectoryInfo(path).Name;

            string outFile = Compressor.CompressDir(path, receiveDir, outName);

            return outFile;
        }


    }
}
