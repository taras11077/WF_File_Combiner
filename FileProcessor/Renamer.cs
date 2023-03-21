using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor
{
    public class Renamer
    {
        public string[] FileMasks { get; set; } = { };


        public void Rename(string oldName, string newName)
        {
            File.Move(@"C:\ff\Текстовый документ.txt", @"C:\ff\0.txt");
        }
    }
}
