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

    public class LogInEmpleadoSeed : IEntityTypeConfiguration<LogInEmpleado>
    {
        public void Configure(EntityTypeBuilder<LogInEmpleado> builder)
        {
            builder.HasData(
                new LogInEmpleado { Id = 1, IdEmpleado = 1 },
                new LogInEmpleado { Id = 2, IdEmpleado = 2 },
                new LogInEmpleado { Id = 3, IdEmpleado = 3 },
                new LogInEmpleado { Id = 4, IdEmpleado = 4 },
                new LogInEmpleado { Id = 5, IdEmpleado = 5 }
            );
        }
    }

}
