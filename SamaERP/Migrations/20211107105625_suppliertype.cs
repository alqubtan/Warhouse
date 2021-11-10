using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SamaERP.Migrations
{
    public partial class suppliertype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WarSupplierType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SupplierType = table.Column<string>(maxLength: 1000, nullable: false),
                    SupplierDescription = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarSupplierType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WarSupplierType");
        }
    }
}
