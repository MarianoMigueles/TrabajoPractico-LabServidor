using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Empleados
    {
        public int IdEmpleados {  get; set; }
        public int IdSector { get; set; }
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Passsword { get; set; }

    }
}
