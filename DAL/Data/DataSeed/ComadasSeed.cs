using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Data.DataSeed
{
    public class ComandasSeed : IEntityTypeConfiguration<Comandas>
    {
        public void Configure(EntityTypeBuilder<Comandas> builder)
        {
            builder.HasData(
                new Comandas { IdComandas = 1, IdMesa = 1, NombreCliente = "Mariano Joel" },
                new Comandas { IdComandas = 2, IdMesa = 2, NombreCliente = "Sheila Gómez" },
                new Comandas { IdComandas = 3, IdMesa = 3, NombreCliente = "Ian Migueles" },
                new Comandas { IdComandas = 4, IdMesa = 4, NombreCliente = "Lucía Pérez" },
                new Comandas { IdComandas = 5, IdMesa = 5, NombreCliente = "Carlos López" }
            );
        }
    }

}
