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

        public async Task<Pedidos> IdentificarPedido(int id)
        {
            var pedido = await _context.Pedidos.Where(x => x.IdPedidos == id).FirstOrDefaultAsync() ?? throw new Exception("El pedido no fue encontrado");
            return pedido;
        }

        public async Task<Pedidos> ObtenerPedidoEnPreparacion(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Pedidos>> ObtenerPedidosPendientes()
        {
            var pedido = await _context.Pedidos.Where(x => x.EstadoPedido == EstadoPedido.Pendiente).ToListAsync();
            return pedido;
        }

        public async Task<List<Pedidos>> ObtenerTodosLosPedidos()
        {
            var pedidos = await _context.Pedidos.ToListAsync();
            return pedidos;
        }
    }
}
