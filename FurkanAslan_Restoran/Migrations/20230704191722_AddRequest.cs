using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurkanAslanRestoran.Migrations
{
    /// <inheritdoc />
    public partial class AddRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    UserId = table.Column<int>(name: "User_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(name: "User_Name", type: "nvarchar(max)", nullable: false),
                    UserSurname = table.Column<string>(name: "User_Surname", type: "nvarchar(max)", nullable: false),
                    UserPhone = table.Column<int>(name: "User_Phone", type: "int", nullable: false),
                    UserMail = table.Column<string>(name: "User_Mail", type: "nvarchar(max)", nullable: false),
                    UserGender = table.Column<string>(name: "User_Gender", type: "nvarchar(max)", nullable: false),
                    UserAge = table.Column<int>(name: "User_Age", type: "int", nullable: false),
                    UserCountry = table.Column<string>(name: "User_Country", type: "nvarchar(max)", nullable: false),
                    UserCity = table.Column<string>(name: "User_City", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.UserId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
