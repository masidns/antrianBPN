using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MainApp.Migrations
{
    /// <inheritdoc />
    public partial class UserIdOnPetugasandClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Petugas",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Clients",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Petugas");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Clients");
        }
    }
}
