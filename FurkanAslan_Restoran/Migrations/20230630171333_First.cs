using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurkanAslanRestoran.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Iceceks",
                columns: table => new
                {
                    IcecekId = table.Column<int>(name: "Icecek_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IcecekAd = table.Column<string>(name: "Icecek_Ad", type: "nvarchar(max)", nullable: true),
                    IcecekKatId = table.Column<int>(name: "Icecek_Kat_Id", type: "int", nullable: false),
                    IcecekSkt = table.Column<string>(name: "Icecek_Skt", type: "nvarchar(max)", nullable: true),
                    IcecekMiktar = table.Column<int>(name: "Icecek_Miktar", type: "int", nullable: false),
                    IcecekAdet = table.Column<int>(name: "Icecek_Adet", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iceceks", x => x.IcecekId);
                });

            migrationBuilder.CreateTable(
                name: "Malzemes",
                columns: table => new
                {
                    MalId = table.Column<int>(name: "Mal_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MalAd = table.Column<string>(name: "Mal_Ad", type: "nvarchar(max)", nullable: false),
                    MalAdet = table.Column<int>(name: "Mal_Adet", type: "int", nullable: false),
                    MalSkt = table.Column<string>(name: "Mal_Skt", type: "nvarchar(max)", nullable: false),
                    MalUretimy = table.Column<string>(name: "Mal_Uretimy", type: "nvarchar(max)", nullable: false),
                    MalSube = table.Column<string>(name: "Mal_Sube", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Malzemes", x => x.MalId);
                });

            migrationBuilder.CreateTable(
                name: "Yemeks",
                columns: table => new
                {
                    YmkId = table.Column<int>(name: "Ymk_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YmkAd = table.Column<string>(name: "Ymk_Ad", type: "nvarchar(max)", nullable: false),
                    YmkKatId = table.Column<int>(name: "Ymk_Kat_Id", type: "int", nullable: false),
                    YmkDurum = table.Column<int>(name: "Ymk_Durum", type: "int", nullable: false),
                    YmkSprId = table.Column<int>(name: "Ymk_Spr_Id", type: "int", nullable: false),
                    YmkSefId = table.Column<int>(name: "Ymk_Sef_Id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yemeks", x => x.YmkId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iceceks");

            migrationBuilder.DropTable(
                name: "Malzemes");

            migrationBuilder.DropTable(
                name: "Yemeks");
        }
    }
}
