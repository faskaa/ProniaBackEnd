using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proniaBackEnd.Migrations
{
    public partial class CreatedCategoryAndPlantTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatagoryId",
                table: "PlantCategories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatagoryId",
                table: "PlantCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
