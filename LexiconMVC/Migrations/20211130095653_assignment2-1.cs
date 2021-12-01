using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMVCData.Migrations
{
    public partial class assignment21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "People");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "People",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Sverige" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Norge" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Danmark" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Göteborg" },
                    { 2, 1, "Malmö" },
                    { 3, 1, "Stockholm" },
                    { 4, 2, "Oslo" },
                    { 5, 2, "Bergen" },
                    { 6, 2, "Trondheim" },
                    { 7, 3, "Köpenhamn" },
                    { 8, 3, "Ålborg" },
                    { 9, 3, "Helsingör" }
                });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "CityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "CityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "CityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "CityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 5,
                column: "CityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 6,
                column: "CityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 7,
                column: "CityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 8,
                column: "CityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 9,
                column: "CityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 10,
                column: "CityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 11,
                column: "CityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 12,
                column: "CityId",
                value: 3);

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 13, 4, "Ole Bramserud", "031-123456" },
                    { 16, 4, "Gunn-Rita Dahle Flesjå", "031-123456" },
                    { 14, 5, "Petter Northug", "031-123456" },
                    { 17, 5, "Fleksnes", "031-123456" },
                    { 15, 6, "Theres Johaug", "031-123456" },
                    { 18, 6, "Max manus", "031-123456" },
                    { 19, 7, "Nikolaj Coster-Waldau", "031-123456" },
                    { 22, 7, "Kristian Tyrann", "031-123456" },
                    { 20, 8, "Iben Hjejle", "031-123456" },
                    { 23, 8, "Kim Larsen", "031-123456" },
                    { 21, 9, "Mads Mikkelsen", "031-123456" },
                    { 24, 9, "Tycho Brahe", "031-123456" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_CityId",
                table: "People",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Cities_CityId",
                table: "People",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Cities_CityId",
                table: "People");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_People_CityId",
                table: "People");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "People");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "City",
                value: "Göteborg");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "City",
                value: "Malmö");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "City",
                value: "Stockholm");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "City",
                value: "Göteborg");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 5,
                column: "City",
                value: "Malmö");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 6,
                column: "City",
                value: "Stockholm");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 7,
                column: "City",
                value: "Göteborg");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 8,
                column: "City",
                value: "Malmö");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 9,
                column: "City",
                value: "Stockholm");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 10,
                column: "City",
                value: "Göteborg");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 11,
                column: "City",
                value: "Malmö");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 12,
                column: "City",
                value: "Stockholm");
        }
    }
}
