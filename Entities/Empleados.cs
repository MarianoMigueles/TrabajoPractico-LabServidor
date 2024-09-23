using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;

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

        public ESectores Sector { get; set; }
        public ERoles Rol { get; set; }
        public EEstadoEmpleado Estado { get; set; }
    }
}
