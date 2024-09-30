using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions
{
    public class EntityUpdateException : Exception
    {
        public EntityUpdateException(string message) : base(message) { }
        public EntityUpdateException(string message, Exception innerException) : base(message, innerException) { }
    }
}
