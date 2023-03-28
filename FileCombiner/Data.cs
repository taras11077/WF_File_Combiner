using FileProcessor;
using FileProcessor.Archiver;
using FileProcessor.Cleaner;
using FileProcessor.Renamer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCombiner
{
    public static class Data
    {
        public static Report renamerReport  = new();
        public static ArhiveReport arhiverReport = new();
        public static CleaningReport cleaningReport = new();
    }
}
