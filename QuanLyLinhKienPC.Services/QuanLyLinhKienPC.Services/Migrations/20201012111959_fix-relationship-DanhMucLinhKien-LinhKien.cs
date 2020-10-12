using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyLinhKienPC.Services.Migrations
{
    public partial class fixrelationshipDanhMucLinhKienLinhKien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_LinhKiens_DanhMucLinhKienId",
                table: "LinhKiens");

            migrationBuilder.CreateIndex(
                name: "IX_LinhKiens_DanhMucLinhKienId",
                table: "LinhKiens",
                column: "DanhMucLinhKienId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_LinhKiens_DanhMucLinhKienId",
                table: "LinhKiens");

            migrationBuilder.CreateIndex(
                name: "IX_LinhKiens_DanhMucLinhKienId",
                table: "LinhKiens",
                column: "DanhMucLinhKienId",
                unique: true);
        }
    }
}
