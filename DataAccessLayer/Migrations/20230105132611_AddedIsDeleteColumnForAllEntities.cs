using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsDeleteColumnForAllEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Videos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "VideoLanguages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Types",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "TypeContents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Titles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "TextSizes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "SubtitleAppearances",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Styles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "StyleContents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Shadows",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "ProfileVideoWatchings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "ProfileVideoRatings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Profiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "ProfilePlaybackSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "ProfileContents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "ProfileCommunicationSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PlaybackSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Packets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaturityRatings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Languages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "InvoiceDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Genres",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "GenreContents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Fonts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "CreditCards",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Contents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "ContentCastTitles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "CommunicationSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Colors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "CastTitles",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "VideoLanguages");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "TypeContents");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "TextSizes");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "SubtitleAppearances");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Styles");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "StyleContents");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Shadows");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "ProfileVideoWatchings");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "ProfileVideoRatings");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "ProfilePlaybackSettings");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "ProfileContents");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "ProfileCommunicationSettings");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PlaybackSettings");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaturityRatings");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "InvoiceDetails");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "GenreContents");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Fonts");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "CreditCards");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "ContentCastTitles");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "CommunicationSettings");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "CastTitles");
        }
    }
}
