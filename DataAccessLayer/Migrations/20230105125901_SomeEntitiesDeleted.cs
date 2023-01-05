using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class SomeEntitiesDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubtitleAppearances_Backgrounds_BackgroundId",
                table: "SubtitleAppearances");

            migrationBuilder.DropForeignKey(
                name: "FK_SubtitleAppearances_Windows_WindowId",
                table: "SubtitleAppearances");

            migrationBuilder.DropTable(
                name: "Backgrounds");

            migrationBuilder.DropTable(
                name: "Windows");

            migrationBuilder.DropIndex(
                name: "IX_SubtitleAppearances_BackgroundId",
                table: "SubtitleAppearances");

            migrationBuilder.DropIndex(
                name: "IX_SubtitleAppearances_WindowId",
                table: "SubtitleAppearances");

            migrationBuilder.RenameColumn(
                name: "WindowId",
                table: "SubtitleAppearances",
                newName: "WindowColorId");

            migrationBuilder.RenameColumn(
                name: "BackgroundId",
                table: "SubtitleAppearances",
                newName: "BackgroundColorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WindowColorId",
                table: "SubtitleAppearances",
                newName: "WindowId");

            migrationBuilder.RenameColumn(
                name: "BackgroundColorId",
                table: "SubtitleAppearances",
                newName: "BackgroundId");

            migrationBuilder.CreateTable(
                name: "Backgrounds",
                columns: table => new
                {
                    BackgroundId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backgrounds", x => x.BackgroundId);
                    table.ForeignKey(
                        name: "FK_Backgrounds_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Windows",
                columns: table => new
                {
                    WindowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Windows", x => x.WindowId);
                    table.ForeignKey(
                        name: "FK_Windows_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubtitleAppearances_BackgroundId",
                table: "SubtitleAppearances",
                column: "BackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_SubtitleAppearances_WindowId",
                table: "SubtitleAppearances",
                column: "WindowId");

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_ColorId",
                table: "Backgrounds",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Windows_ColorId",
                table: "Windows",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubtitleAppearances_Backgrounds_BackgroundId",
                table: "SubtitleAppearances",
                column: "BackgroundId",
                principalTable: "Backgrounds",
                principalColumn: "BackgroundId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubtitleAppearances_Windows_WindowId",
                table: "SubtitleAppearances",
                column: "WindowId",
                principalTable: "Windows",
                principalColumn: "WindowId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
