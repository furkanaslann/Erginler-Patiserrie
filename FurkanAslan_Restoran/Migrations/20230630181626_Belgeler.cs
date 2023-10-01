using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurkanAslanRestoran.Migrations
{
    /// <inheritdoc />
    public partial class Belgeler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Garsons",
                columns: table => new
                {
                    garid = table.Column<int>(name: "gar_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    garad = table.Column<string>(name: "gar_ad", type: "nvarchar(max)", nullable: true),
                    garsoyad = table.Column<string>(name: "gar_soyad", type: "nvarchar(max)", nullable: true),
                    gartc = table.Column<int>(name: "gar_tc", type: "int", nullable: false),
                    garsube = table.Column<string>(name: "gar_sube", type: "nvarchar(max)", nullable: false),
                    garyemekdurum = table.Column<int>(name: "gar_yemek_durum", type: "int", nullable: false),
                    garmasaid = table.Column<int>(name: "gar_masa_id", type: "int", nullable: false),
                    garyemekid = table.Column<int>(name: "gar_yemek_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garsons", x => x.garid);
                });

            migrationBuilder.CreateTable(
                name: "IcecekKategorileris",
                columns: table => new
                {
                    icecekkatid = table.Column<int>(name: "icecek_kat_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    icecekkategori = table.Column<string>(name: "icecek_kategori", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IcecekKategorileris", x => x.icecekkatid);
                });

            migrationBuilder.CreateTable(
                name: "Masas",
                columns: table => new
                {
                    masaid = table.Column<int>(name: "masa_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    masamid = table.Column<int>(name: "masa_m_id", type: "int", nullable: false),
                    masaymkid = table.Column<int>(name: "masa_ymk_id", type: "int", nullable: false),
                    masaymkdurum = table.Column<int>(name: "masa_ymk_durum", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masas", x => x.masaid);
                });

            migrationBuilder.CreateTable(
                name: "Musteris",
                columns: table => new
                {
                    mid = table.Column<int>(name: "m_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mad = table.Column<string>(name: "m_ad", type: "nvarchar(max)", nullable: true),
                    msoyad = table.Column<string>(name: "m_soyad", type: "nvarchar(max)", nullable: true),
                    mmasaid = table.Column<int>(name: "m_masa_id", type: "int", nullable: false),
                    myemekdurum = table.Column<int>(name: "m_yemek_durum", type: "int", nullable: false),
                    myemekid = table.Column<int>(name: "m_yemek_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteris", x => x.mid);
                });

            migrationBuilder.CreateTable(
                name: "Sefs",
                columns: table => new
                {
                    sefid = table.Column<int>(name: "sef_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sefad = table.Column<string>(name: "sef_ad", type: "nvarchar(max)", nullable: true),
                    sefsoyad = table.Column<string>(name: "sef_soyad", type: "nvarchar(max)", nullable: true),
                    sefkulmalid = table.Column<int>(name: "sef_kul_mal_id", type: "int", nullable: false),
                    sefyemekdurum = table.Column<int>(name: "sef_yemek_durum", type: "int", nullable: false),
                    sefyemekid = table.Column<int>(name: "sef_yemek_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sefs", x => x.sefid);
                });

            migrationBuilder.CreateTable(
                name: "Sipariss",
                columns: table => new
                {
                    sprid = table.Column<int>(name: "spr_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sprgarid = table.Column<int>(name: "spr_gar_id", type: "int", nullable: false),
                    sprmid = table.Column<int>(name: "spr_m_id", type: "int", nullable: false),
                    sprmalid = table.Column<int>(name: "spr_mal_id", type: "int", nullable: false),
                    sprymkid = table.Column<int>(name: "spr_ymk_id", type: "int", nullable: false),
                    sprymkdurum = table.Column<int>(name: "spr_ymk_durum", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sipariss", x => x.sprid);
                });

            migrationBuilder.CreateTable(
                name: "YemekDurums",
                columns: table => new
                {
                    ymkdurumid = table.Column<int>(name: "ymk_durum_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ymkdurum = table.Column<string>(name: "ymk_durum", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekDurums", x => x.ymkdurumid);
                });

            migrationBuilder.CreateTable(
                name: "YemekKategorileris",
                columns: table => new
                {
                    ymkkatid = table.Column<int>(name: "ymk_kat_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ymkkategori = table.Column<string>(name: "ymk_kategori", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekKategorileris", x => x.ymkkatid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Garsons");

            migrationBuilder.DropTable(
                name: "IcecekKategorileris");

            migrationBuilder.DropTable(
                name: "Masas");

            migrationBuilder.DropTable(
                name: "Musteris");

            migrationBuilder.DropTable(
                name: "Sefs");

            migrationBuilder.DropTable(
                name: "Sipariss");

            migrationBuilder.DropTable(
                name: "YemekDurums");

            migrationBuilder.DropTable(
                name: "YemekKategorileris");
        }
    }
}
