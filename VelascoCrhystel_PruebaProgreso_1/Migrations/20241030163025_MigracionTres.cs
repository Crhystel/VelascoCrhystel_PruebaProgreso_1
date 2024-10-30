using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VelascoCrhystel_PruebaProgreso_1.Migrations
{
    /// <inheritdoc />
    public partial class MigracionTres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Promedio",
                table: "Velasco",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Promedio",
                table: "Velasco",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
