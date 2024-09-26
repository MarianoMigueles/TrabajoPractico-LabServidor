using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DAL.Data.DataSeed
{

    public class PedidosSeed : IEntityTypeConfiguration<Pedidos>
    {
        public void Configure(EntityTypeBuilder<Pedidos> builder)
        {
            builder.HasData(
                new Pedidos { IdPedidos = 1, IdComandas = 1, IdProducto = 1, IdEstado = 1, Cantidad = 2, FechaCreacion = DateTime.Now, FechaFinalizacion = DateTime.Now.AddMinutes(15), TiempoEstimadoFinalizacion = DateTime.Now.AddMinutes(20), EstadoPedido = EEstadoPedido.ListoParaServir },
                new Pedidos { IdPedidos = 2, IdComandas = 2, IdProducto = 2, IdEstado = 2, Cantidad = 1, FechaCreacion = DateTime.Now, FechaFinalizacion = DateTime.Now.AddMinutes(10), TiempoEstimadoFinalizacion = DateTime.Now.AddMinutes(15), EstadoPedido = EEstadoPedido.EnPreparacion },
                new Pedidos { IdPedidos = 3, IdComandas = 3, IdProducto = 3, IdEstado = 3, Cantidad = 3, FechaCreacion = DateTime.Now, FechaFinalizacion = DateTime.Now.AddMinutes(5), TiempoEstimadoFinalizacion = DateTime.Now.AddMinutes(10), EstadoPedido = EEstadoPedido.Pendiente },
                new Pedidos { IdPedidos = 4, IdComandas = 4, IdProducto = 4, IdEstado = 1, Cantidad = 2, FechaCreacion = DateTime.Now, FechaFinalizacion = DateTime.Now.AddMinutes(25), TiempoEstimadoFinalizacion = DateTime.Now.AddMinutes(30), EstadoPedido = EEstadoPedido.EntregadoFueraDeTiempo },
                new Pedidos { IdPedidos = 5, IdComandas = 5, IdProducto = 5, IdEstado = 2, Cantidad = 1, FechaCreacion = DateTime.Now, FechaFinalizacion = DateTime.Now.AddMinutes(30), TiempoEstimadoFinalizacion = DateTime.Now.AddMinutes(35), EstadoPedido = EEstadoPedido.Entregado }
            );
        }
    }

}
