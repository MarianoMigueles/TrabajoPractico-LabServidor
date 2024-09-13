using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using DAL.Repositorios.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    public class ComandasRepository : Repository<Comandas>, IComandasRepository
    {
        public ComandasRepository(DataContext context) : base(context)
        {

        }

        public async Task<List<Pedidos>> ObtenerPedidosPendientes()
        {
            var result = await _context.Pedidos.Where(x => x.EstadoPedido == EstadoPedido.Pendiente).ToListAsync();
            return result;
        }
    }
}
