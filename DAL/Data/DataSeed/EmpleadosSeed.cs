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
                new Empleados { IdEmpleados = 1, IdSector = 1, IdRol = 1, Nombre = "Ana Torres", Usuario = "atorres", Passsword = "password1", Estado = EEstadoEmpleado.Activo },
                new Empleados { IdEmpleados = 2, IdSector = 2, IdRol = 2, Nombre = "Luis Fernández", Usuario = "lfernandez", Passsword = "password2", Estado = EEstadoEmpleado.Activo },
                new Empleados { IdEmpleados = 3, IdSector = 3, IdRol = 1, Nombre = "Pedro Ruiz", Usuario = "pruiz", Passsword = "password3", Estado = EEstadoEmpleado.Suspendido },
                new Empleados { IdEmpleados = 4, IdSector = 1, IdRol = 3, Nombre = "Marta Díaz", Usuario = "mdiaz", Passsword = "password4", Estado = EEstadoEmpleado.Activo },
                new Empleados { IdEmpleados = 5, IdSector = 2, IdRol = 2, Nombre = "Sofia Martínez", Usuario = "smartinez", Passsword = "password5", Estado = EEstadoEmpleado.Eliminado }
            );
        }
    }

}
