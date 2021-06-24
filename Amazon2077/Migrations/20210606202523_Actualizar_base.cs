using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Amazon2077.Migrations
{
    public partial class Actualizar_base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Usuarios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Usuarios");
        }
    }
}
