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
        Task<Pedidos> ObtenerPedidoEnPreparacion(int codigo);
    }
}
