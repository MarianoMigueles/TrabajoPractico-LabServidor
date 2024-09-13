using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using DAL.Repositorios.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    public class PedidosRepository : Repository<Pedidos>, IPedidosRepository
    {
        public PedidosRepository(DataContext context) : base(context)
        {
        }

        public void CambiarEstado(Pedidos pedidos, EstadoPedido estado)
        {
            pedidos.CambiarEstado(estado);
        }

        public Task<List<Pedidos>> FueraDeTiempo()
        {
            var result = _context.Pedidos.Where(x => x.EstadoPedido == EstadoPedido.EntregadoFueraDeTiempo).ToListAsync();
            return result;
        }

        public Task<Productos> MasVendido()
        {
            throw new NotImplementedException();
        }

        public Task<Productos> MenosVendido()
        {
            throw new NotImplementedException();
        }
    }
}
