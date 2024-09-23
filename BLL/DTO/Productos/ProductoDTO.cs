using Entities.Enums;

namespace BLL.DTO.Productos
{
    public class ProductoDTO
    {
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public int Precio { get; set; }
        public ESectores Sector { get; set; }

    }
}
