using Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Empleados
{
    public class EmpleadoLogInDTO
    {
        public string Usuario { get; set; }
        public ERoles Rol { get; set; }
        public ESectores Sector { get; set; } 
            
    }
}
