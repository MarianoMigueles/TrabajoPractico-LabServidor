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

    public class OperacionesEmpleadosSeed : IEntityTypeConfiguration<OperacionesEmpleados>
    {
        public void Configure(EntityTypeBuilder<OperacionesEmpleados> builder)
        {
            builder.HasData(
                new OperacionesEmpleados { Id = 1, IdEmpleado = 1, Sector = ESectores.Cocina, Descripcion = "Preparación de platos", FechaOperacion = DateTime.Now.AddMinutes(-30) },
                new OperacionesEmpleados { Id = 2, IdEmpleado = 2, Sector = ESectores.BarraDeTragosYVinos, Descripcion = "Reabastecimiento de bebidas", FechaOperacion = DateTime.Now.AddMinutes(-20) },
                new OperacionesEmpleados { Id = 3, IdEmpleado = 3, Sector = ESectores.Cocina, Descripcion = "Limpieza de utensilios", FechaOperacion = DateTime.Now.AddMinutes(-5) },
                new OperacionesEmpleados { Id = 4, IdEmpleado = 4, Sector = ESectores.BarraDeChoperas, Descripcion = "Atención al cliente", FechaOperacion = DateTime.Now }
            );
        }
    }

}
