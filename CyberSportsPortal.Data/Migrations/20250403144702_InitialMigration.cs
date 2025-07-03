using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CyberSportsPortal.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdvertisingCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    AdvertisementLink = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertisingCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Organizer = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    StartDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdvertisementPaymentInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PaymentSum = table.Column<decimal>(type: "numeric", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AdvertisingCompanyId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertisementPaymentInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvertisementPaymentInfos_AdvertisingCompanies_AdvertisingC~",
                        column: x => x.AdvertisingCompanyId,
                        principalTable: "AdvertisingCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Surname = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Nickname = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Country = table.Column<int>(type: "integer", nullable: false),
                    TeamId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProbabilityOfVictories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WinnerId = table.Column<int>(type: "integer", nullable: false),
                    LoserId = table.Column<int>(type: "integer", nullable: false),
                    Probability = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProbabilityOfVictories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProbabilityOfVictories_Teams_LoserId",
                        column: x => x.LoserId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProbabilityOfVictories_Teams_WinnerId",
                        column: x => x.WinnerId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Score = table.Column<int>(type: "integer", nullable: false),
                    AtMoment = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    TeamId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MatchHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WinnerId = table.Column<int>(type: "integer", nullable: false),
                    LoserId = table.Column<int>(type: "integer", nullable: false),
                    TournamentId = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchHistories_Teams_LoserId",
                        column: x => x.LoserId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MatchHistories_Teams_WinnerId",
                        column: x => x.WinnerId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MatchHistories_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TournamentParticipantInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Standing = table.Column<int>(type: "integer", nullable: false),
                    Place = table.Column<int>(type: "integer", nullable: true),
                    TeamId = table.Column<int>(type: "integer", nullable: false),
                    TournamentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentParticipantInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TournamentParticipantInfos_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TournamentParticipantInfos_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TournamentPrizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Place = table.Column<int>(type: "integer", nullable: false),
                    Prize = table.Column<int>(type: "integer", nullable: false),
                    TournamentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentPrizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TournamentPrizes_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AdvertisingCompanies",
                columns: new[] { "Id", "AdvertisementLink", "Name" },
                values: new object[,]
                {
                    { 1, "videos/Cat.mp4", "VeryBigCompany" },
                    { 2, "videos/Cat2.mp4", "SmallCompany" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Alpha Squad" },
                    { 2, "Dragon Force" },
                    { 3, "Polar Bears" },
                    { 4, "Storm Riders" },
                    { 5, "Shadow Collective" },
                    { 6, "Northern Alliance" },
                    { 7, "Imperial Guard" },
                    { 8, "Mythic Gaming" },
                    { 9, "Aurora Esports" },
                    { 10, "Quantum Gaming" },
                    { 11, "Frost Giants" },
                    { 12, "Titan Brigade" },
                    { 13, "Celestial Team" },
                    { 14, "Vanguard Esports" },
                    { 15, "Nebula Warriors" },
                    { 16, "Omega Team" },
                    { 17, "Blaze Athletics" },
                    { 18, "Monsoon Team" },
                    { 19, "Spectral Gaming" },
                    { 20, "Horizon Esports" }
                });

            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "Id", "EndDate", "Name", "Organizer", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "World Championship 2024", "GameSphere Interactive", new DateTimeOffset(new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Elite Series Autumn 2024", "Pro Gaming League", new DateTimeOffset(new DateTime(2024, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2026, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Prime Tournament", "Global Esports Network", new DateTimeOffset(new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "MatchHistories",
                columns: new[] { "Id", "Date", "LoserId", "TournamentId", "WinnerId" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 1, 2 },
                    { 2, new DateTimeOffset(new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3, 1, 4 },
                    { 3, new DateTimeOffset(new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 6, 1, 5 },
                    { 4, new DateTimeOffset(new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 8, 1, 7 },
                    { 5, new DateTimeOffset(new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 10, 1, 9 },
                    { 6, new DateTimeOffset(new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 11, 1, 12 },
                    { 7, new DateTimeOffset(new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 13, 1, 14 },
                    { 8, new DateTimeOffset(new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 16, 1, 15 },
                    { 9, new DateTimeOffset(new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 1, 3 },
                    { 10, new DateTimeOffset(new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, 1, 4 },
                    { 11, new DateTimeOffset(new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 5, 1, 7 },
                    { 12, new DateTimeOffset(new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 6, 1, 8 },
                    { 13, new DateTimeOffset(new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 11, 1, 9 },
                    { 14, new DateTimeOffset(new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 12, 1, 10 },
                    { 15, new DateTimeOffset(new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 13, 1, 15 },
                    { 16, new DateTimeOffset(new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 16, 1, 14 },
                    { 17, new DateTimeOffset(new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 1, 5 },
                    { 18, new DateTimeOffset(new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 6, 1, 2 },
                    { 19, new DateTimeOffset(new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3, 1, 7 },
                    { 20, new DateTimeOffset(new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 8, 1, 4 },
                    { 21, new DateTimeOffset(new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 13, 1, 9 },
                    { 22, new DateTimeOffset(new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 10, 1, 14 },
                    { 23, new DateTimeOffset(new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 11, 1, 15 },
                    { 24, new DateTimeOffset(new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 12, 1, 16 },
                    { 25, new DateTimeOffset(new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 1, 4 },
                    { 26, new DateTimeOffset(new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3, 1, 2 },
                    { 27, new DateTimeOffset(new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 8, 1, 5 },
                    { 28, new DateTimeOffset(new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 6, 1, 7 },
                    { 29, new DateTimeOffset(new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 12, 1, 9 },
                    { 30, new DateTimeOffset(new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 11, 1, 10 },
                    { 31, new DateTimeOffset(new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 16, 1, 13 },
                    { 32, new DateTimeOffset(new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 14, 1, 15 },
                    { 33, new DateTimeOffset(new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 6, 1, 1 },
                    { 34, new DateTimeOffset(new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 7, 1, 2 },
                    { 35, new DateTimeOffset(new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 8, 1, 3 },
                    { 36, new DateTimeOffset(new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 5, 1, 4 },
                    { 37, new DateTimeOffset(new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 14, 1, 9 },
                    { 38, new DateTimeOffset(new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 15, 1, 10 },
                    { 39, new DateTimeOffset(new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 16, 1, 11 },
                    { 40, new DateTimeOffset(new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 13, 1, 12 },
                    { 41, new DateTimeOffset(new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 1, 7 },
                    { 42, new DateTimeOffset(new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 8, 1, 2 },
                    { 43, new DateTimeOffset(new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3, 1, 5 },
                    { 44, new DateTimeOffset(new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 6, 1, 4 },
                    { 45, new DateTimeOffset(new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 9, 1, 15 },
                    { 46, new DateTimeOffset(new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 16, 1, 10 },
                    { 47, new DateTimeOffset(new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 11, 1, 13 },
                    { 48, new DateTimeOffset(new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 12, 1, 14 },
                    { 49, new DateTimeOffset(new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 1, 8 },
                    { 50, new DateTimeOffset(new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 5, 1, 2 },
                    { 51, new DateTimeOffset(new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 6, 1, 3 },
                    { 52, new DateTimeOffset(new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 7, 1, 4 },
                    { 53, new DateTimeOffset(new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 16, 1, 9 },
                    { 54, new DateTimeOffset(new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 13, 1, 10 },
                    { 55, new DateTimeOffset(new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 11, 1, 14 },
                    { 56, new DateTimeOffset(new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 12, 1, 15 },
                    { 57, new DateTimeOffset(new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 10, 1, 2 },
                    { 58, new DateTimeOffset(new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 14, 1, 4 },
                    { 59, new DateTimeOffset(new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 5, 1, 9 },
                    { 60, new DateTimeOffset(new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 15, 1, 7 },
                    { 61, new DateTimeOffset(new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 7, 1, 9 },
                    { 62, new DateTimeOffset(new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, 1, 4 },
                    { 63, new DateTimeOffset(new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 9, 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Country", "Name", "Nickname", "Surname", "TeamId" },
                values: new object[,]
                {
                    { 1, 2, "Liam", "Frostbite", "Tremblay", 1 },
                    { 2, 18, "Juan", "Nighthawk", "dela Cruz", 1 },
                    { 3, 21, "Wei", "Ironclad", "Lim", 1 },
                    { 4, 4, "Mikkel", "Voidwalker", "Nielsen", 1 },
                    { 5, 10, "Avi", "Phoenix", "Cohen", 1 },
                    { 6, 3, "Wei", "Blitz", "Zhang", 2 },
                    { 7, 14, "Ahmad", "Spectre", "Ibrahim", 2 },
                    { 8, 3, "Jian", "Rampage", "Wang", 2 },
                    { 9, 3, "Xiao", "Havoc", "Li", 2 },
                    { 10, 3, "Yong", "Warlock", "Chen", 2 },
                    { 11, 20, "Dmitry", "Night", "Ivanov", 3 },
                    { 12, 20, "Alexei", "Overdrive", "Petrov", 3 },
                    { 13, 20, "Sergei", "Doombringer", "Volkov", 3 },
                    { 14, 15, "Ion", "Paragon", "Popov", 3 },
                    { 15, 20, "Vladimir", "Kingslayer", "Kuznetsov", 3 },
                    { 16, 0, "Oleksandr", "Tornado", "Shevchenko", 4 },
                    { 17, 20, "Artyom", "Tormentor", "Sokolov", 4 },
                    { 18, 20, "Magomed", "Collapse", "Ibragimov", 4 },
                    { 19, 0, "Mykhailo", "Mirage", "Kovalenko", 4 },
                    { 20, 20, "Yaroslav", "Warrior", "Borisov", 4 },
                    { 21, 6, "Elias", "NordicStorm", "Korhonen", 5 },
                    { 22, 19, "Krzysztof", "VoidPulse", "Nowak", 5 },
                    { 23, 23, "Erik", "FrostGiant", "Andersson", 5 },
                    { 24, 11, "Yousef", "DuneRider", "Al-Hashemi", 5 },
                    { 25, 5, "Mart", "BalticFox", "Tamm", 5 },
                    { 26, 1, "Georgi", "BlackHole", "Ivanov", 6 },
                    { 27, 23, "Oskar", "TundraKing", "Johansson", 6 },
                    { 28, 23, "Ludvig", "IronFist", "Bergström", 6 },
                    { 29, 23, "Viktor", "FrozenTide", "Nilsson", 6 },
                    { 30, 0, "Aliaksei", "CrimsonDawn", "Kuzmich", 6 },
                    { 31, 3, "Jing", "JadeDragon", "Wong", 7 },
                    { 32, 3, "Wei", "ThunderFist", "Liu", 7 },
                    { 33, 14, "Hakim", "Monsoon", "Abdullah", 7 },
                    { 34, 3, "Xing", "ShadowStep", "Zhao", 7 },
                    { 35, 14, "Wei", "SilentStrike", "Chan", 7 },
                    { 36, 17, "Ali", "DesertWind", "Khan", 8 },
                    { 37, 6, "Topias", "ArcticFox", "Virtanen", 8 },
                    { 38, 7, "Sebastien", "GaulishWarlord", "Dubois", 8 },
                    { 39, 13, "Martin", "BalkanSniper", "Stojanov", 8 },
                    { 40, 4, "Johan", "VikingKing", "Hansen", 8 },
                    { 41, 20, "Oleh", "CyberWolf", "Kovalchuk", 9 },
                    { 42, 20, "Volodymyr", "NeonBlade", "Melnyk", 9 },
                    { 43, 0, "Viktor", "SteelTitan", "Savchenko", 9 },
                    { 44, 20, "Ihor", "PhantomDance", "Bondarenko", 9 },
                    { 45, 20, "Dmytro", "SiberianHusk", "Ivanov", 9 },
                    { 46, 23, "Marcus", "NovaStrike", "Johansson", 10 },
                    { 47, 8, "Klaus", "BlitzKrieg", "Müller", 10 },
                    { 48, 23, "Emil", "FrozenCore", "Söderberg", 10 },
                    { 49, 16, "Lars", "FjordWarrior", "Olsen", 10 },
                    { 50, 23, "Axel", "PixelHunter", "Bergman", 10 },
                    { 51, 22, "Marek", "SlovakSniper", "Novak", 11 },
                    { 52, 8, "Heinrich", "TeutonicKnight", "Schneider", 11 },
                    { 53, 10, "David", "MossadAgent", "Levi", 11 },
                    { 54, 25, "Brandon", "LibertyPrime", "Wilson", 11 },
                    { 55, 8, "Adrian", "BerlinWall", "Fischer", 11 },
                    { 56, 3, "Chen", "JadeEmperor", "Liang", 12 },
                    { 57, 3, "Wei", "DynastyWarrior", "Zhao", 12 },
                    { 58, 3, "Jian", "RedPhoenix", "Wu", 12 },
                    { 59, 3, "Xiang", "DragonFist", "Liu", 12 },
                    { 60, 3, "Yong", "GreatWall", "Sun", 12 },
                    { 61, 3, "Peng", "GoldenDragon", "Wu", 13 },
                    { 62, 3, "Yuhao", "WhiteStorm", "Lin", 13 },
                    { 63, 3, "Jing", "TigerStyle", "Zhou", 13 },
                    { 64, 3, "Zhibiao", "Obsidian", "Ye", 13 },
                    { 65, 3, "Zhicheng", "SilentButterfly", "Zhang", 13 },
                    { 66, 3, "Shaohan", "PoisonDart", "Yang", 14 },
                    { 67, 3, "Jiaoyang", "OracleEye", "Zeng", 14 },
                    { 68, 3, "Yangwei", "ElderMonk", "Ren", 14 },
                    { 69, 3, "Jiahan", "PandaWarrior", "Xiong", 14 },
                    { 70, 3, "Cong", "ShadowGale", "Ding", 14 },
                    { 71, 20, "Igor", "SiberianTiger", "Volkov", 15 },
                    { 72, 11, "Amir", "DesertMirage", "Al-Farsi", 15 },
                    { 73, 1, "Ivan", "BalkanBear", "Georgiev", 15 },
                    { 74, 12, "Maroun", "PhoenixRising", "El-Haddad", 15 },
                    { 75, 8, "Kurosh", "PersianPrince", "Rahmani", 15 },
                    { 76, 24, "Somsak", "ThaiTempest", "Prachum", 16 },
                    { 77, 18, "Carlos", "IslandFury", "Manalo", 16 },
                    { 78, 18, "Ricardo", "MonsoonKing", "Santos", 16 },
                    { 79, 9, "Budi", "SharpBlade", "Prakoso", 16 },
                    { 80, 9, "Putra", "BaliStorm", "Wijaya", 16 },
                    { 81, 3, "Guoliang", "JadeFang", "Huang", 17 },
                    { 82, 3, "Heming", "GhostDancer", "Xu", 17 },
                    { 83, 3, "Sen", "MountainHermit", "Hu", 17 },
                    { 84, 3, "Hao", "CelestialGuard", "Lin", 17 },
                    { 85, 3, "Ziqiang", "DragonTamer", "Zhang", 17 },
                    { 86, 9, "Rizky", "Archipelago", "Pratama", 18 },
                    { 87, 14, "Wei Jian", "StraitShooter", "Tan", 18 },
                    { 88, 21, "Jian Wen", "LionCity", "Kang", 18 },
                    { 89, 21, "Chin Wei", "Mangrove", "Ooi", 18 },
                    { 90, 9, "Tri", "Komodo", "Wibowo", 18 },
                    { 91, 0, "Artem", "Hunter", "Shevchenko", 19 },
                    { 92, 0, "Rostislav", "Searunner", "Kovalenko", 19 },
                    { 93, 20, "Vladislav", "Taiga", "Petrov", 19 },
                    { 94, 20, "Danil", "Baikal", "Boyko", 19 },
                    { 95, 20, "Semyon", "Volga", "Lysov", 19 },
                    { 96, 20, "Aleksey", "Tundra", "Morozov", 20 },
                    { 97, 0, "Vitaly", "Vostok", "Kozlov", 20 },
                    { 98, 0, "Pavel", "BearPaw", "Orlov", 20 },
                    { 99, 20, "Yevgeny", "Siberia", "Sokolov", 20 },
                    { 100, 0, "Oleg", "Steppe", "Kravchuk", 20 }
                });

            migrationBuilder.InsertData(
                table: "ProbabilityOfVictories",
                columns: new[] { "Id", "LoserId", "Probability", "WinnerId" },
                values: new object[,]
                {
                    { 1, 2, 10, 1 },
                    { 2, 3, 20, 1 },
                    { 3, 4, 13, 1 },
                    { 4, 5, 18, 1 },
                    { 5, 6, 40, 1 },
                    { 6, 7, 16, 1 },
                    { 7, 8, 23, 1 },
                    { 8, 9, 50, 1 },
                    { 9, 10, 39, 1 },
                    { 10, 11, 70, 1 },
                    { 11, 12, 40, 1 },
                    { 12, 13, 56, 1 },
                    { 13, 14, 36, 1 },
                    { 14, 15, 34, 1 },
                    { 15, 16, 68, 1 },
                    { 16, 17, 80, 1 },
                    { 17, 18, 90, 1 },
                    { 18, 19, 95, 1 },
                    { 19, 20, 88, 1 },
                    { 20, 3, 70, 2 },
                    { 21, 4, 45, 2 },
                    { 22, 5, 55, 2 },
                    { 23, 6, 80, 2 },
                    { 24, 7, 63, 2 },
                    { 25, 8, 65, 2 },
                    { 26, 9, 73, 2 },
                    { 27, 10, 69, 2 },
                    { 28, 11, 92, 2 },
                    { 29, 12, 78, 2 },
                    { 30, 13, 81, 2 },
                    { 31, 14, 62, 2 },
                    { 32, 15, 76, 2 },
                    { 33, 16, 95, 2 },
                    { 34, 17, 100, 2 },
                    { 35, 18, 100, 2 },
                    { 36, 19, 100, 2 },
                    { 37, 20, 100, 2 },
                    { 38, 4, 33, 3 },
                    { 39, 5, 50, 3 },
                    { 40, 6, 72, 3 },
                    { 41, 7, 41, 3 },
                    { 42, 8, 50, 3 },
                    { 43, 9, 64, 3 },
                    { 44, 10, 68, 3 },
                    { 45, 11, 79, 3 },
                    { 46, 12, 56, 3 },
                    { 47, 13, 67, 3 },
                    { 48, 14, 50, 3 },
                    { 49, 15, 52, 3 },
                    { 50, 16, 76, 3 },
                    { 51, 17, 90, 3 },
                    { 52, 18, 92, 3 },
                    { 53, 19, 88, 3 },
                    { 54, 20, 95, 3 },
                    { 55, 5, 60, 4 },
                    { 56, 6, 80, 4 },
                    { 57, 7, 62, 4 },
                    { 58, 8, 66, 4 },
                    { 59, 9, 72, 4 },
                    { 60, 10, 70, 4 },
                    { 61, 11, 90, 4 },
                    { 62, 12, 72, 4 },
                    { 63, 13, 78, 4 },
                    { 64, 14, 75, 4 },
                    { 65, 15, 54, 4 },
                    { 66, 16, 100, 4 },
                    { 67, 17, 100, 4 },
                    { 68, 18, 100, 4 },
                    { 69, 19, 98, 4 },
                    { 70, 20, 95, 4 },
                    { 71, 6, 75, 5 },
                    { 72, 7, 50, 5 },
                    { 73, 8, 55, 5 },
                    { 74, 9, 63, 5 },
                    { 75, 10, 71, 5 },
                    { 76, 11, 80, 5 },
                    { 77, 12, 61, 5 },
                    { 78, 13, 67, 5 },
                    { 79, 14, 55, 5 },
                    { 80, 15, 53, 5 },
                    { 81, 16, 87, 5 },
                    { 82, 17, 94, 5 },
                    { 83, 18, 100, 5 },
                    { 84, 19, 91, 5 },
                    { 85, 20, 90, 5 },
                    { 86, 7, 34, 6 },
                    { 87, 8, 35, 6 },
                    { 88, 9, 49, 6 },
                    { 89, 10, 41, 6 },
                    { 90, 11, 60, 6 },
                    { 91, 12, 35, 6 },
                    { 92, 13, 47, 6 },
                    { 93, 14, 39, 6 },
                    { 94, 15, 50, 6 },
                    { 95, 16, 66, 6 },
                    { 96, 17, 75, 6 },
                    { 97, 18, 80, 6 },
                    { 98, 19, 78, 6 },
                    { 99, 20, 79, 6 },
                    { 100, 8, 60, 7 },
                    { 101, 9, 68, 7 },
                    { 102, 10, 65, 7 },
                    { 103, 11, 80, 7 },
                    { 104, 12, 73, 7 },
                    { 105, 13, 82, 7 },
                    { 106, 14, 50, 7 },
                    { 107, 15, 55, 7 },
                    { 108, 16, 87, 7 },
                    { 109, 17, 91, 7 },
                    { 110, 18, 93, 7 },
                    { 111, 19, 87, 7 },
                    { 112, 20, 90, 7 },
                    { 113, 9, 50, 8 },
                    { 114, 10, 50, 8 },
                    { 115, 11, 70, 8 },
                    { 116, 12, 67, 8 },
                    { 117, 13, 55, 8 },
                    { 118, 14, 45, 8 },
                    { 119, 15, 66, 8 },
                    { 120, 16, 80, 8 },
                    { 121, 17, 100, 8 },
                    { 122, 18, 100, 8 },
                    { 123, 19, 83, 8 },
                    { 124, 20, 90, 8 },
                    { 125, 10, 35, 9 },
                    { 126, 11, 75, 9 },
                    { 127, 12, 50, 9 },
                    { 128, 13, 50, 9 },
                    { 129, 14, 45, 9 },
                    { 130, 15, 50, 9 },
                    { 131, 16, 71, 9 },
                    { 132, 17, 89, 9 },
                    { 133, 18, 93, 9 },
                    { 134, 19, 67, 9 },
                    { 135, 20, 80, 9 },
                    { 136, 11, 89, 10 },
                    { 137, 12, 50, 10 },
                    { 138, 13, 61, 10 },
                    { 139, 14, 50, 10 },
                    { 140, 15, 40, 10 },
                    { 141, 16, 95, 10 },
                    { 142, 17, 89, 10 },
                    { 143, 18, 92, 10 },
                    { 144, 19, 85, 10 },
                    { 145, 20, 88, 10 },
                    { 146, 12, 30, 11 },
                    { 147, 13, 40, 11 },
                    { 148, 14, 25, 11 },
                    { 149, 15, 40, 11 },
                    { 150, 16, 50, 11 },
                    { 151, 17, 75, 11 },
                    { 152, 18, 65, 11 },
                    { 153, 19, 50, 11 },
                    { 154, 20, 50, 11 },
                    { 155, 13, 50, 12 },
                    { 156, 14, 50, 12 },
                    { 157, 15, 35, 12 },
                    { 158, 16, 70, 12 },
                    { 159, 17, 75, 12 },
                    { 160, 18, 65, 12 },
                    { 161, 19, 80, 12 },
                    { 162, 20, 90, 12 },
                    { 163, 14, 39, 13 },
                    { 164, 15, 43, 13 },
                    { 165, 16, 54, 13 },
                    { 166, 17, 78, 13 },
                    { 167, 18, 69, 13 },
                    { 168, 19, 70, 13 },
                    { 169, 20, 78, 13 },
                    { 170, 15, 50, 14 },
                    { 171, 16, 78, 14 },
                    { 172, 17, 76, 14 },
                    { 173, 18, 80, 14 },
                    { 174, 19, 75, 14 },
                    { 175, 20, 73, 14 },
                    { 176, 16, 88, 15 },
                    { 177, 17, 90, 15 },
                    { 178, 18, 100, 15 },
                    { 179, 19, 92, 15 },
                    { 180, 20, 89, 15 },
                    { 181, 17, 63, 16 },
                    { 182, 18, 65, 16 },
                    { 183, 19, 52, 16 },
                    { 184, 20, 58, 16 },
                    { 185, 18, 35, 17 },
                    { 186, 19, 50, 17 },
                    { 187, 20, 55, 17 },
                    { 188, 19, 45, 18 },
                    { 189, 20, 55, 18 },
                    { 190, 20, 50, 19 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "AtMoment", "Score", "TeamId" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 500, 1 },
                    { 2, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1000, 2 },
                    { 3, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 750, 3 },
                    { 4, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 600, 4 },
                    { 5, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 900, 5 },
                    { 6, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 650, 6 },
                    { 7, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 850, 7 },
                    { 8, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 800, 8 },
                    { 9, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 300, 9 },
                    { 10, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 678, 10 },
                    { 11, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 489, 11 },
                    { 12, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 721, 12 },
                    { 13, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 578, 13 },
                    { 14, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 846, 14 },
                    { 15, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 728, 15 },
                    { 16, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 564, 16 },
                    { 17, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 279, 17 },
                    { 18, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 176, 18 },
                    { 19, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 228, 19 },
                    { 20, new DateTimeOffset(new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 80, 20 }
                });

            migrationBuilder.InsertData(
                table: "TournamentParticipantInfos",
                columns: new[] { "Id", "Place", "Standing", "TeamId", "TournamentId" },
                values: new object[,]
                {
                    { 1, 1, 1, 4, 1 },
                    { 2, 2, 2, 2, 1 },
                    { 3, 3, 3, 5, 1 },
                    { 4, 4, 4, 7, 1 },
                    { 5, 5, 5, 3, 1 },
                    { 6, 6, 6, 14, 1 },
                    { 7, 7, 7, 8, 1 },
                    { 8, 8, 8, 16, 1 },
                    { 9, 9, 9, 9, 1 },
                    { 10, 10, 10, 10, 1 },
                    { 11, 11, 11, 6, 1 },
                    { 12, 12, 12, 1, 1 },
                    { 13, 13, 13, 13, 1 },
                    { 14, 14, 14, 12, 1 },
                    { 15, 15, 15, 15, 1 },
                    { 16, 16, 16, 11, 1 },
                    { 17, 1, 1, 11, 2 },
                    { 18, 2, 2, 2, 2 },
                    { 19, 3, 3, 3, 2 },
                    { 20, 4, 4, 16, 2 },
                    { 21, 5, 5, 4, 2 },
                    { 22, 6, 6, 9, 2 },
                    { 23, 7, 7, 15, 2 },
                    { 24, 8, 8, 6, 2 },
                    { 25, 9, 9, 10, 2 },
                    { 26, 10, 10, 20, 2 },
                    { 27, 11, 11, 19, 2 },
                    { 28, 12, 12, 18, 2 },
                    { 29, null, 1, 2, 3 },
                    { 30, null, 2, 20, 3 },
                    { 31, null, 3, 3, 3 },
                    { 32, null, 4, 15, 3 },
                    { 33, null, 5, 6, 3 },
                    { 34, null, 6, 14, 3 },
                    { 35, null, 7, 16, 3 },
                    { 36, null, 8, 8, 3 },
                    { 37, null, 9, 4, 3 },
                    { 38, null, 10, 5, 3 },
                    { 39, null, 11, 7, 3 },
                    { 40, null, 12, 13, 3 },
                    { 41, null, 13, 9, 3 },
                    { 42, null, 14, 10, 3 },
                    { 43, null, 15, 19, 3 },
                    { 44, null, 16, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "TournamentPrizes",
                columns: new[] { "Id", "Place", "Prize", "TournamentId" },
                values: new object[,]
                {
                    { 1, 1, 18208300, 1 },
                    { 2, 2, 5202400, 1 },
                    { 3, 3, 3601600, 1 },
                    { 4, 4, 2401100, 1 },
                    { 5, 5, 1400600, 1 },
                    { 6, 6, 1400600, 1 },
                    { 7, 7, 1000500, 1 },
                    { 8, 8, 1000500, 1 },
                    { 9, 9, 800400, 1 },
                    { 10, 10, 800400, 1 },
                    { 11, 11, 800400, 1 },
                    { 12, 12, 800400, 1 },
                    { 13, 13, 600300, 1 },
                    { 14, 14, 600300, 1 },
                    { 15, 15, 600300, 1 },
                    { 16, 16, 600300, 1 },
                    { 17, 1, 175000, 2 },
                    { 18, 2, 85000, 2 },
                    { 19, 3, 45000, 2 },
                    { 20, 4, 25000, 2 },
                    { 21, 5, 15000, 2 },
                    { 22, 6, 15000, 2 },
                    { 23, 7, 10000, 2 },
                    { 24, 8, 10000, 2 },
                    { 25, 9, 5000, 2 },
                    { 26, 10, 5000, 2 },
                    { 27, 11, 5000, 2 },
                    { 28, 12, 5000, 2 },
                    { 29, 1, 1000000, 3 },
                    { 30, 2, 350000, 3 },
                    { 31, 3, 2000000, 3 },
                    { 32, 4, 150000, 3 },
                    { 33, 5, 90000, 3 },
                    { 34, 6, 90000, 3 },
                    { 35, 7, 90000, 3 },
                    { 36, 8, 90000, 3 },
                    { 37, 9, 40000, 3 },
                    { 38, 10, 40000, 3 },
                    { 39, 11, 40000, 3 },
                    { 40, 12, 40000, 3 },
                    { 41, 13, 40000, 3 },
                    { 42, 14, 40000, 3 },
                    { 43, 15, 40000, 3 },
                    { 44, 16, 40000, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvertisementPaymentInfos_AdvertisingCompanyId",
                table: "AdvertisementPaymentInfos",
                column: "AdvertisingCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchHistories_LoserId",
                table: "MatchHistories",
                column: "LoserId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchHistories_TournamentId",
                table: "MatchHistories",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchHistories_WinnerId",
                table: "MatchHistories",
                column: "WinnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_ProbabilityOfVictories_LoserId",
                table: "ProbabilityOfVictories",
                column: "LoserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProbabilityOfVictories_WinnerId",
                table: "ProbabilityOfVictories",
                column: "WinnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_TeamId",
                table: "Ratings",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentParticipantInfos_TeamId",
                table: "TournamentParticipantInfos",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentParticipantInfos_TournamentId",
                table: "TournamentParticipantInfos",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentPrizes_TournamentId",
                table: "TournamentPrizes",
                column: "TournamentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertisementPaymentInfos");

            migrationBuilder.DropTable(
                name: "MatchHistories");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "ProbabilityOfVictories");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "TournamentParticipantInfos");

            migrationBuilder.DropTable(
                name: "TournamentPrizes");

            migrationBuilder.DropTable(
                name: "AdvertisingCompanies");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Tournaments");
        }
    }
}
