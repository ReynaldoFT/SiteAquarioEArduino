using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteAquario.Migrations
{
    public partial class Inicialcriacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ValoresSensor",
                columns: table => new
                {
                    ValoresSensorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ph = table.Column<double>(type: "float", nullable: false),
                    Temperatura = table.Column<double>(type: "float", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValoresSensor", x => x.ValoresSensorID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ValoresSensor");
        }
    }
}
