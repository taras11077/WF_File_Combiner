using FileProcessor.Renamer.Generators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Renamer
{
    public class Renamer
    {
        private IStringGenerator generator;
        public List<FileInfo> Files { get; set; }
        public int AIStartValue { get; set; } = 0;
        public int AIStep { get; set; } = 1;

        public Renamer() { }
        public Renamer(List<FileInfo> files)
        {
            Files = files;
        }

        public Renamer(List<FileInfo> files, RenamerMask mask)      // TODO: List<FileInfo>  ---> IEnumerable<FileInfo>
        {
            Files = files;

            SetMask(mask);
        }

        public void SetMask(RenamerMask mask)
        {
            generator = mask switch
            {
                RenamerMask.UUID => new UuidGenerator(),
                RenamerMask.AUTOINCREMENT => new AutoincrementGenerator(AIStartValue, AIStep),

                _ => throw new InvalidOperationException(),
            };
        }

        public Report RenameByMask(string prefix)
        {
            Report report = new Report();

            Files.ForEach(f =>
            {
                try
                {
                    //if (f.Name == "1.jpg")
                    //    throw new Exception("test message");

                    string ext = f.Extension;

                    string randomChunk = generator.GetNext();

                    string newTitle = $"{prefix}{randomChunk}{ext}";

                    string path = Path.Combine(f.Directory.FullName, newTitle); // TODO: ???

                    f.MoveTo(path);

                    report.PushSuccess(f);
                }
                catch (Exception ex)
                {
                    report.PushError(f, ex);

                }
            });

            return report;
        }




        public void NumberModeRename()
        {
            for (int i = 0; i < Files?.Count; i++)
                NameGenerator.GenerateNewName(Files[i].FullName, $"{i}");
        }

        public void RandomStringModeRename()
        {
            Random random = new Random();
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            foreach (FileInfo file in Files)
            {
                string randomString = "";

                for (int i = 0; i < 10; i++)
                {
                    int numLetter = random.Next(0, letters.Length - 1);
                    randomString += letters[numLetter];
                }

                NameGenerator.GenerateNewName(file.FullName, randomString);
            }
        }

        public void UUIDModeRename()
        {
            foreach (FileInfo file in Files)
            {
                string inset = Guid.NewGuid().ToString();
                NameGenerator.GenerateNewName(file.FullName, inset);
            }
        }


        

    }
}
