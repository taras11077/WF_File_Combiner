using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Renamer.Generators
{
    internal interface IStringGenerator
    {
        public string GetNext();
    }
}
