using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using DAL.Repositorios.Interfaces;
using Entities;
using Entities.Enums;
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

        public void CambiarEstado(Pedidos pedidos, EEstadoPedido estado)
        {
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
            return result.TiempoEstimadoFinalizacion;
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
    }
}
