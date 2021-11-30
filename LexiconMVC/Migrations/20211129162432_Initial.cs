using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMVCData.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Göteborg", "Adam Adamsson", "031-123456" },
                    { 2, "Malmö", "Bertil Bertilsson", "031-123456" },
                    { 3, "Stockholm", "Carl Carlsson", "031-123456" },
                    { 4, "Göteborg", "Dan Danielsson", "031-123456" },
                    { 5, "Malmö", "Erik Eriksson", "031-123456" },
                    { 6, "Stockholm", "Frans Fransson", "031-123456" },
                    { 7, "Göteborg", "Gustav Gustavsson", "031-123456" },
                    { 8, "Malmö", "Henrik Henriksson", "031-123456" },
                    { 9, "Stockholm", "Ivar Ivarsson", "031-123456" },
                    { 10, "Göteborg", "Jan Jansson", "031-123456" },
                    { 11, "Malmö", "Karl Karlsson", "031-123456" },
                    { 12, "Stockholm", "Lars Larsson", "031-123456" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
