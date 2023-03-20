using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Archiver.Exceptions
{
    public class DirectoryNotFoundException : ArchiverException
    {
        public DirectoryNotFoundException(string? message, Exception? innerException = null)
            : base(message, innerException)
        { }
    }
}
