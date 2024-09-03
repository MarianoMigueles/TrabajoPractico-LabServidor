using Entities;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dto.Productos
{
    public class ProductoDTO
    {
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public int Precio { get; set; }
        public Sectores Sector { get; set; }

    }
}
