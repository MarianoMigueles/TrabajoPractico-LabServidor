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
        Task<Productos> MasVendido();
        Task<Productos> MenosVendido();
        Task<List<Pedidos>> FueraDeTiempo();
    }
}
