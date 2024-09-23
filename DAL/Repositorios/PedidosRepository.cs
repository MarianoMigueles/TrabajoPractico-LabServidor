<<<<<<< Updated upstream
﻿using System;
=======
﻿using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using DAL.Repositorios.Interfaces;
using Entities;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
>>>>>>> Stashed changes
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    internal class PedidosRepository
    {
<<<<<<< Updated upstream
=======
        public PedidosRepository(DataContext context) : base(context)
        {
        }

        public void CambiarEstado(Pedidos pedidos, EEstadoPedido estado)
        {
            pedidos.CambiarEstado(estado);
        }

        public Task<List<Pedidos>> FueraDeTiempo()
        {
            var result = _context.Pedidos.Where(x => x.EstadoPedido == EEstadoPedido.EntregadoFueraDeTiempo).ToListAsync();
            return result;
        }

        public async Task<Pedidos> ObtenerPedidoEnPreparacion(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Pedidos>> ObtenerPedidosPendientes()
        {
            var pedido = await _context.Pedidos.Where(x => x.EstadoPedido == EEstadoPedido.Pendiente).ToListAsync();
            return pedido;
        }


>>>>>>> Stashed changes
    }
}
