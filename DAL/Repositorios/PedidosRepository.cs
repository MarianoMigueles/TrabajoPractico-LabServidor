using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using DAL.Repositorios.Interfaces;
using Entities;
using Entities.Enums;
using Exeptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    public class PedidosRepository(DataContext context) : Repository<Pedidos>(context), IPedidosRepository 
    {
        public void CambiarEstado(Pedidos pedidos, EEstadoPedido estado)
        {
            if (pedidos.EstadoPedido == EEstadoPedido.Pendiente)
            {
                throw new InvalidStateException("No se puede cambiar el estado de un pedido pendiente.");
            }

            pedidos.CambiarEstado(estado);
        }

        public async Task<List<Pedidos>> ObtenerPedidoFueraDeTiempo()
        {
            var result = await _context.Pedidos.Where(x => x.EstadoPedido == EEstadoPedido.EntregadoFueraDeTiempo).ToListAsync();
            return result;
        }

        public async Task<DateTime> ObtenerTiempoEstimadoPedidoDePreparacion(int idPedido)
        {
            var result = await this.GetById(idPedido);
            if (result.TiempoEstimadoFinalizacion == null)
            {
                throw new InvalidOperationException("El pedido no se encuentra en preparacion");
            }
            return (DateTime)result.TiempoEstimadoFinalizacion;
        }

        public async Task<Pedidos> PonerPedidoEnPreparacion(int idPedido, DateTime tiempoEstimado)
        {
            var result = await this.GetById(idPedido);
            result.CambiarEstado(tiempoEstimado);
            return result;
        }
        public async Task<List<Pedidos>> ObtenerPedidosPendientes()
        {
            var pedido = await _context.Pedidos.Where(x => x.EstadoPedido == EEstadoPedido.Pendiente).ToListAsync();
            return pedido;
        }

        public async Task<List<Pedidos>> ObtenerPedidosPendientesPorSector(ESectores sector)
        {
            return await _context.Pedidos.Include(p => p.IdProductoNavigation)
                .Where(x => x.EstadoPedido == EEstadoPedido.Pendiente && x.IdProductoNavigation.Sector == sector)
                .ToListAsync();
        }

        public async Task<List<Pedidos>> ObtenerPedidosListosParaServir()
        {
            return await _context.Pedidos.Where(x => x.EstadoPedido == EEstadoPedido.ListoParaServir).ToListAsync();
        }
    }
}
