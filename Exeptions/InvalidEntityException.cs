using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions
{
    public class InvalidEntityException : Exception
    {
        public InvalidEntityException(string message) : base(message) { }
        public InvalidEntityException(string message, Exception innerException) : base(message, innerException) { }
    }
}
