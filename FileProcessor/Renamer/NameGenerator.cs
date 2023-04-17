

namespace FileProcessor.Renamer
{
    internal static class NameGenerator
    {

        public static void GenerateNewName(string fileName, string inset)
        {
            //поиск индекса последней точки
            int dotIndex = fileName.LastIndexOf('.');
            string ext = fileName.Substring(dotIndex + 1, fileName.Length - dotIndex - 1);

            //поиск индекса последнего слеша
            int slashInd = fileName.LastIndexOf('\\');

            //переименование
            File.Move(fileName, fileName.Remove(slashInd + 1) + inset + "." + ext);
        }
    }
}
