using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderTotal = table.Column<double>(type: "float", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeader", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                name: "AspNetUserPasskeys",
                columns: table => new
                {
                    CredentialId = table.Column<byte[]>(type: "varbinary(1024)", maxLength: 1024, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserPasskeys", x => x.CredentialId);
                    table.ForeignKey(
                        name: "FK_AspNetUserPasskeys_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrossAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialTag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_OrderHeader_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalTable: "OrderHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"), new Guid("a917aae2-d41a-ccf5-24e2-7bbcdc616c5b"), new DateTime(2026, 2, 14, 10, 7, 1, 11, DateTimeKind.Local).AddTicks(66), new Guid("a0928bb6-c3cd-96e5-db62-c0ed9adf4f5e"), new DateTime(2026, 2, 14, 10, 7, 1, 11, DateTimeKind.Local).AddTicks(71), "Games" },
                    { new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"), new Guid("36427b23-c94b-3806-f0cb-040f87b57cd4"), new DateTime(2026, 2, 14, 10, 7, 1, 3, DateTimeKind.Local).AddTicks(1721), new Guid("dc8dd8b6-db87-6282-6db9-6d206135fd19"), new DateTime(2026, 2, 14, 10, 7, 1, 8, DateTimeKind.Local).AddTicks(7224), "Books" },
                    { new Guid("28fa7d43-a972-cc5e-da01-06bd633d5911"), new Guid("62b33afd-17b3-d1df-1ab9-5917ba51d699"), new DateTime(2026, 2, 14, 10, 7, 1, 11, DateTimeKind.Local).AddTicks(131), new Guid("e0fa480c-85cc-1ae5-fab2-ab09e71ed010"), new DateTime(2026, 2, 14, 10, 7, 1, 11, DateTimeKind.Local).AddTicks(136), "Baby" },
                    { new Guid("3fad36d7-b10f-b541-05b3-adef06fe5c66"), new Guid("85dcab8e-5e9d-dc57-94cb-d8eef259ffca"), new DateTime(2026, 2, 14, 10, 7, 1, 11, DateTimeKind.Local).AddTicks(42), new Guid("4155ef45-9891-b8df-a321-a17a7b276f22"), new DateTime(2026, 2, 14, 10, 7, 1, 11, DateTimeKind.Local).AddTicks(47), "Grocery" },
                    { new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"), new Guid("2fc821e8-e60b-c51e-80cd-b71408314492"), new DateTime(2026, 2, 14, 10, 7, 1, 11, DateTimeKind.Local).AddTicks(88), new Guid("c815c61c-03ef-413d-07dc-68e167ba1f5f"), new DateTime(2026, 2, 14, 10, 7, 1, 11, DateTimeKind.Local).AddTicks(92), "Toys" },
                    { new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"), new Guid("edf6bfea-4fa7-e4e5-8628-2e7d3d5dc6ae"), new DateTime(2026, 2, 14, 10, 7, 1, 11, DateTimeKind.Local).AddTicks(110), new Guid("7f59c357-0b86-dbed-344d-382b92af8f21"), new DateTime(2026, 2, 14, 10, 7, 1, 11, DateTimeKind.Local).AddTicks(115), "Home" },
                    { new Guid("90a76fef-1a5c-2beb-d4a6-669a466a7406"), new Guid("41ab0485-aef9-a1b9-ddaf-2be42d783fd8"), new DateTime(2026, 2, 14, 10, 7, 1, 11, DateTimeKind.Local).AddTicks(21), new Guid("d6e569ee-2ea7-1728-7520-bfc647dde4e5"), new DateTime(2026, 2, 14, 10, 7, 1, 11, DateTimeKind.Local).AddTicks(25), "Sports" },
                    { new Guid("970a3739-d92a-3f5b-ba55-4488dea24542"), new Guid("d9554f26-4e7b-350b-f1c4-3f14d4464ebe"), new DateTime(2026, 2, 14, 10, 7, 1, 11, DateTimeKind.Local), new Guid("4c613284-6d94-77ad-2a50-6adebcb2eb50"), new DateTime(2026, 2, 14, 10, 7, 1, 11, DateTimeKind.Local).AddTicks(5), "Automotive" },
                    { new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"), new Guid("8e2c363e-0531-dc07-45a4-b9c99a839e04"), new DateTime(2026, 2, 14, 10, 7, 1, 10, DateTimeKind.Local).AddTicks(9959), new Guid("908551d8-3324-3a01-caf2-f03296f6e535"), new DateTime(2026, 2, 14, 10, 7, 1, 10, DateTimeKind.Local).AddTicks(9976), "Automotive" },
                    { new Guid("c1c28515-b9f4-4602-e42e-0c21a90061bf"), new Guid("30639e1a-6d4f-f948-e0c8-915ce6d7bbcd"), new DateTime(2026, 2, 14, 10, 7, 1, 10, DateTimeKind.Local).AddTicks(9612), new Guid("30727cea-13ba-1ec2-8b95-a3ad7541c3b9"), new DateTime(2026, 2, 14, 10, 7, 1, 10, DateTimeKind.Local).AddTicks(9682), "Movies" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedOn", "Description", "GrossAmount", "ImageUrl", "IsAvailable", "ModifiedById", "ModifiedOn", "Name", "NetAmount", "SKU", "SpecialTag", "Tag", "TaxAmount" },
                values: new object[,]
                {
                    { new Guid("08102d00-149d-33ec-c297-7cad0d600dec"), new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"), new Guid("e3eb4033-fd94-b3d1-b877-624c512a30a5"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4900), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 858.21m, "https://picsum.photos/640/480/?image=745", true, new Guid("f282ddd1-db58-6175-a2cf-219a11a14bc5"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4905), "Gorgeous Granite Pizza", 715.18m, "1542972212450", null, "Ergonomic", 143.03m },
                    { new Guid("0d5c4310-6327-87cc-11e2-9ac306ae28c5"), new Guid("28fa7d43-a972-cc5e-da01-06bd633d5911"), new Guid("fc21e135-7602-76d2-5edc-fb8e50f31ac6"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3543), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 383.46m, "https://picsum.photos/640/480/?image=213", true, new Guid("2c5c5c0f-cc5c-cccd-3878-e4bb1ac2806e"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3548), "Awesome Wooden Tuna", 319.55m, "3783596312449", null, "Ergonomic", 63.91m },
                    { new Guid("0f721871-560f-aa2c-a5ed-c2aacbd05930"), new Guid("c1c28515-b9f4-4602-e42e-0c21a90061bf"), new Guid("679a0b06-d23c-1fff-6396-40dd6ded6bd0"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2001), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 877.84m, "https://picsum.photos/640/480/?image=1038", true, new Guid("14894b19-373c-c047-9030-9e3608884318"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2006), "Practical Metal Mouse", 731.53m, "5495718864931", null, "Unbranded", 146.31m },
                    { new Guid("12592670-9907-c4ed-085e-0ef1b2405fa7"), new Guid("c1c28515-b9f4-4602-e42e-0c21a90061bf"), new Guid("30b3a64e-2ac8-fa57-83de-752ceabf3749"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2247), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 899.26m, "https://picsum.photos/640/480/?image=1029", true, new Guid("b46adabb-8c3b-48e6-7a3e-d05d09be0a25"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2251), "Small Steel Pants", 749.38m, "6529733835405", null, "Incredible", 149.88m },
                    { new Guid("136968fb-c354-9289-165c-9b5b8d1bc600"), new Guid("970a3739-d92a-3f5b-ba55-4488dea24542"), new Guid("6908922d-bbc3-1e77-8264-fb41c5f4450f"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3618), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 872.39m, "https://picsum.photos/640/480/?image=510", false, new Guid("21771cd6-da89-42df-6907-5a8912efdb22"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3623), "Intelligent Cotton Cheese", 726.99m, "2855399305353", null, "Licensed", 145.40m },
                    { new Guid("1396fdf4-8b0c-678e-c138-318e1c6d269d"), new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"), new Guid("3f78b887-12ec-717b-6b2b-5ae8ec315ba5"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1381), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 174.88m, "https://picsum.photos/640/480/?image=134", true, new Guid("014240d5-c066-bcea-8ee9-016a60dcec73"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1386), "Generic Soft Sausages", 145.73m, "1525576813414", null, "Gorgeous", 29.15m },
                    { new Guid("2f8f83ff-a46e-8751-ae2f-95596e555ba3"), new Guid("3fad36d7-b10f-b541-05b3-adef06fe5c66"), new Guid("4f9421e3-bd6a-1587-5ebd-9c2c4573f078"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3228), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 387.02m, "https://picsum.photos/640/480/?image=761", false, new Guid("2ec0f6f5-ca59-f97a-fd2f-87cac824d232"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3233), "Handmade Cotton Chair", 322.52m, "3015673464155", null, "Tasty", 64.50m },
                    { new Guid("33bc22ae-72a7-cc53-f73e-d2aa8cd8c2d0"), new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"), new Guid("293f5001-bbc4-027a-3885-35f5e102c866"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1752), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 730.66m, "https://picsum.photos/640/480/?image=34", true, new Guid("91f66403-32d0-5962-8480-16c33179d040"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1757), "Intelligent Wooden Cheese", 608.88m, "0198200797681", null, "Sleek", 121.78m },
                    { new Guid("422c9406-24d6-b0e7-6416-d15546cc2a63"), new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"), new Guid("d86cd36e-e70a-20d8-862d-5bbc6debdf71"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2490), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 667.10m, "https://picsum.photos/640/480/?image=1015", false, new Guid("5447ccc1-dc2e-3f08-2e40-305434fe7951"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2495), "Gorgeous Wooden Towels", 555.92m, "1335253597564", null, "Handmade", 111.18m },
                    { new Guid("44d304c8-998c-ce9c-d18a-c40c5d15f205"), new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"), new Guid("c86b0c02-123e-d9ce-e70e-59150d8bdd0a"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3145), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 840.81m, "https://picsum.photos/640/480/?image=616", true, new Guid("f3209e33-7381-fddc-23ec-8b20aa51b4eb"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3150), "Practical Concrete Tuna", 700.68m, "7119509822242", null, "Gorgeous", 140.13m },
                    { new Guid("45225765-56b2-caa6-ae96-a74ebaba0113"), new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"), new Guid("e1f8d956-2244-018b-d993-5f29e124fd4e"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4562), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 774.16m, "https://picsum.photos/640/480/?image=612", true, new Guid("cba1e551-06c7-950d-d2d5-a1cf5b659419"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4567), "Handcrafted Steel Hat", 645.13m, "7874186526233", null, "Fantastic", 129.03m },
                    { new Guid("56a6c83f-2cc6-f009-0c0e-00096b80e130"), new Guid("970a3739-d92a-3f5b-ba55-4488dea24542"), new Guid("9d6e0f51-3cfb-74e4-c877-d3e32d551753"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4825), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 38.57m, "https://picsum.photos/640/480/?image=199", true, new Guid("e1977261-4102-d007-880f-0921dd4ccac6"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4830), "Unbranded Soft Salad", 32.14m, "8709105779973", null, "Practical", 6.43m },
                    { new Guid("62b0c9cb-7454-a136-0028-cdb46047f66f"), new Guid("90a76fef-1a5c-2beb-d4a6-669a466a7406"), new Guid("d37a328e-a0cb-7940-f545-0e7964655bc4"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(50), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 758.42m, "https://picsum.photos/640/480/?image=495", true, new Guid("15582da3-0cca-5961-2e33-1cf875a32077"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(126), "Licensed Rubber Keyboard", 632.02m, "1991869257980", null, "Handmade", 126.40m },
                    { new Guid("66beb567-299d-6a7f-8767-157fd8f3b909"), new Guid("90a76fef-1a5c-2beb-d4a6-669a466a7406"), new Guid("d4346de5-ff1f-a2de-07e5-9fce4a10f6d3"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2987), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 636.13m, "https://picsum.photos/640/480/?image=421", true, new Guid("6acd4e68-cc64-30db-391f-61ccfc8c8daf"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2992), "Refined Steel Bike", 530.11m, "0632333759449", null, "Licensed", 106.02m },
                    { new Guid("6a6a2228-e15d-3338-cd37-a5a605f97cb3"), new Guid("28fa7d43-a972-cc5e-da01-06bd633d5911"), new Guid("7c8bf288-27f6-cb2d-b5d7-591b977e0fd6"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3460), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 232.71m, "https://picsum.photos/640/480/?image=209", false, new Guid("6c030151-2b70-64e5-182a-9f1be91b1352"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3464), "Tasty Plastic Table", 193.92m, "7540773957161", null, "Handcrafted", 38.79m },
                    { new Guid("75e20d06-4dd1-61c0-02eb-6ab8c3daf1e0"), new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"), new Guid("71ae4ad0-06be-ad34-31fc-0d67d0071640"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2661), "The Football Is Good For Training And Recreational Purposes", 473.24m, "https://picsum.photos/640/480/?image=349", true, new Guid("b71c4d80-8d5a-034e-9ada-108601fde3f2"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2666), "Fantastic Steel Computer", 394.37m, "3031488860388", null, "Awesome", 78.87m },
                    { new Guid("785e1b0c-3505-812c-ddb4-dd35dc5f3df3"), new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"), new Guid("0f972369-930c-8b83-93bf-1e1f1d83019c"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3937), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 172.76m, "https://picsum.photos/640/480/?image=867", true, new Guid("9a318818-17f2-34a2-3a64-ec3d606eac16"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3942), "Refined Metal Towels", 143.97m, "9755372282356", null, "Refined", 28.79m },
                    { new Guid("7ad9f75b-0784-dbcb-488f-2d0c1e234fc8"), new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"), new Guid("6ce97972-d14f-a50f-6778-a028da2c18e5"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2903), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 408.26m, "https://picsum.photos/640/480/?image=428", true, new Guid("e7a98e8e-b412-4c13-43cf-66883d51f8c7"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2907), "Gorgeous Soft Car", 340.22m, "9564130475455", null, "Tasty", 68.04m },
                    { new Guid("7f741402-bb55-2e57-ff4c-888aa916725e"), new Guid("3fad36d7-b10f-b541-05b3-adef06fe5c66"), new Guid("13877c5d-6d59-cb3c-9961-50b886b9d447"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3774), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 535.94m, "https://picsum.photos/640/480/?image=124", true, new Guid("b2217495-a89f-2798-1445-39bc3bc0356b"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3778), "Intelligent Wooden Chair", 446.62m, "5519609582442", null, "Practical", 89.32m },
                    { new Guid("80ed8341-4b96-f8b4-2dfc-d1d5c53c873c"), new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"), new Guid("80b5a55b-667c-c940-b664-3ccb86de4e61"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1916), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 916.35m, "https://picsum.photos/640/480/?image=871", false, new Guid("161725b1-e923-a695-294f-bb9bdbf4b970"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1921), "Ergonomic Plastic Towels", 763.62m, "5657221463982", null, "Awesome", 152.73m },
                    { new Guid("815201a2-d463-a7a7-452a-2513081bd557"), new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"), new Guid("83b90817-03b9-321f-5c1e-2d00928a1f51"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4016), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 519.42m, "https://picsum.photos/640/480/?image=793", true, new Guid("4661e858-68d9-8930-5cd1-51a8bf320ef1"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4020), "Intelligent Steel Computer", 432.85m, "0407486192463", null, "Fantastic", 86.57m },
                    { new Guid("8a27b0d6-f706-0c8d-2cff-674030b86f0a"), new Guid("28fa7d43-a972-cc5e-da01-06bd633d5911"), new Guid("7c4e8003-f930-6d2e-ff48-8e33efd8ae71"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1571), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 129.66m, "https://picsum.photos/640/480/?image=628", false, new Guid("51dfa4ab-465b-c99d-3d9a-caaf5def97db"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1576), "Fantastic Steel Car", 108.05m, "3483111891472", null, "Handmade", 21.61m },
                    { new Guid("8c66fb4a-1c66-f470-b060-02527a4fbca3"), new Guid("3fad36d7-b10f-b541-05b3-adef06fe5c66"), new Guid("874de2c5-ed3e-138e-fda5-02240b8e1e35"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3385), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 822.23m, "https://picsum.photos/640/480/?image=869", true, new Guid("9453cdd1-5a80-f077-a505-bac0db58fefd"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3390), "Sleek Concrete Chicken", 685.19m, "5065322970023", null, "Refined", 137.04m },
                    { new Guid("9118a44e-9a04-9e00-12a5-7b57ef86367e"), new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"), new Guid("f3ad8a1c-9365-6d48-23a6-88ffea5aba75"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3067), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 88.15m, "https://picsum.photos/640/480/?image=409", true, new Guid("6ef98902-4879-2045-5ac9-c576e35f992b"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3072), "Practical Frozen Towels", 73.46m, "9295038212841", null, "Licensed", 14.69m },
                    { new Guid("97676d23-837d-ab80-adb8-a9bdb8047439"), new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"), new Guid("74a3456c-208a-aa94-7fcd-c61b3a3bed94"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2169), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 295.75m, "https://picsum.photos/640/480/?image=263", true, new Guid("04cb9795-1213-9c33-db9d-5c8b4c71dc13"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2173), "Awesome Frozen Gloves", 246.46m, "7822872812788", null, "Licensed", 49.29m },
                    { new Guid("a619492c-519b-353a-bd4c-39ea6ac7a3aa"), new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"), new Guid("6b853458-337e-f8de-c8f0-d8ed4d8aacc0"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3308), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 835.97m, "https://picsum.photos/640/480/?image=815", false, new Guid("58379d5a-f1af-1ea8-4f0d-3e2d97c69e5d"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3313), "Awesome Wooden Bike", 696.64m, "3424811082845", null, "Handmade", 139.33m },
                    { new Guid("b35377a4-ffc6-60bc-ee0b-9389d9d0a85a"), new Guid("970a3739-d92a-3f5b-ba55-4488dea24542"), new Guid("8d966403-3037-493e-ef7a-213a3972856a"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3695), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 83.76m, "https://picsum.photos/640/480/?image=1062", false, new Guid("a6cc7e6a-8f46-40e4-d2df-023ffc66ef78"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3700), "Ergonomic Rubber Shirt", 69.8m, "5598367876895", null, "Intelligent", 13.96m },
                    { new Guid("b548326c-9ed4-ef9e-29a4-d1ee438592db"), new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"), new Guid("477375f9-6d50-181c-d67e-68578ad9e9dd"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4723), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 459.47m, "https://picsum.photos/640/480/?image=154", true, new Guid("52fa2f6b-5313-ad1e-1a47-7d100ad575fd"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4728), "Tasty Granite Chair", 382.89m, "1538092553047", null, "Handmade", 76.58m },
                    { new Guid("b820fa50-f7ea-6f58-4252-5599f894568f"), new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"), new Guid("8a73a64c-9f13-289e-5592-bad32251e6e9"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(5060), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 388.01m, "https://picsum.photos/640/480/?image=332", true, new Guid("37090c5f-3483-b134-0516-547b25424742"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(5065), "Gorgeous Granite Hat", 323.34m, "0905576586159", null, "Rustic", 64.67m },
                    { new Guid("ba84000d-e7df-f9d3-0c48-b6767f38c877"), new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"), new Guid("3f434505-bed6-7582-e637-60d391264913"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4175), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 66.45m, "https://picsum.photos/640/480/?image=734", true, new Guid("cd76c568-2ca0-c352-2430-b72235d6f2f3"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4179), "Handcrafted Frozen Sausages", 55.38m, "6871145860507", null, "Sleek", 11.07m },
                    { new Guid("bfc26cab-b66a-5989-f9f1-c4d4501b1f43"), new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"), new Guid("69cbd4c8-e524-fddc-be25-b96487374388"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2325), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 11.85m, "https://picsum.photos/640/480/?image=191", false, new Guid("5e654e32-afb9-3909-e7ec-d66cca54d2a4"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2329), "Unbranded Cotton Mouse", 9.88m, "8204236225134", null, "Handmade", 1.97m },
                    { new Guid("c4cff344-d6da-340b-c917-da5328c54e46"), new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"), new Guid("61e04707-fbea-8ae9-ceaa-42f3e6b416f6"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2088), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 358.06m, "https://picsum.photos/640/480/?image=1027", false, new Guid("2ad3d1c2-a0d8-62af-de69-4f3bd125ec89"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2093), "Refined Frozen Table", 298.38m, "6233211626071", null, "Rustic", 59.68m },
                    { new Guid("ca1989c0-8191-0e38-7033-6a5214a982d8"), new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"), new Guid("9dc31d52-cf9f-adf5-c43d-c21a13be8db2"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2412), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 834.17m, "https://picsum.photos/640/480/?image=553", true, new Guid("7bfaefd1-2644-edda-79b7-1f9197f2e77b"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2416), "Licensed Plastic Mouse", 695.14m, "4615527978396", null, "Refined", 139.03m },
                    { new Guid("ca58931b-418a-dbc4-36a2-172b9d978766"), new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"), new Guid("87bde9c3-957f-8afc-4fae-01ee88333ac5"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4985), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 221.55m, "https://picsum.photos/640/480/?image=334", true, new Guid("3699e81b-a36b-d230-9026-26b938fa1509"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4989), "Tasty Cotton Soap", 184.62m, "4818111480347", null, "Rustic", 36.93m },
                    { new Guid("cb4f4c36-0e62-816f-bba5-74ff456a8004"), new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"), new Guid("8a0b503d-ff5f-9ba5-ef9e-55ec17370267"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4646), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 855.17m, "https://picsum.photos/640/480/?image=1009", false, new Guid("148800be-f4d1-379a-ebc0-0f7cf61eb012"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4651), "Incredible Granite Towels", 712.64m, "7433192007930", null, "Tasty", 142.53m },
                    { new Guid("cb9134d5-a92d-b7ca-83ec-88b30aec1fb3"), new Guid("3fad36d7-b10f-b541-05b3-adef06fe5c66"), new Guid("28745dfb-9928-1f22-5f77-02fdb71dd36a"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2569), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 430.05m, "https://picsum.photos/640/480/?image=725", true, new Guid("19faccff-18a5-a3e7-da67-372034f5be3f"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2574), "Small Concrete Soap", 358.38m, "3455247610630", null, "Handcrafted", 71.67m },
                    { new Guid("cec63725-b0bb-1002-1010-8e3fe6ecc58d"), new Guid("28fa7d43-a972-cc5e-da01-06bd633d5911"), new Guid("1a15ba5a-7e60-1841-098b-e96e718dd423"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1485), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 198.93m, "https://picsum.photos/640/480/?image=778", false, new Guid("efd7480f-32dd-0f2f-22d2-721419a14ab9"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1490), "Incredible Granite Chair", 165.78m, "4341625252266", null, "Handmade", 33.15m },
                    { new Guid("cef0e16a-77d0-4986-6085-69245c4eca1c"), new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"), new Guid("c641eb9a-199a-4d1e-3b64-6ea5269b5aaf"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1288), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 18.51m, "https://picsum.photos/640/480/?image=797", true, new Guid("d53d5dc0-031e-34d7-3b0c-b15c1509d551"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1293), "Fantastic Cotton Shoes", 15.42m, "8292252287243", null, "Unbranded", 3.09m },
                    { new Guid("d182a4e1-a421-8397-4703-522596a895e2"), new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"), new Guid("866838bd-8b2d-9f93-52f3-71f6822b6b93"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1161), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 835.39m, "https://picsum.photos/640/480/?image=902", true, new Guid("2af088ed-cc00-976a-0fa7-423319e8ce14"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1169), "Handmade Metal Gloves", 696.16m, "5188855047977", null, "Sleek", 139.23m },
                    { new Guid("d766faa4-37fc-32e1-c194-4522a38f8e04"), new Guid("c1c28515-b9f4-4602-e42e-0c21a90061bf"), new Guid("98ab5d23-44ab-2e29-1bb0-1511e2207b59"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4325), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 989.55m, "https://picsum.photos/640/480/?image=284", true, new Guid("489357de-96b9-566e-b779-84ea0420544e"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4330), "Unbranded Cotton Chicken", 824.62m, "7751870336937", null, "Sleek", 164.93m },
                    { new Guid("d7ae7e8e-272f-b1e8-7672-29103b7190ee"), new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"), new Guid("7488ede6-64c1-43b9-ebe2-b5bc969deb77"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4098), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 963.58m, "https://picsum.photos/640/480/?image=630", true, new Guid("830037ee-61ed-a833-8cee-6badfb346b36"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4102), "Tasty Rubber Table", 802.98m, "6030968928812", null, "Generic", 160.60m },
                    { new Guid("dc75941a-81bf-9e2b-280e-b94f4712882a"), new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"), new Guid("431bb06d-4479-5477-9867-006bd5e9fce8"), new DateTime(2026, 2, 14, 10, 7, 1, 14, DateTimeKind.Local).AddTicks(9558), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 452.36m, "https://picsum.photos/640/480/?image=885", false, new Guid("bda03848-bc61-c64d-ce42-a3772ccbb3a0"), new DateTime(2026, 2, 14, 10, 7, 1, 15, DateTimeKind.Local).AddTicks(3217), "Handcrafted Frozen Chicken", 376.97m, "2674098486848", null, "Ergonomic", 75.39m },
                    { new Guid("df6bba4b-cbbe-b114-9d37-bd9f4103db1e"), new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"), new Guid("931340e8-9f76-540b-7460-b4282eb4a111"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2825), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 979.67m, "https://picsum.photos/640/480/?image=24", true, new Guid("80fa7a3d-0f26-8fc5-8cab-c3c2c4475496"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2829), "Tasty Cotton Cheese", 816.39m, "8464625408535", null, "Rustic", 163.28m },
                    { new Guid("e3b4bfc0-fe60-3414-7f90-d82ce4046990"), new Guid("970a3739-d92a-3f5b-ba55-4488dea24542"), new Guid("ca4eb027-da8d-c2f6-a5bc-759df344faca"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3860), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 564.06m, "https://picsum.photos/640/480/?image=285", true, new Guid("5df37601-c974-4837-9560-58180ec78699"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(3865), "Refined Frozen Pizza", 470.05m, "5664665197601", null, "Tasty", 94.01m },
                    { new Guid("e3bcaf1d-3f84-2f96-7f0f-0fb1b304779f"), new Guid("c1c28515-b9f4-4602-e42e-0c21a90061bf"), new Guid("c08a90c3-cf01-baa1-df60-e27d765e675a"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1655), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 331.61m, "https://picsum.photos/640/480/?image=1057", false, new Guid("c812010b-067c-e25c-4ead-02aa7c0cb556"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1660), "Intelligent Steel Shirt", 276.34m, "8860676210668", null, "Rustic", 55.27m },
                    { new Guid("edcf0031-a5e6-a443-b7d0-bfb4f5ff915b"), new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"), new Guid("367a0064-e903-3716-3f1c-2595214dc6d2"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1838), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 418.80m, "https://picsum.photos/640/480/?image=832", true, new Guid("50c45ea8-76d7-e37f-ea4e-f0e93b6e475f"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(1843), "Small Soft Gloves", 349.0m, "5524253246596", null, "Generic", 69.80m },
                    { new Guid("ee9598c0-8f7a-e594-7218-34da8284d74a"), new Guid("c1c28515-b9f4-4602-e42e-0c21a90061bf"), new Guid("8995d326-2190-2f49-ebc6-40c024fda299"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4486), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 547.75m, "https://picsum.photos/640/480/?image=997", true, new Guid("72e45ae4-03f2-e28d-33ea-569b98447885"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4490), "Awesome Frozen Car", 456.46m, "0086365790954", null, "Ergonomic", 91.29m },
                    { new Guid("ef8d4b46-e154-c032-3e29-fa5cc76aab95"), new Guid("970a3739-d92a-3f5b-ba55-4488dea24542"), new Guid("d93bf991-7733-d981-2234-e728e2d118db"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4408), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 649.61m, "https://picsum.photos/640/480/?image=1072", true, new Guid("eb605207-fbfd-c10b-4a9e-910ec1ee5a65"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4413), "Handcrafted Plastic Salad", 541.34m, "2553487451806", null, "Awesome", 108.27m },
                    { new Guid("f3d8d7fb-1b7f-06a6-6040-0f446d802fa4"), new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"), new Guid("2ba435de-4f28-5891-a93c-23c8d12491c7"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4249), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 629.99m, "https://picsum.photos/640/480/?image=372", false, new Guid("8a573139-78a9-a85e-f347-1dcfc3641980"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(4254), "Fantastic Rubber Bacon", 524.99m, "7218596906061", null, "Practical", 105.00m },
                    { new Guid("fc42863a-d6aa-f6e3-aeac-33181b594abf"), new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"), new Guid("1ab43a42-dd1d-4825-79c3-414916b0d7c4"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2744), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 600.66m, "https://picsum.photos/640/480/?image=444", true, new Guid("ffd3346e-d605-f55b-4f09-2b8810bb2400"), new DateTime(2026, 2, 14, 10, 7, 1, 24, DateTimeKind.Local).AddTicks(2749), "Unbranded Metal Towels", 500.55m, "7375041683431", null, "Incredible", 100.11m }
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
                name: "IX_AspNetUserPasskeys_UserId",
                table: "AspNetUserPasskeys",
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
                name: "IX_OrderDetail_OrderHeaderId",
                table: "OrderDetail",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_ProductId",
                table: "ShoppingCart",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_UserId",
                table: "ShoppingCart",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserPasskeys");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "ShoppingCart");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "OrderHeader");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
