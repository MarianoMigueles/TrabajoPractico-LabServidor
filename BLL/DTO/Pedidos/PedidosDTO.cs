using Entities.Enums;

namespace BLL.DTO.Pedidos
{
    public class PedidosDTO
    {
        public int Cantidad { get; set; }
        public EEstadoPedido EstadoPedido { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public DateTime? TiempoEstimadoFinalizacion { get; set; }
    }
}
