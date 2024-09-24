using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios.Interfaces
{
    public interface IPedidosRepository : IRepository<Pedidos>
    {
        void CambiarEstado(Pedidos pedidos, EEstadoPedido estado);
        Task<List<Pedidos>> ObtenerPedidoFueraDeTiempo();
        Task<DateTime> ObtenerTiempoEstimadoPedidoDePreparacion(int idPedido);
        Task<Pedidos> PonerPedidoEnPreparacion(int idPedido, DateTime tiempoEstimado);
        Task<List<Pedidos>> ObtenerPedidosPendientes();
    }
}
