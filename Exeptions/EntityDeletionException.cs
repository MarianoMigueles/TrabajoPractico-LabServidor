using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions
{
    public class EntityDeletionException : Exception
    {
        public EntityDeletionException(string message) : base(message) { }
        public EntityDeletionException(string message, Exception innerException) : base(message, innerException) { }
    }
}
