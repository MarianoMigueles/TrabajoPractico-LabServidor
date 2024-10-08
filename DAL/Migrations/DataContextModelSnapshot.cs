﻿// <auto-generated />
using System;
using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Comandas", b =>
                {
                    b.Property<int>("IdComandas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdComandas"));

                    b.Property<int>("IdMesa")
                        .HasColumnType("int");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdComandas");

                    b.HasIndex("IdMesa");

                    b.ToTable("Comandas");

                    b.HasData(
                        new
                        {
                            IdComandas = 1,
                            IdMesa = 1,
                            NombreCliente = "Mariano Joel"
                        },
                        new
                        {
                            IdComandas = 2,
                            IdMesa = 2,
                            NombreCliente = "Sheila Gómez"
                        },
                        new
                        {
                            IdComandas = 3,
                            IdMesa = 3,
                            NombreCliente = "Ian Migueles"
                        },
                        new
                        {
                            IdComandas = 4,
                            IdMesa = 4,
                            NombreCliente = "Lucía Pérez"
                        },
                        new
                        {
                            IdComandas = 5,
                            IdMesa = 5,
                            NombreCliente = "Carlos López"
                        });
                });

            modelBuilder.Entity("Entities.Empleados", b =>
                {
                    b.Property<int>("IdEmpleados")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmpleados"));

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rol")
                        .HasColumnType("int");

                    b.Property<int>("Sector")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEmpleados");

                    b.ToTable("Empleados");

                    b.HasData(
                        new
                        {
                            IdEmpleados = 1,
                            Estado = 0,
                            Nombre = "Ana Torres",
                            Password = "password1",
                            Rol = 1,
                            Sector = 0,
                            Usuario = "atorres"
                        },
                        new
                        {
                            IdEmpleados = 2,
                            Estado = 0,
                            Nombre = "Luis Fernández",
                            Password = "password2",
                            Rol = 2,
                            Sector = 0,
                            Usuario = "lfernandez"
                        },
                        new
                        {
                            IdEmpleados = 3,
                            Estado = 0,
                            Nombre = "Pedro Ruiz",
                            Password = "password3",
                            Rol = 3,
                            Sector = 0,
                            Usuario = "pruiz"
                        },
                        new
                        {
                            IdEmpleados = 4,
                            Estado = 0,
                            Nombre = "Marta Díaz",
                            Password = "password4",
                            Rol = 0,
                            Sector = 0,
                            Usuario = "mdiaz"
                        },
                        new
                        {
                            IdEmpleados = 5,
                            Estado = 0,
                            Nombre = "Sofia Martínez",
                            Password = "password5",
                            Rol = 4,
                            Sector = 0,
                            Usuario = "smartinez"
                        },
                        new
                        {
                            IdEmpleados = 6,
                            Estado = 0,
                            Nombre = "Eduardo Perez",
                            Password = "password6",
                            Rol = 5,
                            Sector = 0,
                            Usuario = "eperez"
                        });
                });

            modelBuilder.Entity("Entities.LogInEmpleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpleado");

                    b.ToTable("LogIns");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FechaIngreso = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdEmpleado = 1
                        },
                        new
                        {
                            Id = 2,
                            FechaIngreso = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdEmpleado = 2
                        },
                        new
                        {
                            Id = 3,
                            FechaIngreso = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdEmpleado = 3
                        },
                        new
                        {
                            Id = 4,
                            FechaIngreso = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdEmpleado = 4
                        },
                        new
                        {
                            Id = 5,
                            FechaIngreso = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdEmpleado = 5
                        });
                });

            modelBuilder.Entity("Entities.Mesas", b =>
                {
                    b.Property<int>("IdMesa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMesa"));

                    b.Property<int>("EstadoMesa")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMesa");

                    b.ToTable("Mesas");

                    b.HasData(
                        new
                        {
                            IdMesa = 1,
                            EstadoMesa = 1,
                            Nombre = "Mesa 1"
                        },
                        new
                        {
                            IdMesa = 2,
                            EstadoMesa = 2,
                            Nombre = "Mesa 2"
                        },
                        new
                        {
                            IdMesa = 3,
                            EstadoMesa = 3,
                            Nombre = "Mesa 3"
                        },
                        new
                        {
                            IdMesa = 4,
                            EstadoMesa = 4,
                            Nombre = "Mesa 4"
                        },
                        new
                        {
                            IdMesa = 5,
                            EstadoMesa = 1,
                            Nombre = "Mesa 5"
                        });
                });

            modelBuilder.Entity("Entities.OperacionesEmpleados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaOperacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("Sector")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpleado");

                    b.ToTable("Operaciones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Preparación de platos",
                            FechaOperacion = new DateTime(2024, 9, 30, 20, 27, 8, 614, DateTimeKind.Local).AddTicks(3276),
                            IdEmpleado = 1,
                            Sector = 2
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Reabastecimiento de bebidas",
                            FechaOperacion = new DateTime(2024, 9, 30, 20, 37, 8, 614, DateTimeKind.Local).AddTicks(3294),
                            IdEmpleado = 2,
                            Sector = 0
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Limpieza de utensilios",
                            FechaOperacion = new DateTime(2024, 9, 30, 20, 52, 8, 614, DateTimeKind.Local).AddTicks(3296),
                            IdEmpleado = 3,
                            Sector = 2
                        },
                        new
                        {
                            Id = 4,
                            Descripcion = "Atención al cliente",
                            FechaOperacion = new DateTime(2024, 9, 30, 20, 57, 8, 614, DateTimeKind.Local).AddTicks(3298),
                            IdEmpleado = 4,
                            Sector = 1
                        });
                });

            modelBuilder.Entity("Entities.Pedidos", b =>
                {
                    b.Property<int>("IdPedidos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPedidos"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("EstadoPedido")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaFinalizacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdComandas")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TiempoEstimadoFinalizacion")
                        .HasColumnType("datetime2");

                    b.HasKey("IdPedidos");

                    b.HasIndex("IdComandas");

                    b.HasIndex("IdProducto");

                    b.ToTable("Pedidos");

                    b.HasData(
                        new
                        {
                            IdPedidos = 1,
                            Cantidad = 2,
                            EstadoPedido = 2,
                            FechaCreacion = new DateTime(2024, 9, 30, 20, 57, 8, 614, DateTimeKind.Local).AddTicks(3411),
                            FechaFinalizacion = new DateTime(2024, 9, 30, 21, 12, 8, 614, DateTimeKind.Local).AddTicks(3411),
                            IdComandas = 1,
                            IdProducto = 1,
                            TiempoEstimadoFinalizacion = new DateTime(2024, 9, 30, 21, 17, 8, 614, DateTimeKind.Local).AddTicks(3415)
                        },
                        new
                        {
                            IdPedidos = 2,
                            Cantidad = 1,
                            EstadoPedido = 1,
                            FechaCreacion = new DateTime(2024, 9, 30, 20, 57, 8, 614, DateTimeKind.Local).AddTicks(3417),
                            FechaFinalizacion = new DateTime(2024, 9, 30, 21, 7, 8, 614, DateTimeKind.Local).AddTicks(3418),
                            IdComandas = 2,
                            IdProducto = 2,
                            TiempoEstimadoFinalizacion = new DateTime(2024, 9, 30, 21, 12, 8, 614, DateTimeKind.Local).AddTicks(3419)
                        },
                        new
                        {
                            IdPedidos = 3,
                            Cantidad = 3,
                            EstadoPedido = 0,
                            FechaCreacion = new DateTime(2024, 9, 30, 20, 57, 8, 614, DateTimeKind.Local).AddTicks(3421),
                            FechaFinalizacion = new DateTime(2024, 9, 30, 21, 2, 8, 614, DateTimeKind.Local).AddTicks(3422),
                            IdComandas = 3,
                            IdProducto = 3,
                            TiempoEstimadoFinalizacion = new DateTime(2024, 9, 30, 21, 7, 8, 614, DateTimeKind.Local).AddTicks(3423)
                        },
                        new
                        {
                            IdPedidos = 4,
                            Cantidad = 2,
                            EstadoPedido = 4,
                            FechaCreacion = new DateTime(2024, 9, 30, 20, 57, 8, 614, DateTimeKind.Local).AddTicks(3425),
                            FechaFinalizacion = new DateTime(2024, 9, 30, 21, 22, 8, 614, DateTimeKind.Local).AddTicks(3425),
                            IdComandas = 4,
                            IdProducto = 4,
                            TiempoEstimadoFinalizacion = new DateTime(2024, 9, 30, 21, 27, 8, 614, DateTimeKind.Local).AddTicks(3426)
                        },
                        new
                        {
                            IdPedidos = 5,
                            Cantidad = 1,
                            EstadoPedido = 3,
                            FechaCreacion = new DateTime(2024, 9, 30, 20, 57, 8, 614, DateTimeKind.Local).AddTicks(3428),
                            FechaFinalizacion = new DateTime(2024, 9, 30, 21, 27, 8, 614, DateTimeKind.Local).AddTicks(3429),
                            IdComandas = 5,
                            IdProducto = 5,
                            TiempoEstimadoFinalizacion = new DateTime(2024, 9, 30, 21, 32, 8, 614, DateTimeKind.Local).AddTicks(3430)
                        });
                });

            modelBuilder.Entity("Entities.Productos", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<int>("Sector")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("IdProducto");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            IdProducto = 1,
                            Descripcion = "Pizza Margherita",
                            Precio = 120,
                            Sector = 2,
                            Stock = 10
                        },
                        new
                        {
                            IdProducto = 2,
                            Descripcion = "Cerveza Artesanal",
                            Precio = 80,
                            Sector = 0,
                            Stock = 20
                        },
                        new
                        {
                            IdProducto = 3,
                            Descripcion = "Ensalada César",
                            Precio = 90,
                            Sector = 2,
                            Stock = 15
                        },
                        new
                        {
                            IdProducto = 4,
                            Descripcion = "Pasta al Pesto",
                            Precio = 150,
                            Sector = 2,
                            Stock = 12
                        },
                        new
                        {
                            IdProducto = 5,
                            Descripcion = "Refresco",
                            Precio = 50,
                            Sector = 1,
                            Stock = 30
                        });
                });

            modelBuilder.Entity("Entities.Comandas", b =>
                {
                    b.HasOne("Entities.Mesas", "Mesa")
                        .WithMany()
                        .HasForeignKey("IdMesa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mesa");
                });

            modelBuilder.Entity("Entities.LogInEmpleado", b =>
                {
                    b.HasOne("Entities.Empleados", "Empleado")
                        .WithMany()
                        .HasForeignKey("IdEmpleado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Entities.OperacionesEmpleados", b =>
                {
                    b.HasOne("Entities.Empleados", "Empleado")
                        .WithMany()
                        .HasForeignKey("IdEmpleado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Entities.Pedidos", b =>
                {
                    b.HasOne("Entities.Comandas", "IdComandaNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdComandas")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Productos", "IdProductoNavigation")
                        .WithMany()
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdComandaNavigation");

                    b.Navigation("IdProductoNavigation");
                });

            modelBuilder.Entity("Entities.Comandas", b =>
                {
                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
