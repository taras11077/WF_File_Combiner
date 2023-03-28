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

        public Renamer(List<FileInfo> files, RenamerMask mask)      
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




        public Report NumberModeRename()
        {
            Report report = new Report();
            int i = 0;
            foreach (FileInfo file in Files)          
            {
                try
                {
                    NameGenerator.GenerateNewName(file.FullName, $"{i}");
                    i++;
                    report.PushSuccess(file);
                }
                catch (Exception ex)
                {
                    report.PushError(file, ex);
                }
            }
                    
            return report;
        }

        public Report RandomStringModeRename()
        {
            Report report = new Report();

            Random random = new Random();
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            foreach (FileInfo file in Files)
            {
                try
                {
                    string randomString = "";

                    for (int i = 0; i < 10; i++)
                    {
                        int numLetter = random.Next(0, letters.Length - 1);
                        randomString += letters[numLetter];
                    }

                    NameGenerator.GenerateNewName(file.FullName, randomString);
                    report.PushSuccess(file);
                }
                catch (Exception ex)
                {
                    report.PushError(file, ex);
                }
            }
            return report;
        }

        public Report UUIDModeRename()
        {
            Report report = new Report();

            foreach (FileInfo file in Files)
            {
                try
                {
                    string inset = Guid.NewGuid().ToString();
                    NameGenerator.GenerateNewName(file.FullName, inset);

                    report.PushSuccess(file);
                }
                catch (Exception ex)
                {
                    report.PushError(file, ex);
                }
            }
            return report;
        }      
    }
}
