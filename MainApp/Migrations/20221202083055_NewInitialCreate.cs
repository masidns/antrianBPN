using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MainApp.Migrations
{
    /// <inheritdoc />
    public partial class NewInitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Antrians_AntrianId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Lokets_Antrians_AntrianId",
                table: "Lokets");

            migrationBuilder.DropForeignKey(
                name: "FK_Lokets_Petugas_PetugasId",
                table: "Lokets");

            migrationBuilder.DropIndex(
                name: "IX_Lokets_AntrianId",
                table: "Lokets");

            migrationBuilder.DropIndex(
                name: "IX_Lokets_PetugasId",
                table: "Lokets");

            migrationBuilder.DropIndex(
                name: "IX_Clients_AntrianId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "AntrianId",
                table: "Lokets");

            migrationBuilder.DropColumn(
                name: "PetugasId",
                table: "Lokets");

            migrationBuilder.DropColumn(
                name: "AntrianId",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "LoketId",
                table: "Petugas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Antrians",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoketId",
                table: "Antrians",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Petugas_LoketId",
                table: "Petugas",
                column: "LoketId");

            migrationBuilder.CreateIndex(
                name: "IX_Antrians_ClientId",
                table: "Antrians",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Antrians_LoketId",
                table: "Antrians",
                column: "LoketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Antrians_Clients_ClientId",
                table: "Antrians",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Antrians_Lokets_LoketId",
                table: "Antrians",
                column: "LoketId",
                principalTable: "Lokets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Petugas_Lokets_LoketId",
                table: "Petugas",
                column: "LoketId",
                principalTable: "Lokets",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Antrians_Clients_ClientId",
                table: "Antrians");

            migrationBuilder.DropForeignKey(
                name: "FK_Antrians_Lokets_LoketId",
                table: "Antrians");

            migrationBuilder.DropForeignKey(
                name: "FK_Petugas_Lokets_LoketId",
                table: "Petugas");

            migrationBuilder.DropIndex(
                name: "IX_Petugas_LoketId",
                table: "Petugas");

            migrationBuilder.DropIndex(
                name: "IX_Antrians_ClientId",
                table: "Antrians");

            migrationBuilder.DropIndex(
                name: "IX_Antrians_LoketId",
                table: "Antrians");

            migrationBuilder.DropColumn(
                name: "LoketId",
                table: "Petugas");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Antrians");

            migrationBuilder.DropColumn(
                name: "LoketId",
                table: "Antrians");

            migrationBuilder.AddColumn<int>(
                name: "AntrianId",
                table: "Lokets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PetugasId",
                table: "Lokets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AntrianId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lokets_AntrianId",
                table: "Lokets",
                column: "AntrianId");

            migrationBuilder.CreateIndex(
                name: "IX_Lokets_PetugasId",
                table: "Lokets",
                column: "PetugasId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AntrianId",
                table: "Clients",
                column: "AntrianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Antrians_AntrianId",
                table: "Clients",
                column: "AntrianId",
                principalTable: "Antrians",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lokets_Antrians_AntrianId",
                table: "Lokets",
                column: "AntrianId",
                principalTable: "Antrians",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lokets_Petugas_PetugasId",
                table: "Lokets",
                column: "PetugasId",
                principalTable: "Petugas",
                principalColumn: "Id");
        }
    }
}
