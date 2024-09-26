using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class primeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comandas",
                columns: table => new
                {
                    IdComandas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMesa = table.Column<int>(type: "int", nullable: false),
                    NombreCliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comandas", x => x.IdComandas);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    IdEmpleados = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passsword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sector = table.Column<int>(type: "int", nullable: false),
                    Rol = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.IdEmpleados);
                });

            migrationBuilder.CreateTable(
                name: "Mesas",
                columns: table => new
                {
                    IdMesa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoMesa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesas", x => x.IdMesa);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false),
                    Sector = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProducto);
                });

            migrationBuilder.CreateTable(
                name: "LogIns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogIns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogIns_Empleados_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "IdEmpleados",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Operaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    Sector = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaOperacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operaciones_Empleados_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "IdEmpleados",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    IdPedidos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdComandas = table.Column<int>(type: "int", nullable: false),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TiempoEstimadoFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoPedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.IdPedidos);
                    table.ForeignKey(
                        name: "FK_Pedidos_Comandas_IdComandas",
                        column: x => x.IdComandas,
                        principalTable: "Comandas",
                        principalColumn: "IdComandas",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Productos_IdProducto",
                        column: x => x.IdProducto,
                        principalTable: "Productos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Comandas",
                columns: new[] { "IdComandas", "IdMesa", "NombreCliente" },
                values: new object[,]
                {
                    { 1, 1, "Mariano Joel" },
                    { 2, 2, "Sheila Gómez" },
                    { 3, 3, "Ian Migueles" },
                    { 4, 4, "Lucía Pérez" },
                    { 5, 5, "Carlos López" }
                });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "IdEmpleados", "Estado", "Nombre", "Passsword", "Rol", "Sector", "Usuario" },
                values: new object[,]
                {
                    { 1, 0, "Ana Torres", "password1", 0, 0, "atorres" },
                    { 2, 0, "Luis Fernández", "password2", 0, 0, "lfernandez" },
                    { 3, 1, "Pedro Ruiz", "password3", 0, 0, "pruiz" },
                    { 4, 0, "Marta Díaz", "password4", 0, 0, "mdiaz" },
                    { 5, 2, "Sofia Martínez", "password5", 0, 0, "smartinez" }
                });

            migrationBuilder.InsertData(
                table: "Mesas",
                columns: new[] { "IdMesa", "EstadoMesa", "Nombre" },
                values: new object[,]
                {
                    { 1, 0, "Mesa 1" },
                    { 2, 1, "Mesa 2" },
                    { 3, 2, "Mesa 3" },
                    { 4, 3, "Mesa 4" },
                    { 5, 0, "Mesa 5" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "IdProducto", "Descripcion", "Precio", "Sector", "Stock" },
                values: new object[,]
                {
                    { 1, "Pizza Margherita", 120, 2, 10 },
                    { 2, "Cerveza Artesanal", 80, 0, 20 },
                    { 3, "Ensalada César", 90, 2, 15 },
                    { 4, "Pasta al Pesto", 150, 2, 12 },
                    { 5, "Refresco", 50, 1, 30 }
                });

            migrationBuilder.InsertData(
                table: "LogIns",
                columns: new[] { "Id", "FechaIngreso", "IdEmpleado" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });

            migrationBuilder.InsertData(
                table: "Operaciones",
                columns: new[] { "Id", "Descripcion", "FechaOperacion", "IdEmpleado", "Sector" },
                values: new object[,]
                {
                    { 1, "Preparación de platos", new DateTime(2024, 9, 26, 15, 26, 37, 761, DateTimeKind.Local).AddTicks(5134), 1, 2 },
                    { 2, "Reabastecimiento de bebidas", new DateTime(2024, 9, 26, 15, 36, 37, 761, DateTimeKind.Local).AddTicks(5148), 2, 0 },
                    { 3, "Limpieza de utensilios", new DateTime(2024, 9, 26, 15, 51, 37, 761, DateTimeKind.Local).AddTicks(5150), 3, 2 },
                    { 4, "Atención al cliente", new DateTime(2024, 9, 26, 15, 56, 37, 761, DateTimeKind.Local).AddTicks(5151), 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "Pedidos",
                columns: new[] { "IdPedidos", "Cantidad", "EstadoPedido", "FechaCreacion", "FechaFinalizacion", "IdComandas", "IdProducto", "TiempoEstimadoFinalizacion" },
                values: new object[,]
                {
                    { 1, 2, 2, new DateTime(2024, 9, 26, 15, 56, 37, 761, DateTimeKind.Local).AddTicks(5260), new DateTime(2024, 9, 26, 16, 11, 37, 761, DateTimeKind.Local).AddTicks(5261), 1, 1, new DateTime(2024, 9, 26, 16, 16, 37, 761, DateTimeKind.Local).AddTicks(5262) },
                    { 2, 1, 1, new DateTime(2024, 9, 26, 15, 56, 37, 761, DateTimeKind.Local).AddTicks(5265), new DateTime(2024, 9, 26, 16, 6, 37, 761, DateTimeKind.Local).AddTicks(5265), 2, 2, new DateTime(2024, 9, 26, 16, 11, 37, 761, DateTimeKind.Local).AddTicks(5266) },
                    { 3, 3, 0, new DateTime(2024, 9, 26, 15, 56, 37, 761, DateTimeKind.Local).AddTicks(5268), new DateTime(2024, 9, 26, 16, 1, 37, 761, DateTimeKind.Local).AddTicks(5268), 3, 3, new DateTime(2024, 9, 26, 16, 6, 37, 761, DateTimeKind.Local).AddTicks(5269) },
                    { 4, 2, 4, new DateTime(2024, 9, 26, 15, 56, 37, 761, DateTimeKind.Local).AddTicks(5271), new DateTime(2024, 9, 26, 16, 21, 37, 761, DateTimeKind.Local).AddTicks(5272), 4, 4, new DateTime(2024, 9, 26, 16, 26, 37, 761, DateTimeKind.Local).AddTicks(5272) },
                    { 5, 1, 3, new DateTime(2024, 9, 26, 15, 56, 37, 761, DateTimeKind.Local).AddTicks(5274), new DateTime(2024, 9, 26, 16, 26, 37, 761, DateTimeKind.Local).AddTicks(5275), 5, 5, new DateTime(2024, 9, 26, 16, 31, 37, 761, DateTimeKind.Local).AddTicks(5276) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LogIns_IdEmpleado",
                table: "LogIns",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Operaciones_IdEmpleado",
                table: "Operaciones",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_IdComandas",
                table: "Pedidos",
                column: "IdComandas");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_IdProducto",
                table: "Pedidos",
                column: "IdProducto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogIns");

            migrationBuilder.DropTable(
                name: "Mesas");

            migrationBuilder.DropTable(
                name: "Operaciones");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Comandas");

            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
