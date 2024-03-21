using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scola.Migrations
{
    /// <inheritdoc />
    public partial class Ajuste_entities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EscolaId",
                table: "Matricula",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EscolaId",
                table: "Matricula");
        }
    }
}
