using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaOperacion",
                value: new DateTime(2024, 12, 9, 18, 48, 55, 246, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaOperacion",
                value: new DateTime(2024, 12, 9, 18, 58, 55, 246, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaOperacion",
                value: new DateTime(2024, 12, 9, 19, 13, 55, 246, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaOperacion",
                value: new DateTime(2024, 12, 9, 19, 18, 55, 246, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 12, 9, 19, 18, 55, 246, DateTimeKind.Local).AddTicks(4983), new DateTime(2024, 12, 9, 19, 33, 55, 246, DateTimeKind.Local).AddTicks(4983), new DateTime(2024, 12, 9, 19, 38, 55, 246, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 2,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 12, 9, 19, 18, 55, 246, DateTimeKind.Local).AddTicks(4988), new DateTime(2024, 12, 9, 19, 28, 55, 246, DateTimeKind.Local).AddTicks(4989), new DateTime(2024, 12, 9, 19, 33, 55, 246, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 3,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 12, 9, 19, 18, 55, 246, DateTimeKind.Local).AddTicks(4991), new DateTime(2024, 12, 9, 19, 23, 55, 246, DateTimeKind.Local).AddTicks(4992), new DateTime(2024, 12, 9, 19, 28, 55, 246, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 4,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 12, 9, 19, 18, 55, 246, DateTimeKind.Local).AddTicks(4994), new DateTime(2024, 12, 9, 19, 43, 55, 246, DateTimeKind.Local).AddTicks(4995), new DateTime(2024, 12, 9, 19, 48, 55, 246, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 5,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 12, 9, 19, 18, 55, 246, DateTimeKind.Local).AddTicks(4998), new DateTime(2024, 12, 9, 19, 48, 55, 246, DateTimeKind.Local).AddTicks(4998), new DateTime(2024, 12, 9, 19, 53, 55, 246, DateTimeKind.Local).AddTicks(4999) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
