using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurkanAslanRestoran.Migrations
{
    /// <inheritdoc />
    public partial class GarsonDeneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sipariss",
                table: "Sipariss");

            migrationBuilder.RenameColumn(
                name: "spr_ymk_id",
                table: "Sipariss",
                newName: "SiparisYemekId");

            migrationBuilder.RenameColumn(
                name: "spr_ymk_durum",
                table: "Sipariss",
                newName: "SiparisYemekDurumId");

            migrationBuilder.RenameColumn(
                name: "spr_mal_id",
                table: "Sipariss",
                newName: "SiparisMusteriId");

            migrationBuilder.RenameColumn(
                name: "spr_m_id",
                table: "Sipariss",
                newName: "SiparisMasaId");

            migrationBuilder.RenameColumn(
                name: "spr_gar_id",
                table: "Sipariss",
                newName: "SiparisMalzeme");

            migrationBuilder.RenameColumn(
                name: "spr_id",
                table: "Sipariss",
                newName: "SiparisIcecekId");

            migrationBuilder.RenameColumn(
                name: "gar_yemek_id",
                table: "Garsons",
                newName: "GarsonYemekId");

            migrationBuilder.RenameColumn(
                name: "gar_yemek_durum",
                table: "Garsons",
                newName: "GarsonYemekDurumId");

            migrationBuilder.RenameColumn(
                name: "gar_tc",
                table: "Garsons",
                newName: "GarsonTC");

            migrationBuilder.RenameColumn(
                name: "gar_sube",
                table: "Garsons",
                newName: "GarsonSube");

            migrationBuilder.RenameColumn(
                name: "gar_soyad",
                table: "Garsons",
                newName: "GarsonSoyad");

            migrationBuilder.RenameColumn(
                name: "gar_masa_id",
                table: "Garsons",
                newName: "GarsonMasaId");

            migrationBuilder.RenameColumn(
                name: "gar_ad",
                table: "Garsons",
                newName: "GarsonAd");

            migrationBuilder.RenameColumn(
                name: "gar_id",
                table: "Garsons",
                newName: "GarsonId");

            migrationBuilder.AlterColumn<int>(
                name: "SiparisIcecekId",
                table: "Sipariss",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SiparisId",
                table: "Sipariss",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "GarsonId",
                table: "Sipariss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sipariss",
                table: "Sipariss",
                column: "SiparisId");

            migrationBuilder.CreateIndex(
                name: "IX_Sipariss_GarsonId",
                table: "Sipariss",
                column: "GarsonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sipariss_Garsons_GarsonId",
                table: "Sipariss",
                column: "GarsonId",
                principalTable: "Garsons",
                principalColumn: "GarsonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sipariss_Garsons_GarsonId",
                table: "Sipariss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sipariss",
                table: "Sipariss");

            migrationBuilder.DropIndex(
                name: "IX_Sipariss_GarsonId",
                table: "Sipariss");

            migrationBuilder.DropColumn(
                name: "SiparisId",
                table: "Sipariss");

            migrationBuilder.DropColumn(
                name: "GarsonId",
                table: "Sipariss");

            migrationBuilder.RenameColumn(
                name: "SiparisYemekId",
                table: "Sipariss",
                newName: "spr_ymk_id");

            migrationBuilder.RenameColumn(
                name: "SiparisYemekDurumId",
                table: "Sipariss",
                newName: "spr_ymk_durum");

            migrationBuilder.RenameColumn(
                name: "SiparisMusteriId",
                table: "Sipariss",
                newName: "spr_mal_id");

            migrationBuilder.RenameColumn(
                name: "SiparisMasaId",
                table: "Sipariss",
                newName: "spr_m_id");

            migrationBuilder.RenameColumn(
                name: "SiparisMalzeme",
                table: "Sipariss",
                newName: "spr_gar_id");

            migrationBuilder.RenameColumn(
                name: "SiparisIcecekId",
                table: "Sipariss",
                newName: "spr_id");

            migrationBuilder.RenameColumn(
                name: "GarsonYemekId",
                table: "Garsons",
                newName: "gar_yemek_id");

            migrationBuilder.RenameColumn(
                name: "GarsonYemekDurumId",
                table: "Garsons",
                newName: "gar_yemek_durum");

            migrationBuilder.RenameColumn(
                name: "GarsonTC",
                table: "Garsons",
                newName: "gar_tc");

            migrationBuilder.RenameColumn(
                name: "GarsonSube",
                table: "Garsons",
                newName: "gar_sube");

            migrationBuilder.RenameColumn(
                name: "GarsonSoyad",
                table: "Garsons",
                newName: "gar_soyad");

            migrationBuilder.RenameColumn(
                name: "GarsonMasaId",
                table: "Garsons",
                newName: "gar_masa_id");

            migrationBuilder.RenameColumn(
                name: "GarsonAd",
                table: "Garsons",
                newName: "gar_ad");

            migrationBuilder.RenameColumn(
                name: "GarsonId",
                table: "Garsons",
                newName: "gar_id");

            migrationBuilder.AlterColumn<int>(
                name: "spr_id",
                table: "Sipariss",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sipariss",
                table: "Sipariss",
                column: "spr_id");
        }
    }
}
