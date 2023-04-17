
namespace FileProcessor.Finder
{
    public class ObjectContainer
    {
        public List<DirectoryInfo> Dirs { get; set; } = new List<DirectoryInfo>();
        public List<FileInfo> Files { get; set; } = new List<FileInfo>();

        public ObjectContainer()
        { }

        public ObjectContainer(List<DirectoryInfo> dirs, List<FileInfo> files)
        {
            Dirs = dirs;
            Files = files;
        }
    }
}
