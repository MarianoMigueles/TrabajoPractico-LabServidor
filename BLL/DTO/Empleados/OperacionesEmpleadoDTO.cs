using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Empleados
{
    public class OperacionesEmpleadoDTO
    {
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public ESectores Sector { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaOperacion { get; set; }
    }
}
