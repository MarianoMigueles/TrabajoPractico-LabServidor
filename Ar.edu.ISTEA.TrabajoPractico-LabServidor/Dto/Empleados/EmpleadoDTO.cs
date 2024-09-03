using Entities;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dto.Empleados
{
    public class EmpleadoDTO
    {
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public Sectores Sector { get; set; }
    }
}
