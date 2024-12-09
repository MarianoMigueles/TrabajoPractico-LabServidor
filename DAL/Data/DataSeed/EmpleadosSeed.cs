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

    public class EmpleadosSeed : IEntityTypeConfiguration<Empleados>
    {
        public void Configure(EntityTypeBuilder<Empleados> builder)
        {
            builder.HasData(
                new Empleados { IdEmpleados = 1, Nombre = "Ana Torres", Usuario = "cerveceros", Password = "password", Estado = EEstadoEmpleado.Activo, Rol = ERoles.Cerveceros, Sector = ESectores.BarraDeTragosYVinos},
                new Empleados { IdEmpleados = 2, Nombre = "Luis Fernández", Usuario = "cocinero", Password = "password", Estado = EEstadoEmpleado.Activo, Rol = ERoles.Cocineros, Sector = ESectores.Cocina },
                new Empleados { IdEmpleados = 3, Nombre = "Pedro Ruiz", Usuario = "mozos", Password = "password", Estado = EEstadoEmpleado.Activo, Rol = ERoles.Mozos, Sector = ESectores.Mesas},
                new Empleados { IdEmpleados = 4, Nombre = "Marta Díaz", Usuario = "bartender", Password = "password", Estado = EEstadoEmpleado.Activo, Rol = ERoles.Bartender, Sector = ESectores.BarraDeChoperas},
                new Empleados { IdEmpleados = 5, Nombre = "Sofia Martínez", Usuario = "socios", Password = "password", Estado = EEstadoEmpleado.Activo, Rol = ERoles.Socios, Sector = ESectores.Administracion },
                new Empleados { IdEmpleados = 6, Nombre = "Eduardo Perez", Usuario = "admin", Password = "password", Estado = EEstadoEmpleado.Activo, Rol = ERoles.Admin, Sector = ESectores.Administracion }
            );
        }
    }

}
