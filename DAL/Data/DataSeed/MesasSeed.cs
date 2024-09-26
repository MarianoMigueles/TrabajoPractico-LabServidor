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
    public class MesasSeed : IEntityTypeConfiguration<Mesas>
    {
        public void Configure(EntityTypeBuilder<Mesas> builder)
        {
            builder.HasData(
                new Mesas { IdMesa = 1, IdEstado = 1, Nombre = "Mesa 1", EstadoMesa = EEstadoMesa.ClienteEsperandoPedido },
                new Mesas { IdMesa = 2, IdEstado = 2, Nombre = "Mesa 2", EstadoMesa = EEstadoMesa.ClienteComiendo },
                new Mesas { IdMesa = 3, IdEstado = 3, Nombre = "Mesa 3", EstadoMesa = EEstadoMesa.ClientePagando },
                new Mesas { IdMesa = 4, IdEstado = 4, Nombre = "Mesa 4", EstadoMesa = EEstadoMesa.Cerrada },
                new Mesas { IdMesa = 5, IdEstado = 1, Nombre = "Mesa 5", EstadoMesa = EEstadoMesa.ClienteEsperandoPedido }
            );
        }
    }

}
