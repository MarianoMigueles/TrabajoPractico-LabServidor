using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class MySecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Empleados",
                newName: "Password");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TiempoEstimadoFinalizacion",
                table: "Pedidos",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaFinalizacion",
                table: "Pedidos",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

            migrationBuilder.CreateIndex(
                name: "IX_Comandas_IdMesa",
                table: "Comandas",
                column: "IdMesa");

            migrationBuilder.AddForeignKey(
                name: "FK_Comandas_Mesas_IdMesa",
                table: "Comandas",
                column: "IdMesa",
                principalTable: "Mesas",
                principalColumn: "IdMesa",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comandas_Mesas_IdMesa",
                table: "Comandas");

            migrationBuilder.DropIndex(
                name: "IX_Comandas_IdMesa",
                table: "Comandas");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Empleados",
                newName: "Password");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TiempoEstimadoFinalizacion",
                table: "Pedidos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaFinalizacion",
                table: "Pedidos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaOperacion",
                value: new DateTime(2024, 9, 26, 15, 26, 37, 761, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaOperacion",
                value: new DateTime(2024, 9, 26, 15, 36, 37, 761, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaOperacion",
                value: new DateTime(2024, 9, 26, 15, 51, 37, 761, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaOperacion",
                value: new DateTime(2024, 9, 26, 15, 56, 37, 761, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 56, 37, 761, DateTimeKind.Local).AddTicks(5260), new DateTime(2024, 9, 26, 16, 11, 37, 761, DateTimeKind.Local).AddTicks(5261), new DateTime(2024, 9, 26, 16, 16, 37, 761, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 2,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 56, 37, 761, DateTimeKind.Local).AddTicks(5265), new DateTime(2024, 9, 26, 16, 6, 37, 761, DateTimeKind.Local).AddTicks(5265), new DateTime(2024, 9, 26, 16, 11, 37, 761, DateTimeKind.Local).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 3,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 56, 37, 761, DateTimeKind.Local).AddTicks(5268), new DateTime(2024, 9, 26, 16, 1, 37, 761, DateTimeKind.Local).AddTicks(5268), new DateTime(2024, 9, 26, 16, 6, 37, 761, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 4,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 56, 37, 761, DateTimeKind.Local).AddTicks(5271), new DateTime(2024, 9, 26, 16, 21, 37, 761, DateTimeKind.Local).AddTicks(5272), new DateTime(2024, 9, 26, 16, 26, 37, 761, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "IdPedidos",
                keyValue: 5,
                columns: new[] { "FechaCreacion", "FechaFinalizacion", "TiempoEstimadoFinalizacion" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 56, 37, 761, DateTimeKind.Local).AddTicks(5274), new DateTime(2024, 9, 26, 16, 26, 37, 761, DateTimeKind.Local).AddTicks(5275), new DateTime(2024, 9, 26, 16, 31, 37, 761, DateTimeKind.Local).AddTicks(5276) });
        }
    }
}
