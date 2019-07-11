using Microsoft.EntityFrameworkCore.Migrations;

namespace goatvote.api.Migrations
{
    public partial class InitialPlayerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    TotalGamesPlayed = table.Column<int>(nullable: false),
                    TotalMinutesPlayed = table.Column<int>(nullable: false),
                    TotalPoints = table.Column<int>(nullable: false),
                    TotalSeasonsPlayed = table.Column<int>(nullable: false),
                    TotalPlayoffGames = table.Column<int>(nullable: false),
                    TotalAllStarGames = table.Column<int>(nullable: false),
                    Total50PointPlusGames = table.Column<int>(nullable: false),
                    MVPAwards = table.Column<int>(nullable: false),
                    FinalMVPAwards = table.Column<int>(nullable: false),
                    AllNBASelections = table.Column<int>(nullable: false),
                    PointsPerGame = table.Column<double>(nullable: false),
                    ReboundsPerGame = table.Column<double>(nullable: false),
                    AssistsPerGame = table.Column<double>(nullable: false),
                    BlocksPerGame = table.Column<double>(nullable: false),
                    StealsPerGame = table.Column<double>(nullable: false),
                    FGPercentage = table.Column<double>(nullable: false),
                    FG3Percentage = table.Column<double>(nullable: false),
                    FTPercentage = table.Column<double>(nullable: false),
                    PlayerEffeciencyRating = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
