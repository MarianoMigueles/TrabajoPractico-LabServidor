using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios.Interfaces
{
    public interface IPedidosRepository : IRepository<Pedidos>
    {
        void CambiarEstado(Pedidos pedidos, EstadoPedido estado);
        Task<List<Pedidos>> FueraDeTiempo();
        Task<List<Pedidos>> ObtenerTodosLosPedidos(); //retorna todos los pedidos dentro de cada una de las comandas
        Task<List<Pedidos>> ObtenerPedidosPendientes();

        Task<Pedidos> ObtenerPedidoEnPreparacion(int id);
    }
}
