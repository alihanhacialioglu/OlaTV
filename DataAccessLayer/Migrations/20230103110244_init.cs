using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Casts",
                columns: table => new
                {
                    CastId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CastNameSurname = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casts", x => x.CastId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "CommunicationSettings",
                columns: table => new
                {
                    CommunicationSettingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommunicationSettingName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CommunicationSettingExplanation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationSettings", x => x.CommunicationSettingId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "MaturityRatings",
                columns: table => new
                {
                    MaturityRatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MaturityExplanation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaturityRatings", x => x.MaturityRatingId);
                });

            migrationBuilder.CreateTable(
                name: "Packets",
                columns: table => new
                {
                    PacketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacketName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    PacketPrice = table.Column<float>(type: "real", nullable: false),
                    PacketContentQuality = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PacketExplanation = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packets", x => x.PacketId);
                });

            migrationBuilder.CreateTable(
                name: "PlaybackSettings",
                columns: table => new
                {
                    PlaybackSettingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaybackSettingName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PlaybackSettingExplanation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaybackSettings", x => x.PlaybackSettingId);
                });

            migrationBuilder.CreateTable(
                name: "Styles",
                columns: table => new
                {
                    StyleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StyleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Styles", x => x.StyleId);
                });

            migrationBuilder.CreateTable(
                name: "TextSizes",
                columns: table => new
                {
                    TextSizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextSizeName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextSizes", x => x.TextSizeId);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    TitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.TitleId);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.TypeId);
                });

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
                name: "Fonts",
                columns: table => new
                {
                    FontId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FontName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fonts", x => x.FontId);
                    table.ForeignKey(
                        name: "FK_Fonts_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shadows",
                columns: table => new
                {
                    ShadowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShadowName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shadows", x => x.ShadowId);
                    table.ForeignKey(
                        name: "FK_Shadows_Colors_ColorId",
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

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    ContentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MaturityRatingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.ContentId);
                    table.ForeignKey(
                        name: "FK_Contents_MaturityRatings_MaturityRatingId",
                        column: x => x.MaturityRatingId,
                        principalTable: "MaturityRatings",
                        principalColumn: "MaturityRatingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DateOfRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccessPin = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    PacketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Packets_PacketId",
                        column: x => x.PacketId,
                        principalTable: "Packets",
                        principalColumn: "PacketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CastTitles",
                columns: table => new
                {
                    CastTitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CastId = table.Column<int>(type: "int", nullable: false),
                    TitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastTitles", x => x.CastTitleId);
                    table.ForeignKey(
                        name: "FK_CastTitles_Casts_CastId",
                        column: x => x.CastId,
                        principalTable: "Casts",
                        principalColumn: "CastId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CastTitles_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "TitleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubtitleAppearances",
                columns: table => new
                {
                    SubtitleAppearanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WindowId = table.Column<int>(type: "int", nullable: false),
                    BackgroundId = table.Column<int>(type: "int", nullable: false),
                    FontId = table.Column<int>(type: "int", nullable: false),
                    ShadowId = table.Column<int>(type: "int", nullable: false),
                    TextSizeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubtitleAppearances", x => x.SubtitleAppearanceId);
                    table.ForeignKey(
                        name: "FK_SubtitleAppearances_Backgrounds_BackgroundId",
                        column: x => x.BackgroundId,
                        principalTable: "Backgrounds",
                        principalColumn: "BackgroundId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SubtitleAppearances_Fonts_FontId",
                        column: x => x.FontId,
                        principalTable: "Fonts",
                        principalColumn: "FontId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SubtitleAppearances_Shadows_ShadowId",
                        column: x => x.ShadowId,
                        principalTable: "Shadows",
                        principalColumn: "ShadowId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SubtitleAppearances_TextSizes_TextSizeId",
                        column: x => x.TextSizeId,
                        principalTable: "TextSizes",
                        principalColumn: "TextSizeId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SubtitleAppearances_Windows_WindowId",
                        column: x => x.WindowId,
                        principalTable: "Windows",
                        principalColumn: "WindowId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "GenreContents",
                columns: table => new
                {
                    GenreContentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    ContentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreContents", x => x.GenreContentId);
                    table.ForeignKey(
                        name: "FK_GenreContents_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "ContentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreContents_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StyleContents",
                columns: table => new
                {
                    StyleContentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StyleId = table.Column<int>(type: "int", nullable: false),
                    ContentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StyleContents", x => x.StyleContentId);
                    table.ForeignKey(
                        name: "FK_StyleContents_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "ContentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StyleContents_Styles_StyleId",
                        column: x => x.StyleId,
                        principalTable: "Styles",
                        principalColumn: "StyleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TypeContents",
                columns: table => new
                {
                    TypeContentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeContents", x => x.TypeContentId);
                    table.ForeignKey(
                        name: "FK_TypeContents_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "ContentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypeContents_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    VideoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeasonNo = table.Column<byte>(type: "tinyint", nullable: false),
                    EpisodeNo = table.Column<byte>(type: "tinyint", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    ContentId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.VideoId);
                    table.ForeignKey(
                        name: "FK_Videos_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Videos_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "ContentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Videos_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    CreditCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreditCardHolder = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CreditCardNo = table.Column<int>(type: "int", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cvv = table.Column<byte>(type: "tinyint", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.CreditCardId);
                    table.ForeignKey(
                        name: "FK_CreditCards_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentCastTitles",
                columns: table => new
                {
                    ContentCastTitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CastTitleId = table.Column<int>(type: "int", nullable: false),
                    ContentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentCastTitles", x => x.ContentCastTitleId);
                    table.ForeignKey(
                        name: "FK_ContentCastTitles_CastTitles_CastTitleId",
                        column: x => x.CastTitleId,
                        principalTable: "CastTitles",
                        principalColumn: "CastTitleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentCastTitles_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "ContentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    ProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ProfilePin = table.Column<int>(type: "int", nullable: false),
                    IsAnimationTv = table.Column<bool>(type: "bit", nullable: false),
                    IsMarketingApproval = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    MaturityRatingId = table.Column<int>(type: "int", nullable: false),
                    SubtitleAppearanceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.ProfileId);
                    table.ForeignKey(
                        name: "FK_Profiles_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Profiles_MaturityRatings_MaturityRatingId",
                        column: x => x.MaturityRatingId,
                        principalTable: "MaturityRatings",
                        principalColumn: "MaturityRatingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Profiles_SubtitleAppearances_SubtitleAppearanceId",
                        column: x => x.SubtitleAppearanceId,
                        principalTable: "SubtitleAppearances",
                        principalColumn: "SubtitleAppearanceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Profiles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideoLanguages",
                columns: table => new
                {
                    VideoLanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoLanguages", x => x.VideoLanguageId);
                    table.ForeignKey(
                        name: "FK_VideoLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VideoLanguages_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "VideoId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetails",
                columns: table => new
                {
                    InvoiceDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<float>(type: "real", nullable: false),
                    InvoiceExplanation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreditCardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetails", x => x.InvoiceDetailId);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_CreditCards_CreditCardId",
                        column: x => x.CreditCardId,
                        principalTable: "CreditCards",
                        principalColumn: "CreditCardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfileCommunicationSettings",
                columns: table => new
                {
                    ProfileCommunicationSettingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileCommunicationSettingSelection = table.Column<bool>(type: "bit", nullable: false),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    CommunicationSettingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileCommunicationSettings", x => x.ProfileCommunicationSettingId);
                    table.ForeignKey(
                        name: "FK_ProfileCommunicationSettings_CommunicationSettings_CommunicationSettingId",
                        column: x => x.CommunicationSettingId,
                        principalTable: "CommunicationSettings",
                        principalColumn: "CommunicationSettingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfileCommunicationSettings_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfileContents",
                columns: table => new
                {
                    ProfileContentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    ContentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileContents", x => x.ProfileContentId);
                    table.ForeignKey(
                        name: "FK_ProfileContents_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "ContentId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProfileContents_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ProfilePlaybackSettings",
                columns: table => new
                {
                    ProfilePlaybackSettingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaybackPlaybackSelection = table.Column<bool>(type: "bit", nullable: false),
                    PlaybackSettingId = table.Column<int>(type: "int", nullable: false),
                    ProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilePlaybackSettings", x => x.ProfilePlaybackSettingId);
                    table.ForeignKey(
                        name: "FK_ProfilePlaybackSettings_PlaybackSettings_PlaybackSettingId",
                        column: x => x.PlaybackSettingId,
                        principalTable: "PlaybackSettings",
                        principalColumn: "PlaybackSettingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfilePlaybackSettings_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfileVideoRatings",
                columns: table => new
                {
                    ProfileVideoRatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileVideoRate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    VideoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileVideoRatings", x => x.ProfileVideoRatingId);
                    table.ForeignKey(
                        name: "FK_ProfileVideoRatings_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProfileVideoRatings_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "VideoId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ProfileVideoWatchings",
                columns: table => new
                {
                    ProfileVideoWatchingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileVideoDateOfWached = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    VideoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileVideoWatchings", x => x.ProfileVideoWatchingId);
                    table.ForeignKey(
                        name: "FK_ProfileVideoWatchings_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProfileVideoWatchings_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "VideoId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_ColorId",
                table: "Backgrounds",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_CastTitles_CastId",
                table: "CastTitles",
                column: "CastId");

            migrationBuilder.CreateIndex(
                name: "IX_CastTitles_TitleId",
                table: "CastTitles",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentCastTitles_CastTitleId",
                table: "ContentCastTitles",
                column: "CastTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentCastTitles_ContentId",
                table: "ContentCastTitles",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_MaturityRatingId",
                table: "Contents",
                column: "MaturityRatingId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditCards_UserId",
                table: "CreditCards",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Fonts_ColorId",
                table: "Fonts",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreContents_ContentId",
                table: "GenreContents",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreContents_GenreId",
                table: "GenreContents",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_CreditCardId",
                table: "InvoiceDetails",
                column: "CreditCardId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileCommunicationSettings_CommunicationSettingId",
                table: "ProfileCommunicationSettings",
                column: "CommunicationSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileCommunicationSettings_ProfileId",
                table: "ProfileCommunicationSettings",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileContents_ContentId",
                table: "ProfileContents",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileContents_ProfileId",
                table: "ProfileContents",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfilePlaybackSettings_PlaybackSettingId",
                table: "ProfilePlaybackSettings",
                column: "PlaybackSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfilePlaybackSettings_ProfileId",
                table: "ProfilePlaybackSettings",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_LanguageId",
                table: "Profiles",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_MaturityRatingId",
                table: "Profiles",
                column: "MaturityRatingId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_SubtitleAppearanceId",
                table: "Profiles",
                column: "SubtitleAppearanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_UserId",
                table: "Profiles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileVideoRatings_ProfileId",
                table: "ProfileVideoRatings",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileVideoRatings_VideoId",
                table: "ProfileVideoRatings",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileVideoWatchings_ProfileId",
                table: "ProfileVideoWatchings",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileVideoWatchings_VideoId",
                table: "ProfileVideoWatchings",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Shadows_ColorId",
                table: "Shadows",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_StyleContents_ContentId",
                table: "StyleContents",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_StyleContents_StyleId",
                table: "StyleContents",
                column: "StyleId");

            migrationBuilder.CreateIndex(
                name: "IX_SubtitleAppearances_BackgroundId",
                table: "SubtitleAppearances",
                column: "BackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_SubtitleAppearances_FontId",
                table: "SubtitleAppearances",
                column: "FontId");

            migrationBuilder.CreateIndex(
                name: "IX_SubtitleAppearances_ShadowId",
                table: "SubtitleAppearances",
                column: "ShadowId");

            migrationBuilder.CreateIndex(
                name: "IX_SubtitleAppearances_TextSizeId",
                table: "SubtitleAppearances",
                column: "TextSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubtitleAppearances_WindowId",
                table: "SubtitleAppearances",
                column: "WindowId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeContents_ContentId",
                table: "TypeContents",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeContents_TypeId",
                table: "TypeContents",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PacketId",
                table: "Users",
                column: "PacketId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoLanguages_LanguageId",
                table: "VideoLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoLanguages_VideoId",
                table: "VideoLanguages",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Videos_CategoryId",
                table: "Videos",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Videos_ContentId",
                table: "Videos",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Videos_LanguageId",
                table: "Videos",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Windows_ColorId",
                table: "Windows",
                column: "ColorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContentCastTitles");

            migrationBuilder.DropTable(
                name: "GenreContents");

            migrationBuilder.DropTable(
                name: "InvoiceDetails");

            migrationBuilder.DropTable(
                name: "ProfileCommunicationSettings");

            migrationBuilder.DropTable(
                name: "ProfileContents");

            migrationBuilder.DropTable(
                name: "ProfilePlaybackSettings");

            migrationBuilder.DropTable(
                name: "ProfileVideoRatings");

            migrationBuilder.DropTable(
                name: "ProfileVideoWatchings");

            migrationBuilder.DropTable(
                name: "StyleContents");

            migrationBuilder.DropTable(
                name: "TypeContents");

            migrationBuilder.DropTable(
                name: "VideoLanguages");

            migrationBuilder.DropTable(
                name: "CastTitles");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "CreditCards");

            migrationBuilder.DropTable(
                name: "CommunicationSettings");

            migrationBuilder.DropTable(
                name: "PlaybackSettings");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Styles");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropTable(
                name: "Casts");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "SubtitleAppearances");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Backgrounds");

            migrationBuilder.DropTable(
                name: "Fonts");

            migrationBuilder.DropTable(
                name: "Shadows");

            migrationBuilder.DropTable(
                name: "TextSizes");

            migrationBuilder.DropTable(
                name: "Windows");

            migrationBuilder.DropTable(
                name: "Packets");

            migrationBuilder.DropTable(
                name: "MaturityRatings");

            migrationBuilder.DropTable(
                name: "Colors");
        }
    }
}
