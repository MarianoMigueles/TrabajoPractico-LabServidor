using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class MyThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 1,
                column: "Rol",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 2,
                column: "Rol",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 3,
                columns: new[] { "Estado", "Rol" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 5,
                columns: new[] { "Estado", "Rol" },
                values: new object[] { 0, 4 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "IdEmpleados", "Estado", "Nombre", "Password", "Rol", "Sector", "Usuario" },
                values: new object[] { 6, 0, "Eduardo Perez", "password6", 5, 0, "eperez" });

            migrationBuilder.UpdateData(
                table: "Mesas",
                keyColumn: "IdMesa",
                keyValue: 1,
                column: "EstadoMesa",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Mesas",
                keyColumn: "IdMesa",
                keyValue: 2,
                column: "EstadoMesa",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Mesas",
                keyColumn: "IdMesa",
                keyValue: 3,
                column: "EstadoMesa",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Mesas",
                keyColumn: "IdMesa",
                keyValue: 4,
                column: "EstadoMesa",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Mesas",
                keyColumn: "IdMesa",
                keyValue: 5,
                column: "EstadoMesa",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaOperacion",
                value: new DateTime(2024, 9, 30, 20, 27, 8, 614, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaOperacion",
                value: new DateTime(2024, 9, 30, 20, 37, 8, 614, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaOperacion",
                value: new DateTime(2024, 9, 30, 20, 52, 8, 614, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaOperacion",
                value: new DateTime(2024, 9, 30, 20, 57, 8, 614, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 9, 30, 20, 57, 8, 614, DateTimeKind.Local).AddTicks(3411), new DateTime(2024, 9, 30, 21, 12, 8, 614, DateTimeKind.Local).AddTicks(3411), new DateTime(2024, 9, 30, 21, 17, 8, 614, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 2,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 9, 30, 20, 57, 8, 614, DateTimeKind.Local).AddTicks(3417), new DateTime(2024, 9, 30, 21, 7, 8, 614, DateTimeKind.Local).AddTicks(3418), new DateTime(2024, 9, 30, 21, 12, 8, 614, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 3,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 9, 30, 20, 57, 8, 614, DateTimeKind.Local).AddTicks(3421), new DateTime(2024, 9, 30, 21, 2, 8, 614, DateTimeKind.Local).AddTicks(3422), new DateTime(2024, 9, 30, 21, 7, 8, 614, DateTimeKind.Local).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 4,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 9, 30, 20, 57, 8, 614, DateTimeKind.Local).AddTicks(3425), new DateTime(2024, 9, 30, 21, 22, 8, 614, DateTimeKind.Local).AddTicks(3425), new DateTime(2024, 9, 30, 21, 27, 8, 614, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 5,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 9, 30, 20, 57, 8, 614, DateTimeKind.Local).AddTicks(3428), new DateTime(2024, 9, 30, 21, 27, 8, 614, DateTimeKind.Local).AddTicks(3429), new DateTime(2024, 9, 30, 21, 32, 8, 614, DateTimeKind.Local).AddTicks(3430) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 1,
                column: "Rol",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 2,
                column: "Rol",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 3,
                columns: new[] { "Estado", "Rol" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 5,
                columns: new[] { "Estado", "Rol" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "Mesas",
                keyColumn: "IdMesa",
                keyValue: 1,
                column: "EstadoMesa",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Mesas",
                keyColumn: "IdMesa",
                keyValue: 2,
                column: "EstadoMesa",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Mesas",
                keyColumn: "IdMesa",
                keyValue: 3,
                column: "EstadoMesa",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Mesas",
                keyColumn: "IdMesa",
                keyValue: 4,
                column: "EstadoMesa",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Mesas",
                keyColumn: "IdMesa",
                keyValue: 5,
                column: "EstadoMesa",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaOperacion",
                value: new DateTime(2024, 9, 29, 18, 8, 16, 634, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaOperacion",
                value: new DateTime(2024, 9, 29, 18, 18, 16, 634, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaOperacion",
                value: new DateTime(2024, 9, 29, 18, 33, 16, 634, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaOperacion",
                value: new DateTime(2024, 9, 29, 18, 38, 16, 634, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 9, 29, 18, 38, 16, 634, DateTimeKind.Local).AddTicks(5510), new DateTime(2024, 9, 29, 18, 53, 16, 634, DateTimeKind.Local).AddTicks(5511), new DateTime(2024, 9, 29, 18, 58, 16, 634, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 2,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 9, 29, 18, 38, 16, 634, DateTimeKind.Local).AddTicks(5516), new DateTime(2024, 9, 29, 18, 48, 16, 634, DateTimeKind.Local).AddTicks(5517), new DateTime(2024, 9, 29, 18, 53, 16, 634, DateTimeKind.Local).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 3,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 9, 29, 18, 38, 16, 634, DateTimeKind.Local).AddTicks(5519), new DateTime(2024, 9, 29, 18, 43, 16, 634, DateTimeKind.Local).AddTicks(5520), new DateTime(2024, 9, 29, 18, 48, 16, 634, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 4,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 9, 29, 18, 38, 16, 634, DateTimeKind.Local).AddTicks(5522), new DateTime(2024, 9, 29, 19, 3, 16, 634, DateTimeKind.Local).AddTicks(5523), new DateTime(2024, 9, 29, 19, 8, 16, 634, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 5,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 9, 29, 18, 38, 16, 634, DateTimeKind.Local).AddTicks(5525), new DateTime(2024, 9, 29, 19, 8, 16, 634, DateTimeKind.Local).AddTicks(5526), new DateTime(2024, 9, 29, 19, 13, 16, 634, DateTimeKind.Local).AddTicks(5527) });
        }
    }
}
