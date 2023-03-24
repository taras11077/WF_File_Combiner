using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Renamer.Generators
{
    internal class UuidGenerator : IStringGenerator
    {
        public string GetNext()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
