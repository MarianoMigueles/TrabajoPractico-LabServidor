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
    public class ComandasRepository(DataContext context) : Repository<Comandas>(context), IComandasRepository
    {
        public async Task<Comandas> ObtenerComandaConPedidos(int idComanda)
        {
            return await _context.Comandas
                .Include(c => c.Pedidos)
                .ThenInclude(p => p.IdProductoNavigation)
                .FirstOrDefaultAsync(c => c.IdComandas == idComanda);
        }
    }
}
