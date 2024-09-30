using Entities.Enums;

namespace BLL.DTO.Empleados
{
    public class EmpleadoDTO
    {
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public ESectores Sector { get; set; }
        public ERoles Rol { get; set; }
    }
}
