using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Models.SQL
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ms_Storage_Locations",
                columns: table => new
                {
                    location_id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    location_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ms_Storage_Locations", x => x.location_id);
                });

            migrationBuilder.CreateTable(
                name: "Tr_Bpkbs",
                columns: table => new
                {
                    agreement_number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    bpkb_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    branch_id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    bpkb_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    faktur_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    faktur_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    location_id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    police_no = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    bpkb_date_in = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tr_Bpkbs", x => x.agreement_number);
                    table.ForeignKey(
                        name: "FK_Tr_Bpkbs_Ms_Storage_Locations_location_id",
                        column: x => x.location_id,
                        principalTable: "Ms_Storage_Locations",
                        principalColumn: "location_id");
                });

            migrationBuilder.InsertData(
                table: "Ms_Storage_Locations",
                columns: new[] { "location_id", "location_name" },
                values: new object[,]
                {
                    { "3201210001", "Karadenan" },
                    { "3201210002", "Nanggewer" },
                    { "3201210003", "Nanggewer Mekar" },
                    { "3201210004", "Cibinong" },
                    { "3201210005", "Pakansari" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tr_Bpkbs_location_id",
                table: "Tr_Bpkbs",
                column: "location_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tr_Bpkbs");

            migrationBuilder.DropTable(
                name: "Ms_Storage_Locations");
        }
    }
}
