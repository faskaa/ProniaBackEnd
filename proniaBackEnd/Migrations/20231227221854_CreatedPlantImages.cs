using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proniaBackEnd.Migrations
{
    public partial class CreatedPlantImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlantImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: true),
                    PlantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlantImages_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlantImages_PlantId",
                table: "PlantImages",
                column: "PlantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlantImages");
        }
    }
}
