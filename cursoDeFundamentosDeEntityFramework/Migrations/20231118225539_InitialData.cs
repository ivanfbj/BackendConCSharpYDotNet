using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cursoDeFundamentosDeEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[,]
                {
                    { new Guid("e4cb45cb-a7e3-472f-b127-5ac4d5861e02"), null, "Actividades personales", 50 },
                    { new Guid("e4cb45cb-a7e3-472f-b127-5ac4d5861ee8"), null, "Actividades pendientes", 20 }
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "PrioridadTarea", "Titulo" },
                values: new object[,]
                {
                    { new Guid("e4cb45cb-a7e3-472f-b127-5ac4d5861e10"), new Guid("e4cb45cb-a7e3-472f-b127-5ac4d5861ee8"), null, new DateTime(2023, 11, 18, 17, 55, 39, 128, DateTimeKind.Local).AddTicks(9944), 1, "Pago de servicios publicos" },
                    { new Guid("e4cb45cb-a7e3-472f-b127-5ac4d5861e11"), new Guid("e4cb45cb-a7e3-472f-b127-5ac4d5861e02"), null, new DateTime(2023, 11, 18, 17, 55, 39, 128, DateTimeKind.Local).AddTicks(9965), 0, "Terminar de ver pelicula en Netflix" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("e4cb45cb-a7e3-472f-b127-5ac4d5861e10"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("e4cb45cb-a7e3-472f-b127-5ac4d5861e11"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("e4cb45cb-a7e3-472f-b127-5ac4d5861e02"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("e4cb45cb-a7e3-472f-b127-5ac4d5861ee8"));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
