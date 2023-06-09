﻿using Microsoft.VisualBasic.FileIO;
using FileProcessor.Finder;

namespace FileProcessor.Cleaner
{
    public class Remover
    {
        public bool trash = false;
        public ObjectContainer ListItems { get; set; } = new ObjectContainer();
        public ObjectContainer RemovedItems { get; set; } = new ObjectContainer();


        public CleanerReport Remove(bool trash)
        {
            CleanerReport cleaningReport = new CleanerReport();


            foreach (FileInfo removedFile in RemovedItems.Files) // перебор отмеченних файлов
            {
                try
                {
                    string? filename = removedFile.FullName.ToString();

                    if (RemovedItems.Files.Count != 0)
                    {
                        if (trash)
                            FileSystem.DeleteFile(filename, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                        else
                            File.Delete(filename);

                        cleaningReport.PushSuccess(removedFile);

                        ListItems.Files.Remove(removedFile);
                    }
                }
                catch (Exception ex)
                {
                    cleaningReport.PushError(removedFile, ex);
                }
            }


            foreach (DirectoryInfo removedDir in RemovedItems.Dirs) // перебор отмеченних файлов
            {
                try
                {
                    string? dirname = removedDir.FullName.ToString();
                    if (trash)
                    {
                        FileSystem.DeleteDirectory(dirname, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);

                        foreach (FileInfo listFile in ListItems.Files) // удаление из ListView всех вложенних в удаляемую папку елементов, независимо от того отмечени ли они на удаление
                        {
                            if (listFile.FullName.ToString()!.Contains(removedDir.FullName.ToString()))
                                ListItems.Files.Remove(listFile);
                        }
                    }
                    else
                        Directory.Delete(dirname);

                    cleaningReport.PushSuccess(removedDir);

                    ListItems.Dirs.Remove(removedDir);
                }
                catch (Exception ex)
                {
                    cleaningReport.PushError(removedDir, ex);
                }


            }


            return cleaningReport;


        }
    }
}
