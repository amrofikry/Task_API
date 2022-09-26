using Microsoft.EntityFrameworkCore.Migrations;

namespace RepostaryPattren.Data.Migrations
{
    public partial class AddRealtionbetweenUserandcertifcate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "certificate",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_certificate", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usercertificate",
                columns: table => new
                {
                    certificatesid = table.Column<int>(type: "int", nullable: false),
                    usersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usercertificate", x => new { x.certificatesid, x.usersId });
                    table.ForeignKey(
                        name: "FK_Usercertificate_AspNetUsers_usersId",
                        column: x => x.usersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usercertificate_certificate_certificatesid",
                        column: x => x.certificatesid,
                        principalTable: "certificate",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usercertificate_usersId",
                table: "Usercertificate",
                column: "usersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usercertificate");

            migrationBuilder.DropTable(
                name: "certificate");
        }
    }
}
