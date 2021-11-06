using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SamaERP.Migrations
{
    public partial class initcreateg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarBranch",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BranchName = table.Column<string>(maxLength: 1000, nullable: true),
                    BranchAdresss = table.Column<string>(maxLength: 1000, nullable: false),
                    BranchCity = table.Column<string>(maxLength: 1000, nullable: false),
                    BranchCountry = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarBranch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarCustomer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CustomerName = table.Column<string>(maxLength: 1000, nullable: false),
                    CustomerType = table.Column<string>(nullable: false),
                    CustomerDepartment = table.Column<string>(maxLength: 1000, nullable: true),
                    CustomerDecription = table.Column<string>(maxLength: 1000, nullable: true),
                    CustomerPhoneNo = table.Column<string>(maxLength: 1000, nullable: true),
                    CustomerEmail = table.Column<string>(nullable: true),
                    CustomerAddress = table.Column<string>(maxLength: 1000, nullable: true),
                    CustomerCountry = table.Column<string>(maxLength: 1000, nullable: true),
                    CustomerCity = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarCustomer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarCustomerType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CustomerType = table.Column<string>(maxLength: 1000, nullable: false),
                    CustomerTypeDescription = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarCustomerType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarDeliverd",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SerialNo = table.Column<string>(nullable: true),
                    Barcode = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    BranchName = table.Column<string>(nullable: true),
                    WarehouseName = table.Column<string>(nullable: true),
                    DeliverDate = table.Column<DateTime>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderNumber = table.Column<string>(nullable: true),
                    ActiveOrNot = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarDeliverd", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    WarhouseName = table.Column<string>(maxLength: 1000, nullable: false),
                    WarehouseDescription = table.Column<string>(maxLength: 1000, nullable: true),
                    WarehouseBranch = table.Column<string>(nullable: false),
                    WarehouseAddress = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarProduct",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProductName = table.Column<string>(maxLength: 1000, nullable: false),
                    ProductDescription = table.Column<string>(maxLength: 1000, nullable: true),
                    ProductType = table.Column<string>(nullable: false),
                    Prod_MeasureUnit = table.Column<string>(nullable: false),
                    HasExpireDate = table.Column<bool>(nullable: false),
                    ProductExpireDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarProductType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    productType = table.Column<string>(maxLength: 1000, nullable: false),
                    productTypeDescription = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarProductType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarSupplier",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SupplierName = table.Column<string>(maxLength: 1000, nullable: false),
                    SupplierType = table.Column<string>(nullable: false),
                    SupplierDescription = table.Column<string>(maxLength: 1000, nullable: true),
                    SupplierPhoneNo = table.Column<string>(maxLength: 1000, nullable: true),
                    SupplierEmail = table.Column<string>(nullable: true),
                    SupplierAddress = table.Column<string>(maxLength: 1000, nullable: true),
                    SupplierCountry = table.Column<string>(maxLength: 1000, nullable: true),
                    SupplierCity = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarSupplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WarReceivedProduct",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ProductName = table.Column<string>(maxLength: 1000, nullable: false),
                    SNumber = table.Column<string>(maxLength: 1000, nullable: true),
                    ProductBarcode = table.Column<string>(maxLength: 1000, nullable: true),
                    ProductSupplier = table.Column<string>(nullable: false),
                    ProductUnit = table.Column<string>(nullable: false),
                    ProductQty = table.Column<int>(nullable: false),
                    BranchName = table.Column<string>(nullable: false),
                    WarehouseName = table.Column<string>(nullable: false),
                    ProductExpireDate = table.Column<DateTime>(nullable: false),
                    RecivedDate = table.Column<DateTime>(nullable: false),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    InvoiceDate = table.Column<DateTime>(nullable: false),
                    Product = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarReceivedProduct", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WarReceivedProduct_WarProduct_Product",
                        column: x => x.Product,
                        principalTable: "WarProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WarReceivedProduct_Product",
                table: "WarReceivedProduct",
                column: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "WarBranch");

            migrationBuilder.DropTable(
                name: "WarCustomer");

            migrationBuilder.DropTable(
                name: "WarCustomerType");

            migrationBuilder.DropTable(
                name: "WarDeliverd");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "WarProductType");

            migrationBuilder.DropTable(
                name: "WarReceivedProduct");

            migrationBuilder.DropTable(
                name: "WarSupplier");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "WarProduct");
        }
    }
}
