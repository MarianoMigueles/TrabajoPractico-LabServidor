using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios.Interfaces
{
    public interface IComandasRepository : IRepository<Comandas>
    {
        Task<List<Pedidos>> ObtenerPedidosPendientes();
    }
}
