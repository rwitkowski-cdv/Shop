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
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
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
                    { new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"), new Guid("a917aae2-d41a-ccf5-24e2-7bbcdc616c5b"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2940), new Guid("a0928bb6-c3cd-96e5-db62-c0ed9adf4f5e"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2944), "Games" },
                    { new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"), new Guid("36427b23-c94b-3806-f0cb-040f87b57cd4"), new DateTime(2026, 2, 12, 2, 7, 24, 37, DateTimeKind.Local).AddTicks(2613), new Guid("dc8dd8b6-db87-6282-6db9-6d206135fd19"), new DateTime(2026, 2, 12, 2, 7, 24, 42, DateTimeKind.Local).AddTicks(3883), "Books" },
                    { new Guid("28fa7d43-a972-cc5e-da01-06bd633d5911"), new Guid("62b33afd-17b3-d1df-1ab9-5917ba51d699"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(3008), new Guid("e0fa480c-85cc-1ae5-fab2-ab09e71ed010"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(3012), "Baby" },
                    { new Guid("3fad36d7-b10f-b541-05b3-adef06fe5c66"), new Guid("85dcab8e-5e9d-dc57-94cb-d8eef259ffca"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2921), new Guid("4155ef45-9891-b8df-a321-a17a7b276f22"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2925), "Grocery" },
                    { new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"), new Guid("2fc821e8-e60b-c51e-80cd-b71408314492"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2958), new Guid("c815c61c-03ef-413d-07dc-68e167ba1f5f"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2962), "Toys" },
                    { new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"), new Guid("edf6bfea-4fa7-e4e5-8628-2e7d3d5dc6ae"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2977), new Guid("7f59c357-0b86-dbed-344d-382b92af8f21"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2993), "Home" },
                    { new Guid("90a76fef-1a5c-2beb-d4a6-669a466a7406"), new Guid("41ab0485-aef9-a1b9-ddaf-2be42d783fd8"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2901), new Guid("d6e569ee-2ea7-1728-7520-bfc647dde4e5"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2905), "Sports" },
                    { new Guid("970a3739-d92a-3f5b-ba55-4488dea24542"), new Guid("d9554f26-4e7b-350b-f1c4-3f14d4464ebe"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2881), new Guid("4c613284-6d94-77ad-2a50-6adebcb2eb50"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2886), "Automotive" },
                    { new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"), new Guid("8e2c363e-0531-dc07-45a4-b9c99a839e04"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2843), new Guid("908551d8-3324-3a01-caf2-f03296f6e535"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2856), "Automotive" },
                    { new Guid("c1c28515-b9f4-4602-e42e-0c21a90061bf"), new Guid("30639e1a-6d4f-f948-e0c8-915ce6d7bbcd"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2617), new Guid("30727cea-13ba-1ec2-8b95-a3ad7541c3b9"), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2648), "Movies" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedOn", "Description", "GrossAmount", "ImageUrl", "IsAvailable", "ModifiedById", "ModifiedOn", "Name", "NetAmount", "SKU", "Tag", "TaxAmount" },
                values: new object[,]
                {
                    { new Guid("0ad86cd3-d8e7-8620-2d5b-bc6debdf71c1"), new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"), new Guid("2e5447cc-08dc-2e3f-4030-5434fe7951d0"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2564), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 127.60m, "https://loremflickr.com/640/480/computer/any?lock=194593957", true, new Guid("14e4374e-a44d-bb1f-0cbc-a8c82b427837"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2568), "Practical Fresh Cheese", 106.33m, "2677119148121", "Ergonomic", 21.27m },
                    { new Guid("0d15590e-dd8b-330a-9e20-f38173dcfd23"), new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"), new Guid("aa208bec-b451-c0eb-b2e8-f9e99e4eb636"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3237), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 141.94m, "https://loremflickr.com/640/480/computer/any?lock=940947928", true, new Guid("407e5df9-c087-ac45-b9d9-bff4ff838f2f"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3243), "Handcrafted Fresh Table", 118.28m, "0381521618395", "Gorgeous", 23.66m },
                    { new Guid("0f0f7f2f-b3b1-7704-9fc3-908ac001cfa1"), new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"), new Guid("e260dfba-767d-675e-5a0b-0112c87c065c"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1614), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 404.84m, "https://loremflickr.com/640/480/computer/any?lock=53376622", true, new Guid("02ad4ee2-7caa-b50c-56a5-b48d650acbd8"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1619), "Generic Metal Tuna", 337.37m, "2106693181151", "Tasty", 67.47m },
                    { new Guid("101002b0-8e10-e63f-ecc5-8d5aba151a60"), new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"), new Guid("0918417e-e98b-716e-8dd4-230f48d7efdd"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1441), "The Football Is Good For Training And Recreational Purposes", 598.82m, "https://loremflickr.com/640/480/computer/any?lock=103633141", false, new Guid("220f2f32-72d2-1914-a14a-b9b50283d1a3"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1446), "Sleek Wooden Tuna", 499.02m, "2525226719874", "Intelligent", 99.80m },
                    { new Guid("12b01ef6-8567-085b-f24b-b937a6b4dcc4"), new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"), new Guid("846982b8-0da2-4440-e26c-3248b5d49e9e"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4833), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 820.49m, "https://loremflickr.com/640/480/computer/any?lock=1513941903", true, new Guid("d1a429ef-43ee-9285-dbf9-757347506d1c"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4838), "Unbranded Fresh Shoes", 683.74m, "8493748576340", "Ergonomic", 136.75m },
                    { new Guid("1d47f3a8-c3cf-1964-8038-421f6d6a8e98"), new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"), new Guid("497f45ab-f743-35de-3bae-480a3b29a4fa"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4423), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9.06m, "https://loremflickr.com/640/480/computer/any?lock=1201939499", true, new Guid("37fcd766-32e1-94c1-4522-a38f8e04235d"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4428), "Intelligent Fresh Salad", 7.55m, "9811685067445", "Intelligent", 1.51m },
                    { new Guid("1f82c6ca-e368-7613-8e03-e4318d4e5825"), new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"), new Guid("adf7b7c2-f8a7-00e9-2d10-089d14ec33c2"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(5003), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 240.32m, "https://loremflickr.com/640/480/computer/any?lock=1281508560", true, new Guid("0dad7c97-0d60-33ec-40eb-e394fdd1b3b8"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(5008), "Handcrafted Soft Ball", 200.27m, "9142517081804", "Ergonomic", 40.05m },
                    { new Guid("3024c352-22b7-d635-f2f3-5261816bddc3"), new Guid("c1c28515-b9f4-4602-e42e-0c21a90061bf"), new Guid("0f7d4e9a-a8d3-0087-68e6-fea30eb9c1fb"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4333), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 417.16m, "https://loremflickr.com/640/480/computer/any?lock=1400381980", true, new Guid("7ff3d8d7-a61b-6006-400f-446d802fa4de"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4338), "Handcrafted Cotton Pants", 347.63m, "7707667227674", "Ergonomic", 69.53m },
                    { new Guid("3406be71-31ad-0dfc-67d0-071640804d1c"), new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"), new Guid("4e8d5ab7-9a03-10da-8601-fde3f20e8648"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2729), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 673.67m, "https://loremflickr.com/640/480/computer/any?lock=966953299", false, new Guid("33cc06d3-d9ff-4434-d440-5990fad52938"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2734), "Awesome Soft Towels", 561.39m, "1834694018763", "Ergonomic", 112.28m },
                    { new Guid("351e8e0b-cdd1-9453-805a-77f0a505bac0"), new Guid("90a76fef-1a5c-2beb-d4a6-669a466a7406"), new Guid("fdfe58db-8f2b-96da-4345-515d6d538ec1"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3492), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 758.35m, "https://loremflickr.com/640/480/computer/any?lock=1373395094", true, new Guid("22e94c19-cc41-ac81-fb28-226a6a5de138"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3497), "Small Metal Soap", 631.96m, "3652243673540", "Refined", 126.39m },
                    { new Guid("3cc5d5d1-3c87-a55b-b580-7c6640c9b664"), new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"), new Guid("de86cb3c-614e-25b1-1716-23e995a6294f"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1872), "The Football Is Good For Training And Recreational Purposes", 802.24m, "https://loremflickr.com/640/480/computer/any?lock=457254391", true, new Guid("f4db9bbb-70b9-2dfb-ae47-5616bddb4324"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1877), "Fantastic Rubber Pants", 668.53m, "9889795667183", "Refined", 133.71m },
                    { new Guid("44989b56-8578-2206-ea4c-c0eb799f4f66"), new Guid("3fad36d7-b10f-b541-05b3-adef06fe5c66"), new Guid("d34fb302-74c0-9a76-f627-a065572245b2"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4670), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 907.58m, "https://loremflickr.com/640/480/computer/any?lock=731101980", false, new Guid("aecaa656-a796-ba4e-ba01-1356d9f8e144"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4675), "Licensed Soft Computer", 756.32m, "8855959005529", "Small", 151.26m },
                    { new Guid("464ec528-4707-61e0-eafb-e98aceaa42f3"), new Guid("3fad36d7-b10f-b541-05b3-adef06fe5c66"), new Guid("f616b4e6-d1c2-2ad3-d8a0-af62de694f3b"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2046), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 725.26m, "https://loremflickr.com/640/480/computer/any?lock=2004088384", true, new Guid("89ec25d1-71ee-aa7a-b11f-5c490a44f52f"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2051), "Generic Steel Fish", 604.38m, "9329176808830", "Tasty", 120.88m },
                    { new Guid("4825dd1d-c379-4941-16b0-d7c46e34d3ff"), new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"), new Guid("f55bd605-094f-882b-10bb-2400453a92ee"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2817), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 841.11m, "https://loremflickr.com/640/480/computer/any?lock=626823057", true, new Guid("5da05a84-fa60-e682-959a-e0fdd46faae7"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2822), "Gorgeous Steel Shirt", 700.92m, "9145270781165", "Handmade", 140.19m },
                    { new Guid("51d60f7e-0301-706c-2be5-64182a9f1be9"), new Guid("90a76fef-1a5c-2beb-d4a6-669a466a7406"), new Guid("6c52131b-b96f-f5d9-3005-00f59eb48687"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3573), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 450.73m, "https://loremflickr.com/640/480/computer/any?lock=134655684", true, new Guid("284f9b1d-54ce-f503-1043-5c0d2763cc87"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3578), "Generic Plastic Chicken", 375.61m, "6980052286505", "Fantastic", 75.12m },
                    { new Guid("5462b0c9-3674-00a1-28cd-b46047f66f8e"), new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"), new Guid("cbd37a32-40a0-f579-450e-7964655bc4a3"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(532), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 229.82m, "https://loremflickr.com/640/480/computer/any?lock=1887826662", true, new Guid("ca15582d-610c-2e59-331c-f875a32077d1"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(561), "Awesome Wooden Keyboard", 191.52m, "9918692579845", "Practical", 38.30m },
                    { new Guid("59d0cbaa-0630-9a0b-673c-d2ff1f639640"), new Guid("90a76fef-1a5c-2beb-d4a6-669a466a7406"), new Guid("6bed6ddd-19d0-894b-143c-3747c090309e"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1965), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 852.43m, "https://loremflickr.com/640/480/computer/any?lock=1777510507", true, new Guid("43880836-1818-a71e-6489-38e99e1952ac"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1970), "Handcrafted Cotton Salad", 710.36m, "3986381770015", "Tasty", 142.07m },
                    { new Guid("5c0fc61a-2c5c-cc5c-cdcc-3878e4bb1ac2"), new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"), new Guid("8a736e80-edf2-0633-f399-70e5ae4b683d"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3670), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 430.88m, "https://loremflickr.com/640/480/computer/any?lock=119580478", false, new Guid("d4c71e37-aab3-fb51-6869-1354c3899216"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3674), "Awesome Frozen Soap", 359.07m, "1127639543216", "Generic", 71.81m },
                    { new Guid("678e8b0c-38c1-8e31-1c6d-269d87b8783f"), new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"), new Guid("717b12ec-2b6b-e85a-ec31-5ba5d5404201"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1343), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 364.97m, "https://loremflickr.com/640/480/computer/any?lock=1378317037", false, new Guid("bceac066-e98e-6a01-60dc-ec73fc26a301"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1348), "Sleek Concrete Towels", 304.14m, "5768134111805", "Sleek", 60.83m },
                    { new Guid("6c397404-a345-8a74-2094-aa7fcdc61b3a"), new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"), new Guid("9594ed3b-cb97-1304-1233-9cdb9d5c8b4c"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2128), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 316.02m, "https://loremflickr.com/640/480/computer/any?lock=773463709", true, new Guid("da13dc71-94da-ed9e-e267-02d9bc17b0bd"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2132), "Handmade Fresh Bike", 263.35m, "2017205211306", "Generic", 52.67m },
                    { new Guid("73452c9c-78f0-f6f5-c02e-59ca7af9fd2f"), new Guid("970a3739-d92a-3f5b-ba55-4488dea24542"), new Guid("24c8ca87-32d2-a264-c998-44708a42fb7a"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3319), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 861.36m, "https://loremflickr.com/640/480/computer/any?lock=1090943934", false, new Guid("2508b1d1-3a41-1c3f-6377-942c4919a69b"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3331), "Generic Soft Table", 717.8m, "5359350618478", "Refined", 143.56m },
                    { new Guid("74540b9f-b460-2e28-b4a1-113d7afa8026"), new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"), new Guid("8c8fc50f-c3ab-c4c2-4754-9604dfeb2e97"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2900), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 706.76m, "https://loremflickr.com/640/480/computer/any?lock=792656923", true, new Guid("afab0e53-6a17-165e-eb83-e995ac62c608"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2904), "Rustic Cotton Ball", 588.97m, "3134975010607", "Gorgeous", 117.79m },
                    { new Guid("771cd60f-8921-dfda-4269-075a8912efdb"), new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"), new Guid("991d7122-aa42-8e40-40f0-4a90f0c848cc"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3751), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 490.80m, "https://loremflickr.com/640/480/computer/any?lock=1458362045", true, new Guid("848c1621-a370-77a4-53b3-c6ffbc60ee0b"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3756), "Fantastic Plastic Keyboard", 409.0m, "2484228496728", "Generic", 81.80m },
                    { new Guid("7867a50f-28a0-2cda-18e5-8e8ea9e712b4"), new Guid("970a3739-d92a-3f5b-ba55-4488dea24542"), new Guid("cf434c13-8866-513d-f8c7-342023327859"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2980), "The Football Is Good For Training And Recreational Purposes", 471.38m, "https://loremflickr.com/640/480/computer/any?lock=1280387826", true, new Guid("34e88ab9-0b12-a366-011c-77477e8f7967"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2986), "Licensed Cotton Pants", 392.82m, "2555079587634", "Handcrafted", 78.56m },
                    { new Guid("8677d0ce-6049-6985-245c-4eca1c9aeb41"), new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"), new Guid("1e199ac6-3b4d-6e64-a526-9b5aafc05d3d"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1248), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 616.48m, "https://loremflickr.com/640/480/computer/any?lock=1092378033", false, new Guid("d7031ed5-3b34-b10c-5c15-09d55137fffd"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1253), "Licensed Concrete Sausages", 513.73m, "2252287247083", "Refined", 102.75m },
                    { new Guid("893068d9-d15c-a851-bf32-0ef18f029c39"), new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"), new Guid("9f74d063-1fe1-4425-a7a7-14bb0bd4ba1f"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4169), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 751.27m, "https://loremflickr.com/640/480/computer/any?lock=1799125237", true, new Guid("ae7e8eba-2fd7-e827-b176-7229103b7190"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4174), "Rustic Wooden Soap", 626.06m, "6098757624000", "Generic", 125.21m },
                    { new Guid("8ca83361-6bee-fbad-346b-3683cd25e632"), new Guid("3fad36d7-b10f-b541-05b3-adef06fe5c66"), new Guid("c429f8ab-eb6a-714d-2b1b-d986b1210370"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4252), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 541.24m, "https://loremflickr.com/640/480/computer/any?lock=485236341", true, new Guid("ba84000d-e7df-f9d3-0c48-b6767f38c877"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4257), "Small Frozen Table", 451.03m, "8599320515094", "Generic", 90.21m },
                    { new Guid("94655bcf-be19-2061-c0fd-455b42cb216b"), new Guid("c1c28515-b9f4-4602-e42e-0c21a90061bf"), new Guid("e87df61e-9889-fd59-d518-364c4fcb620e"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4750), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 280.93m, "https://loremflickr.com/640/480/computer/any?lock=14341253", false, new Guid("a5bb816f-ff74-6a45-8004-3d500b8a5fff"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4755), "Handcrafted Wooden Chicken", 234.11m, "9679064790410", "Unbranded", 46.82m },
                    { new Guid("99282874-1f22-775f-02fd-b71dd36affcc"), new Guid("c1c28515-b9f4-4602-e42e-0c21a90061bf"), new Guid("18a519fa-a3e7-67da-3720-34f5be3f23c5"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2648), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 908.94m, "https://loremflickr.com/640/480/computer/any?lock=567325725", true, new Guid("511f033c-3c5b-7112-6bb6-a7cc0066181e"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2653), "Intelligent Metal Hat", 757.45m, "3818088806493", "Handmade", 151.49m },
                    { new Guid("9cac1b73-e92b-5bb1-f763-573c854cf16b"), new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"), new Guid("8bec396b-0c1e-7117-c284-fc4b2303134a"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(5253), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 940.76m, "https://loremflickr.com/640/480/computer/any?lock=973522437", false, new Guid("36afd678-4c3a-2234-57dc-8bd1dc7480ca"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(5258), "Small Metal Shirt", 783.97m, "3629153508415", "Incredible", 156.79m },
                    { new Guid("9dc31d52-cf9f-adf5-c43d-c21a13be8db2"), new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"), new Guid("7bfaefd1-2644-edda-79b7-1f9197f2e77b"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2474), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 527.49m, "https://loremflickr.com/640/480/computer/any?lock=2011485800", true, new Guid("1f5be94e-64de-f016-946b-0553bf1dfab1"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2479), "Refined Fresh Pants", 439.58m, "8883591493282", "Fantastic", 87.91m },
                    { new Guid("9fb22174-98a8-1427-4539-bc3bc0356bb4"), new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"), new Guid("97ac291d-a947-d894-a8e6-f36b9ea74678"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3918), "The Football Is Good For Training And Recreational Purposes", 377.62m, "https://loremflickr.com/640/480/computer/any?lock=1795832910", false, new Guid("f434f540-bfc0-e3b4-60fe-14347f90d82c"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3923), "Refined Soft Soap", 314.68m, "1620810040097", "Ergonomic", 62.94m },
                    { new Guid("9fe507a2-4ace-f610-d368-4ecd6a64ccdb"), new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"), new Guid("611f3930-fccc-8d8c-af47-1392da49bb5a"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3071), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 857.60m, "https://loremflickr.com/640/480/computer/any?lock=1279373508", true, new Guid("5e1cd767-89b7-20b1-7671-42168a264ea4"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3076), "Generic Frozen Shirt", 714.67m, "6030439929409", "Gorgeous", 142.93m },
                    { new Guid("a217f29a-3a34-ec64-3d60-6eac1603472b"), new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"), new Guid("045e93e9-9778-e5d3-4516-0d6459b3411d"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4080), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 16.21m, "https://loremflickr.com/640/480/computer/any?lock=1337949124", true, new Guid("01a22e53-8152-d463-a7a7-452a2513081b"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4085), "Fantastic Soft Car", 13.51m, "4883025113360", "Practical", 2.70m },
                    { new Guid("a421d182-8397-0347-5225-96a895e2bd38"), new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"), new Guid("8b2d8668-9f93-f352-71f6-822b6b93ed88"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1120), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 485.71m, "https://loremflickr.com/640/480/computer/any?lock=1067997728", true, new Guid("cc002af0-976a-a70f-4233-19e8ce14a7b7"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1129), "Incredible Granite Mouse", 404.76m, "8885504797883", "Unbranded", 80.95m },
                    { new Guid("a64ea75f-30b3-2ac8-57fa-83de752ceabf"), new Guid("c1c28515-b9f4-4602-e42e-0c21a90061bf"), new Guid("dabb4937-b46a-8c3b-e648-7a3ed05d09be"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2300), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 706.52m, "https://loremflickr.com/640/480/computer/any?lock=1308798460", true, new Guid("cb11250a-6e7c-f074-7045-cf5e8e2823c0"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2305), "Ergonomic Frozen Salad", 588.77m, "4231303663739", "Awesome", 117.75m },
                    { new Guid("a6cc7e6a-8f46-40e4-d2df-023ffc66ef78"), new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"), new Guid("2813c624-e2ee-736b-3809-c34bde81267b"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3830), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 770.07m, "https://loremflickr.com/640/480/computer/any?lock=713057751", true, new Guid("5a1e2886-0203-7414-7f55-bb572eff4c88"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3834), "Tasty Wooden Shirt", 641.72m, "8801304553085", "Licensed", 128.35m },
                    { new Guid("aad23ef7-d88c-d0c2-0150-3f29c4bb7a02"), new Guid("90a76fef-1a5c-2beb-d4a6-669a466a7406"), new Guid("f5358538-02e1-66c8-0364-f691d0326259"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1706), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 197.83m, "https://loremflickr.com/640/480/computer/any?lock=1158922983", true, new Guid("c3168084-7931-40d0-f650-a66466882df3"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1711), "Small Steel Cheese", 164.86m, "9768074247318", "Generic", 32.97m },
                    { new Guid("ac8a4ded-5ac0-379d-58af-f1a81e4f0d3e"), new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"), new Guid("9ec6972d-9e5d-e790-e7de-0c16f96b21de"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3407), "The Football Is Good For Training And Recreational Purposes", 435.00m, "https://loremflickr.com/640/480/computer/any?lock=791306505", true, new Guid("e84c79aa-9f32-9078-cc8f-4afb668c661c"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3412), "Licensed Soft Salad", 362.5m, "8177495128105", "Tasty", 72.50m },
                    { new Guid("c10e919e-5aee-a465-0b87-f20872c8cfc9"), new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"), new Guid("fa1fccb3-de09-106c-1f55-750ac09895ee"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4581), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 819.77m, "https://loremflickr.com/640/480/computer/any?lock=580979654", false, new Guid("e5948f7a-1872-da34-8284-d74a26d39589"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4586), "Licensed Concrete Ball", 683.14m, "0685989064900", "Sleek", 136.63m },
                    { new Guid("c3cab5c5-bb6d-5514-025c-5c5026b2a0e1"), new Guid("90a76fef-1a5c-2beb-d4a6-669a466a7406"), new Guid("dcd76698-dd30-931b-58ca-8a41c4db36a2"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(5085), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 785.29m, "https://loremflickr.com/640/480/computer/any?lock=5857132", true, new Guid("979d2b17-6687-e9c3-bd87-7f95fc8a4fae"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(5090), "Handmade Wooden Towels", 654.41m, "4206076809684", "Ergonomic", 130.88m },
                    { new Guid("c9745df3-4837-6095-5818-0ec786993db5"), new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"), new Guid("69a79050-e667-f1c9-3ea3-8876413b950d"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3999), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 5.95m, "https://loremflickr.com/640/480/computer/any?lock=1187165582", true, new Guid("0c116d2b-5e1b-0578-352c-81ddb4dd35dc"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4004), "Licensed Concrete Hat", 4.96m, "9344773157938", "Fantastic", 0.99m },
                    { new Guid("cbd4c843-2469-dce5-fdbe-25b964873743"), new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"), new Guid("654e3288-b95e-09af-39e7-ecd66cca54d2"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2391), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 487.67m, "https://loremflickr.com/640/480/computer/any?lock=485955173", true, new Guid("5e05baa4-6bf0-b16f-c68f-c40145fc25d1"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2396), "Intelligent Steel Table", 406.39m, "8781566193918", "Generic", 81.28m },
                    { new Guid("d6fd75d5-a9a9-cd98-fd91-ff152fde5535"), new Guid("3fad36d7-b10f-b541-05b3-adef06fe5c66"), new Guid("ba506447-82f3-8a13-3fc8-a656c62c09f0"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4921), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 5.78m, "https://loremflickr.com/640/480/computer/any?lock=382970135", true, new Guid("09000e0c-806b-30e1-510f-6e9dfb3ce474"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4926), "Unbranded Metal Cheese", 4.82m, "2360778135518", "Generic", 0.96m },
                    { new Guid("dc75941a-81bf-9e2b-280e-b94f4712882a"), new Guid("c1c28515-b9f4-4602-e42e-0c21a90061bf"), new Guid("431bb06d-4479-5477-9867-006bd5e9fce8"), new DateTime(2026, 2, 12, 2, 7, 24, 47, DateTimeKind.Local).AddTicks(4092), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 799.78m, "https://loremflickr.com/640/480/computer/any?lock=1950408735", true, new Guid("bda03848-bc61-c64d-ce42-a3772ccbb3a0"), new DateTime(2026, 2, 12, 2, 7, 24, 47, DateTimeKind.Local).AddTicks(7075), "Handcrafted Frozen Chicken", 666.48m, "2674098486848", "Gorgeous", 133.30m },
                    { new Guid("ea8479b7-2004-4e54-a636-8aea5fa27d5f"), new Guid("90a76fef-1a5c-2beb-d4a6-669a466a7406"), new Guid("4bbc38d0-cf21-a150-18eb-444cfc464b8d"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4502), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 8.09m, "https://loremflickr.com/640/480/computer/any?lock=1324516783", true, new Guid("32e154ef-3ec0-fa29-5cc7-6aab9591f93b"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4507), "Tasty Fresh Bike", 6.74m, "5989388987507", "Small", 1.35m },
                    { new Guid("eda33259-a81e-865d-97cd-7adb40d65303"), new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"), new Guid("b5105268-50fd-20fa-b8ea-f7586f425255"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(5172), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 9.50m, "https://loremflickr.com/640/480/computer/any?lock=1422449321", true, new Guid("5694f899-4c8f-73a6-8a13-9f9e285592ba"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(5177), "Awesome Metal Towels", 7.92m, "6892084740194", "Gorgeous", 1.58m },
                    { new Guid("f5b4bfd0-91ff-645b-007a-3603e916373f"), new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"), new Guid("2195251c-c64d-a8d2-5ec4-50d7767fe3ea"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1791), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 997.46m, "https://loremflickr.com/640/480/computer/any?lock=118393535", true, new Guid("3be9f04e-476e-595f-9911-6a2cf2de48e9"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1796), "Fantastic Plastic Table", 831.22m, "6597414527567", "Sleek", 166.24m },
                    { new Guid("ff2c0c8d-4067-b830-6f0a-03804e7c30f9"), new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"), new Guid("48ff6d2e-338e-d8ef-ae71-aba4df515b46"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1527), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 481.53m, "https://loremflickr.com/640/480/computer/any?lock=1482089870", true, new Guid("9a3dc99d-afca-ef5d-97db-2f7839eae121"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1532), "Incredible Wooden Computer", 401.28m, "1891475108792", "Handmade", 80.25m },
                    { new Guid("ff88a623-5aea-75ba-0289-f96e79484520"), new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"), new Guid("76c5c95a-5fe3-2b99-e9f7-55b76996c0bb"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3155), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 157.41m, "https://loremflickr.com/640/480/computer/any?lock=52501833", true, new Guid("5e6eaa5c-0012-b7b3-eb05-55668dc804d3"), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3160), "Tasty Soft Tuna", 131.18m, "8333123791411", "Unbranded", 26.23m }
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
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
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
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
