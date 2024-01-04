using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proniaBackEnd.Migrations
{
    public partial class OrderColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Order",
                table: "Informations",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Informations");
        }
    }
}
