using Microsoft.EntityFrameworkCore.Migrations;

namespace RepostaryPattren.Data.Migrations
{
    public partial class updatetableuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usercertificate_certificate_certificatesid",
                table: "Usercertificate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_certificate",
                table: "certificate");

            migrationBuilder.RenameTable(
                name: "certificate",
                newName: "certificates");

            migrationBuilder.AddPrimaryKey(
                name: "PK_certificates",
                table: "certificates",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usercertificate_certificates_certificatesid",
                table: "Usercertificate",
                column: "certificatesid",
                principalTable: "certificates",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usercertificate_certificates_certificatesid",
                table: "Usercertificate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_certificates",
                table: "certificates");

            migrationBuilder.RenameTable(
                name: "certificates",
                newName: "certificate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_certificate",
                table: "certificate",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usercertificate_certificate_certificatesid",
                table: "Usercertificate",
                column: "certificatesid",
                principalTable: "certificate",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
