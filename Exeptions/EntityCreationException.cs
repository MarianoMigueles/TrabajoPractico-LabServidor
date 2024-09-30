using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions
{
    public class EntityCreationException : Exception
    {
        public EntityCreationException(string message) : base(message) { }
        public EntityCreationException(string message, Exception innerException) : base(message, innerException) { }

    }
}
