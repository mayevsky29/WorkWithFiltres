using Microsoft.EntityFrameworkCore.Migrations;

namespace AddFiltrsInMagazine.Migrations
{
    public partial class AddtblFilterNameGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblFilterNameGroups",
                columns: table => new
                {
                    FilterNameId = table.Column<int>(nullable: false),
                    FilterValueId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFilterNameGroups", x => new { x.FilterValueId, x.FilterNameId });
                    table.ForeignKey(
                        name: "FK_tblFilterNameGroups_tblFilterNames_FilterNameId",
                        column: x => x.FilterNameId,
                        principalTable: "tblFilterNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblFilterNameGroups_tblFilterValues_FilterValueId",
                        column: x => x.FilterValueId,
                        principalTable: "tblFilterValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblFilterNameGroups_FilterNameId",
                table: "tblFilterNameGroups",
                column: "FilterNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblFilterNameGroups");
        }
    }
}
