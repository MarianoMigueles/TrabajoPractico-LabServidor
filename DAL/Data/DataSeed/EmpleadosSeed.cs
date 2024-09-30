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
                new Empleados { IdEmpleados = 1, Nombre = "Ana Torres", Usuario = "atorres", Password = "password1", Estado = EEstadoEmpleado.Activo, Rol = ERoles.Cerveceros},
                new Empleados { IdEmpleados = 2, Nombre = "Luis Fernández", Usuario = "lfernandez", Password = "password2", Estado = EEstadoEmpleado.Activo, Rol = ERoles.Cocineros },
                new Empleados { IdEmpleados = 3, Nombre = "Pedro Ruiz", Usuario = "pruiz", Password = "password3", Estado = EEstadoEmpleado.Activo, Rol = ERoles.Mozos },
                new Empleados { IdEmpleados = 4, Nombre = "Marta Díaz", Usuario = "mdiaz", Password = "password4", Estado = EEstadoEmpleado.Activo, Rol = ERoles.Bartender },
                new Empleados { IdEmpleados = 5, Nombre = "Sofia Martínez", Usuario = "smartinez", Password = "password5", Estado = EEstadoEmpleado.Activo, Rol = ERoles.Socios },
                new Empleados { IdEmpleados = 5, Nombre = "Eduardo Perez", Usuario = "eperez", Password = "password6", Estado = EEstadoEmpleado.Activo, Rol = ERoles.Admin }
            );
        }
    }

}
