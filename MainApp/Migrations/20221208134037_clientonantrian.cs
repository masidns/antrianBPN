using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MainApp.Migrations
{
    /// <inheritdoc />
    public partial class clientonantrian : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Antrians_Clients_ClientId",
                table: "Antrians");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Antrians",
                newName: "clientId");

            migrationBuilder.RenameIndex(
                name: "IX_Antrians_ClientId",
                table: "Antrians",
                newName: "IX_Antrians_clientId");

            migrationBuilder.AlterColumn<int>(
                name: "clientId",
                table: "Antrians",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Antrians_Clients_clientId",
                table: "Antrians",
                column: "clientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Antrians_Clients_clientId",
                table: "Antrians");

            migrationBuilder.RenameColumn(
                name: "clientId",
                table: "Antrians",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Antrians_clientId",
                table: "Antrians",
                newName: "IX_Antrians_ClientId");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Antrians",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Antrians_Clients_ClientId",
                table: "Antrians",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");
        }
    }
}
