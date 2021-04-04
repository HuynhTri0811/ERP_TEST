using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP_TEST_API.Migrations
{
    public partial class CreateStaffPart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Part",
                columns: table => new
                {
                    Oid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    STT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PartAdminID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartParentOid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Use = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Part", x => x.Oid);
                    table.ForeignKey(
                        name: "FK_Part_Part_PartParentOid",
                        column: x => x.PartParentOid,
                        principalTable: "Part",
                        principalColumn: "Oid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Oid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartOid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StaffManegeOid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Oid);
                    table.ForeignKey(
                        name: "FK_Staff_Part_PartOid",
                        column: x => x.PartOid,
                        principalTable: "Part",
                        principalColumn: "Oid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_Staff_StaffManegeOid",
                        column: x => x.StaffManegeOid,
                        principalTable: "Staff",
                        principalColumn: "Oid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Part_PartParentOid",
                table: "Part",
                column: "PartParentOid");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_PartOid",
                table: "Staff",
                column: "PartOid");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_StaffManegeOid",
                table: "Staff",
                column: "StaffManegeOid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Part");
        }
    }
}
