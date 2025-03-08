using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StockForThePeople.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Ticker = table.Column<string>(type: "TEXT", maxLength: 9, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Symbol = table.Column<string>(type: "TEXT", maxLength: 6, nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Exchange = table.Column<string>(type: "TEXT", nullable: true),
                    Currency = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarketData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AssetId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Volume = table.Column<int>(type: "INTEGER", nullable: false),
                    Value = table.Column<decimal>(type: "TEXT", nullable: false),
                    Open = table.Column<decimal>(type: "TEXT", nullable: false),
                    Close = table.Column<decimal>(type: "TEXT", nullable: false),
                    Low = table.Column<decimal>(type: "TEXT", nullable: false),
                    High = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarketData_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", maxLength: 1, nullable: false),
                    Units = table.Column<int>(type: "INTEGER", nullable: false),
                    TransactionMoment = table.Column<DateTime>(type: "TEXT", nullable: true),
                    AssetId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTransactions_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "CreatedAt", "Currency", "Exchange", "ModifiedAt", "Name", "Symbol", "Ticker", "Type" },
                values: new object[,]
                {
                    { new Guid("0c6188c9-399d-491e-a234-64806a82e0f6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EUR", "AS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morningstar Developed Markets Dividend Leaders", "TDIV", "TDIV.AS", "ETF" },
                    { new Guid("0d32dbbf-39f1-4e2a-8c0f-f74129985dfb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EUR", "AS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ABN", "ABN", "ABN.AS", null },
                    { new Guid("13e35aab-c362-40b2-91d3-300c41508fed"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EUR", "AS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nationale Nederlanden", "NN", "NN.AS", null },
                    { new Guid("1772edb4-5159-44e7-91ca-0d5b56122770"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EUR", "AS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASML", "ASML", "ASML.AS", null },
                    { new Guid("24da7af9-e7f7-4cbb-b5a7-77127a3c888c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EUR", "AS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KPN", "KPN", "KPN.AS", null },
                    { new Guid("2b4e7c35-069f-46e3-985f-ba02f89a494b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EUR", "F", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unibail Rodamco", "1BR1", "1BR1.F", null },
                    { new Guid("363d100a-f412-4709-9c44-e60b7617c64e"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EUR", "AS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pharming", "PHARM", "PHARM.AS", null },
                    { new Guid("4e105535-db12-4395-a9f6-342d3fd477b1"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EUR", "AS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahold", "AD", "AD.AS", null },
                    { new Guid("53290d2d-d91b-46a7-8917-33f439a0a494"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EUR", "AS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unilever", "UNA", "UNA.AS", null },
                    { new Guid("58d92555-d2d4-483c-975e-87190aba62ec"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EUR", "AS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VanEck AEX ETF", "TDT", "TDT.AS", "ETF" },
                    { new Guid("6886bc8d-0824-4984-95f6-8c6d068b97eb"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EUR", "AS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Royal Dutch Shell", "SHELL", "SHELL.AS", "Common stock" },
                    { new Guid("6e89c090-a1c4-46db-ae4a-e561b497e90d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EUR", "AS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BE Semiconductor Industries NV", "BESI", "BESI.AS", null },
                    { new Guid("8b02aae5-8a1a-483a-af0f-e89c43df22b1"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DOLLAR", "US", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DSM", "DSMFF", "DSMFF.US", null },
                    { new Guid("95a75464-45a2-4277-9c17-e64813fbb033"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EUR", "AS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ING Bank", "INGA", "INGA.AS", null },
                    { new Guid("a77cce6f-c0e7-4959-8ede-44cf1e193a5a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EUR", "AS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alfen laadpalen", "ALFEN", "ALFEN.AS", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MarketData_AssetId",
                table: "MarketData",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTransactions_AssetId",
                table: "UserTransactions",
                column: "AssetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarketData");

            migrationBuilder.DropTable(
                name: "UserTransactions");

            migrationBuilder.DropTable(
                name: "Assets");
        }
    }
}
