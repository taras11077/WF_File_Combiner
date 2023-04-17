
namespace FileProcessor
{
    public class Calculator
    {
        public int dirSize = 0;

        public int CalcDirSize(DirectoryInfo d) //расчет размера директории
        {
            DirectoryInfo[] dirs = d.GetDirectories();
            FileInfo[] files = d.GetFiles();

            foreach (FileInfo file in files)
            {
                dirSize += (int)file.Length;
            }

            foreach (DirectoryInfo dir in dirs)
            {
                CalcDirSize(dir);
            }

            return dirSize;
        }


    }
}
