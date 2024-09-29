using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Empleados
{
    public class EmpleadoCreateRequestDTO
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Usuario { get; set; }

        [Required]
        public string Password { get; set; }

        public ESectores Sector { get; set; }

        public ERoles Rol { get; set; }
    }
}
