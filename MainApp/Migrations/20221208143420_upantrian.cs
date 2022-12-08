using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MainApp.Migrations
{
    /// <inheritdoc />
    public partial class upantrian : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Antrians_Layanans_LayananId",
                table: "Antrians");

            migrationBuilder.AlterColumn<int>(
                name: "LayananId",
                table: "Antrians",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Antrians_Layanans_LayananId",
                table: "Antrians",
                column: "LayananId",
                principalTable: "Layanans",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Antrians_Layanans_LayananId",
                table: "Antrians");

            migrationBuilder.AlterColumn<int>(
                name: "LayananId",
                table: "Antrians",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Antrians_Layanans_LayananId",
                table: "Antrians",
                column: "LayananId",
                principalTable: "Layanans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
