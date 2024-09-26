using Microsoft.EntityFrameworkCore;
using Entities;
using DAL.Data.DataSeed;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ComandasSeed());
            modelBuilder.ApplyConfiguration(new EmpleadosSeed());
            modelBuilder.ApplyConfiguration(new LogInEmpleadoSeed());
            modelBuilder.ApplyConfiguration(new OperacionesEmpleadosSeed());
            modelBuilder.ApplyConfiguration(new PedidosSeed());
            modelBuilder.ApplyConfiguration(new ProductosSeed());
            modelBuilder.ApplyConfiguration(new MesasSeed());
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
