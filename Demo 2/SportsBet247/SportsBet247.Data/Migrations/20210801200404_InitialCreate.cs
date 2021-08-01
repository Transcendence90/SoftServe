using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsBet247.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasketballEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeTeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AwayTeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HomeTeamOdd = table.Column<double>(type: "float", nullable: false),
                    AwayTeamOdd = table.Column<double>(type: "float", nullable: false),
                    DrawOdd = table.Column<double>(type: "float", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketballEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoxingEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstBoxerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondBoxerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstBoxerOdd = table.Column<double>(type: "float", nullable: false),
                    SecondBoxerOdd = table.Column<double>(type: "float", nullable: false),
                    DrawOdd = table.Column<double>(type: "float", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxingEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FootballEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeTeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AwayTeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HomeTeamOdd = table.Column<double>(type: "float", nullable: false),
                    AwayTeamOdd = table.Column<double>(type: "float", nullable: false),
                    DrawOdd = table.Column<double>(type: "float", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MMAEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstFighterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondFighterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstFighterOdd = table.Column<double>(type: "float", nullable: false),
                    SecondFighterOdd = table.Column<double>(type: "float", nullable: false),
                    DrawOdd = table.Column<double>(type: "float", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MMAEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TennisEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstPlayerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondPlayerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstPlayerOdd = table.Column<double>(type: "float", nullable: false),
                    SecondPlayerOdd = table.Column<double>(type: "float", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VolleyballEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeTeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AwayTeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HomeTeamOdd = table.Column<double>(type: "float", nullable: false),
                    AwayTeamOdd = table.Column<double>(type: "float", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolleyballEvents", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketballEvents");

            migrationBuilder.DropTable(
                name: "BoxingEvents");

            migrationBuilder.DropTable(
                name: "FootballEvents");

            migrationBuilder.DropTable(
                name: "MMAEvents");

            migrationBuilder.DropTable(
                name: "TennisEvents");

            migrationBuilder.DropTable(
                name: "VolleyballEvents");
        }
    }
}
