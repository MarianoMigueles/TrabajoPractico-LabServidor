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
    public class ProductosSeed : IEntityTypeConfiguration<Productos>
    {
        public void Configure(EntityTypeBuilder<Productos> builder)
        {
            builder.HasData(
                new Productos { IdProducto = 1, IdSector = 1, Descripcion = "Pizza Margherita", Stock = 10, Precio = 120, Sector = ESectores.Cocina },
                new Productos { IdProducto = 2, IdSector = 2, Descripcion = "Cerveza Artesanal", Stock = 20, Precio = 80, Sector = ESectores.BarraDeTragosYVinos },
                new Productos { IdProducto = 3, IdSector = 1, Descripcion = "Ensalada César", Stock = 15, Precio = 90, Sector = ESectores.Cocina },
                new Productos { IdProducto = 4, IdSector = 1, Descripcion = "Pasta al Pesto", Stock = 12, Precio = 150, Sector = ESectores.Cocina },
                new Productos { IdProducto = 5, IdSector = 2, Descripcion = "Refresco", Stock = 30, Precio = 50, Sector = ESectores.BarraDeChoperas }
            );
        }
    }

}
