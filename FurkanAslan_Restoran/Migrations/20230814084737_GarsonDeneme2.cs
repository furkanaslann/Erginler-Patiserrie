using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurkanAslanRestoran.Migrations
{
    /// <inheritdoc />
    public partial class GarsonDeneme2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sipariss_Garsons_GarsonId",
                table: "Sipariss");

            migrationBuilder.RenameColumn(
                name: "GarsonId",
                table: "Sipariss",
                newName: "GarsonId_Pk");

            migrationBuilder.RenameIndex(
                name: "IX_Sipariss_GarsonId",
                table: "Sipariss",
                newName: "IX_Sipariss_GarsonId_Pk");

            migrationBuilder.RenameColumn(
                name: "GarsonId",
                table: "Garsons",
                newName: "GarsonId_Pk");

            migrationBuilder.AddColumn<int>(
                name: "GarsonId_Fk",
                table: "Sipariss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Sipariss_Garsons_GarsonId_Pk",
                table: "Sipariss",
                column: "GarsonId_Pk",
                principalTable: "Garsons",
                principalColumn: "GarsonId_Pk",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sipariss_Garsons_GarsonId_Pk",
                table: "Sipariss");

            migrationBuilder.DropColumn(
                name: "GarsonId_Fk",
                table: "Sipariss");

            migrationBuilder.RenameColumn(
                name: "GarsonId_Pk",
                table: "Sipariss",
                newName: "GarsonId");

            migrationBuilder.RenameIndex(
                name: "IX_Sipariss_GarsonId_Pk",
                table: "Sipariss",
                newName: "IX_Sipariss_GarsonId");

            migrationBuilder.RenameColumn(
                name: "GarsonId_Pk",
                table: "Garsons",
                newName: "GarsonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sipariss_Garsons_GarsonId",
                table: "Sipariss",
                column: "GarsonId",
                principalTable: "Garsons",
                principalColumn: "GarsonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
