using Microsoft.EntityFrameworkCore.Migrations;

namespace PagerApi.NetCore.Example.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Texto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "Id", "Texto" },
                values: new object[] { 1, "Prueba1" });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "Id", "Texto" },
                values: new object[] { 2, "Prueba2" });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "Id", "Texto" },
                values: new object[] { 3, "Prueba3" });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "Id", "Texto" },
                values: new object[] { 4, "Prueba4" });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "Id", "Texto" },
                values: new object[] { 5, "Prueba5" });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "Id", "Texto" },
                values: new object[] { 6, "Prueba6" });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "Id", "Texto" },
                values: new object[] { 7, "Prueba7" });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "Id", "Texto" },
                values: new object[] { 8, "Prueba8" });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "Id", "Texto" },
                values: new object[] { 9, "Prueba9" });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "Id", "Texto" },
                values: new object[] { 10, "Prueba10" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Test");
        }
    }
}
