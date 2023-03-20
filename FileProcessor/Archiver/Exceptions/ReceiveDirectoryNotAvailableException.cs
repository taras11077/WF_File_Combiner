using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Archiver.Exceptions
{
    internal class ReceiveDirectoryNotAvailableException : ArchiverException
    {
        public ReceiveDirectoryNotAvailableException(string? message, Exception? innerException = null)
            : base(message, innerException)
        { }
    }
}
