using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MainApp.Migrations
{
    /// <inheritdoc />
    public partial class JenisKelaminOnClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Jeniskelamin",
                table: "Clients",
                newName: "JenisKelamin");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JenisKelamin",
                table: "Clients",
                newName: "Jeniskelamin");
        }
    }
}
