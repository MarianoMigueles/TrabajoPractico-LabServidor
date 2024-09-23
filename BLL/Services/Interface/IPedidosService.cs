using BLL.DTO.Pedidos;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interface
{
    public interface IPedidosService
    {
        Task<PedidosDTO> CambiarEstado(int idPedido, EEstadoPedido estado);
        Task<List<PedidosDTO>> FueraDeTiempo();
        Task<List<PedidosDTO>> ObtenerPedidosPendientes();
        Task<PedidosDTO> ObtenerPedidoEnPreparacion(int id);
    }
}
