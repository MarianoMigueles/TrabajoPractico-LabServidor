using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class migracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 1,
                columns: new[] { "Password", "Usuario" },
                values: new object[] { "password", "cerveceros" });

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 2,
                columns: new[] { "Password", "Sector", "Usuario" },
                values: new object[] { "password", 2, "cocinero" });

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 3,
                columns: new[] { "Password", "Sector", "Usuario" },
                values: new object[] { "password", 4, "mozos" });

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 4,
                columns: new[] { "Password", "Sector", "Usuario" },
                values: new object[] { "password", 1, "bartender" });

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 5,
                columns: new[] { "Password", "Sector", "Usuario" },
                values: new object[] { "password", 5, "socios" });

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 6,
                columns: new[] { "Password", "Sector", "Usuario" },
                values: new object[] { "password", 5, "admin" });

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaOperacion",
                value: new DateTime(2024, 12, 8, 21, 7, 34, 765, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaOperacion",
                value: new DateTime(2024, 12, 8, 21, 17, 34, 765, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaOperacion",
                value: new DateTime(2024, 12, 8, 21, 32, 34, 765, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaOperacion",
                value: new DateTime(2024, 12, 8, 21, 37, 34, 765, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 37, 34, 765, DateTimeKind.Local).AddTicks(261), new DateTime(2024, 12, 8, 21, 52, 34, 765, DateTimeKind.Local).AddTicks(262), new DateTime(2024, 12, 8, 21, 57, 34, 765, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 2,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 37, 34, 765, DateTimeKind.Local).AddTicks(268), new DateTime(2024, 12, 8, 21, 47, 34, 765, DateTimeKind.Local).AddTicks(268), new DateTime(2024, 12, 8, 21, 52, 34, 765, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 3,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 37, 34, 765, DateTimeKind.Local).AddTicks(271), new DateTime(2024, 12, 8, 21, 42, 34, 765, DateTimeKind.Local).AddTicks(271), new DateTime(2024, 12, 8, 21, 47, 34, 765, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 4,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 37, 34, 765, DateTimeKind.Local).AddTicks(274), new DateTime(2024, 12, 8, 22, 2, 34, 765, DateTimeKind.Local).AddTicks(274), new DateTime(2024, 12, 8, 22, 7, 34, 765, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 5,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 37, 34, 765, DateTimeKind.Local).AddTicks(277), new DateTime(2024, 12, 8, 22, 7, 34, 765, DateTimeKind.Local).AddTicks(278), new DateTime(2024, 12, 8, 22, 12, 34, 765, DateTimeKind.Local).AddTicks(278) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 1,
                columns: new[] { "Password", "Usuario" },
                values: new object[] { "password1", "atorres" });

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 2,
                columns: new[] { "Password", "Sector", "Usuario" },
                values: new object[] { "password2", 0, "lfernandez" });

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 3,
                columns: new[] { "Password", "Sector", "Usuario" },
                values: new object[] { "password3", 0, "pruiz" });

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 4,
                columns: new[] { "Password", "Sector", "Usuario" },
                values: new object[] { "password4", 0, "mdiaz" });

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 5,
                columns: new[] { "Password", "Sector", "Usuario" },
                values: new object[] { "password5", 0, "smartinez" });

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "IdEmpleados",
                keyValue: 6,
                columns: new[] { "Password", "Sector", "Usuario" },
                values: new object[] { "password6", 0, "eperez" });

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
    }
}
