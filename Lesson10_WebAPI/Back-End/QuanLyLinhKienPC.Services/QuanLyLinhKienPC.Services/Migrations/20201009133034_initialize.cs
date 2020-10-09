using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyLinhKienPC.Services.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DanhMucLinhKiens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    GroupName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucLinhKiens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LinhKiens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(nullable: false),
                    LinhKienStatusEnum = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    DanhMucLinhKienId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinhKiens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LinhKiens_DanhMucLinhKiens_DanhMucLinhKienId",
                        column: x => x.DanhMucLinhKienId,
                        principalTable: "DanhMucLinhKiens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LinhKiens_DanhMucLinhKienId",
                table: "LinhKiens",
                column: "DanhMucLinhKienId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinhKiens");

            migrationBuilder.DropTable(
                name: "DanhMucLinhKiens");
        }
    }
}
