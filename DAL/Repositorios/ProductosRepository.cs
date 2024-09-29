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
    public class ProductosRepository(DataContext context) : Repository<Productos>(context), IProductosRepository
    {
        public async Task<Productos> MasVendido()
        {
            var result = await _context.Pedidos
                                    .GroupBy(p => p.IdProducto)
                                    .Select(group => new
                                    {
                                        IdProducto = group.Key,
                                        TotalCantidad = group.Sum(p => p.Cantidad)
                                    })
                                    .OrderByDescending(p => p.TotalCantidad)
                                    .FirstOrDefaultAsync();

            return await _context.Productos.FindAsync(result.IdProducto) ?? null;
        }

        public async Task<Productos> MenosVendido()
        {
            var result = await _context.Pedidos
                        .GroupBy(p => p.IdProducto)
                        .Select(group => new
                        {
                            IdProducto = group.Key,
                            TotalCantidad = group.Sum(p => p.Cantidad)
                        })
                        .OrderBy(p => p.TotalCantidad)
                        .FirstOrDefaultAsync();

            return await _context.Productos.FindAsync(result.IdProducto) ?? null;
        }

        public async void ReducirStock(int idProducto, int stock)
        {
            var producto = await this.GetById(idProducto);
            producto.ReducirStock(stock);
        }

        public async void RellenarStock(int idProducto, int stock)
        {
            var producto = await this.GetById(idProducto);
            producto.RellenarStock(stock);
        }
    }
}
