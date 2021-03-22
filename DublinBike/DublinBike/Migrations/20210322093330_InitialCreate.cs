using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DublinBike.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bike",
                columns: table => new
                {
                Id = table.Column<int>(type: "int", nullable: false)
                .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Number = table.Column<int>(type: "int", nullable: false),
                adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                latitude = table.Column<double>(type: "float", nullable: false),
                longitude = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                table.PrimaryKey("PK_Bike", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
            name: "Bike");
        }
    }
}
