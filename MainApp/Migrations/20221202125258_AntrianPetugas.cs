using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MainApp.Migrations
{
    /// <inheritdoc />
    public partial class AntrianPetugas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PetugasId",
                table: "Antrians",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Antrians_PetugasId",
                table: "Antrians",
                column: "PetugasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Antrians_Petugas_PetugasId",
                table: "Antrians",
                column: "PetugasId",
                principalTable: "Petugas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Antrians_Petugas_PetugasId",
                table: "Antrians");

            migrationBuilder.DropIndex(
                name: "IX_Antrians_PetugasId",
                table: "Antrians");

            migrationBuilder.DropColumn(
                name: "PetugasId",
                table: "Antrians");
        }
    }
}
