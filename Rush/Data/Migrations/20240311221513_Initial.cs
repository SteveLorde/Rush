using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rush.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Filesname = table.Column<string>(type: "TEXT", nullable: false),
                    imagecover = table.Column<string>(type: "TEXT", nullable: false),
                    LastUpdated = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Filesname", "LastUpdated", "Name", "imagecover" },
                values: new object[] { new Guid("04d98ca9-7e8b-442f-b768-0dd727ff394e"), "CODBO2.rar", new DateOnly(2024, 3, 12), "Call Of Duty Black Ops 2", "cover.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
