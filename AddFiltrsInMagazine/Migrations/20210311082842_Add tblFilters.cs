using Microsoft.EntityFrameworkCore.Migrations;

namespace AddFiltrsInMagazine.Migrations
{
    public partial class AddtblFilters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblFilters",
                columns: table => new
                {
                    FilterNameId = table.Column<int>(nullable: false),
                    FilterValueId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFilters", x => new { x.ProductId, x.FilterValueId, x.FilterNameId });
                    table.ForeignKey(
                        name: "FK_tblFilters_tblFilterNames_FilterNameId",
                        column: x => x.FilterNameId,
                        principalTable: "tblFilterNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblFilters_tblFilterValues_FilterValueId",
                        column: x => x.FilterValueId,
                        principalTable: "tblFilterValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblFilters_tblProducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tblProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblFilters_tblFilterNameGroups_FilterValueId_FilterNameId",
                        columns: x => new { x.FilterValueId, x.FilterNameId },
                        principalTable: "tblFilterNameGroups",
                        principalColumns: new[] { "FilterValueId", "FilterNameId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblFilters_FilterNameId",
                table: "tblFilters",
                column: "FilterNameId");

            migrationBuilder.CreateIndex(
                name: "IX_tblFilters_FilterValueId_FilterNameId",
                table: "tblFilters",
                columns: new[] { "FilterValueId", "FilterNameId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblFilters");
        }
    }
}
