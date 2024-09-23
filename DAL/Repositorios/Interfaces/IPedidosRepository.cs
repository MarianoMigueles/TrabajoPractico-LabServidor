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
        Task<List<Pedidos>> FueraDeTiempo();
        Task<List<Pedidos>> ObtenerPedidosPendientes();
        Task<Pedidos> ObtenerPedidoEnPreparacion(int id);
    }
}
