using Microsoft.EntityFrameworkCore;
using Entities;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Comandas> Comandas { get; set; }
        public virtual DbSet<Mesas> Mesas { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<OperacionesEmpleados> Operaciones { get; set; }
        public virtual DbSet<LogInEmpleado> LogIns { get; set; }


    }
}
