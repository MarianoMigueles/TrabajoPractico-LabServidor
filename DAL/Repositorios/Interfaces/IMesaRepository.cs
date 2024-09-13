using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Repositorios.Interfaces
{
    public interface IMesaRepository : IRepository<Mesas>
    {
        Task<Pedidos> ObtenerPedidoEnPreparacion(int codigo);
        Task<Pedidos> IdentificarPedido(int codigo);
        Task<EstadoMesa> CambiarEstado(int idMesa, EstadoMesa estadoMesa);
        Task<bool> CerrarMesa(int idMesa);
    }
}
