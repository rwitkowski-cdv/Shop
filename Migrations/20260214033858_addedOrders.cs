using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Migrations
{
    /// <inheritdoc />
    public partial class addedOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderHeaderId = table.Column<int>(type: "int", nullable: false),
                    OrderHeaderId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_OrderHeader_OrderHeaderId1",
                        column: x => x.OrderHeaderId1,
                        principalTable: "OrderHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Products_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(3344), new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 541, DateTimeKind.Local).AddTicks(7691), new DateTime(2026, 2, 14, 4, 38, 55, 548, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28fa7d43-a972-cc5e-da01-06bd633d5911"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(3468), new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3fad36d7-b10f-b541-05b3-adef06fe5c66"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(3287), new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(3379), new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(3409), new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90a76fef-1a5c-2beb-d4a6-669a466a7406"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(3226), new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("970a3739-d92a-3f5b-ba55-4488dea24542"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(3177), new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(3074), new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1c28515-b9f4-4602-e42e-0c21a90061bf"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(2636), new DateTime(2026, 2, 14, 4, 38, 55, 550, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ad86cd3-d8e7-8620-2d5b-bc6debdf71c1"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(980), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d15590e-dd8b-330a-9e20-f38173dcfd23"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1702), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f0f7f2f-b3b1-7704-9fc3-908ac001cfa1"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(60), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("101002b0-8e10-e63f-ecc5-8d5aba151a60"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 564, DateTimeKind.Local).AddTicks(9869), new DateTime(2026, 2, 14, 4, 38, 55, 564, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12b01ef6-8567-085b-f24b-b937a6b4dcc4"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3417), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d47f3a8-c3cf-1964-8038-421f6d6a8e98"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2964), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f82c6ca-e368-7613-8e03-e4318d4e5825"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3592), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3024c352-22b7-d635-f2f3-5261816bddc3"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2876), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3406be71-31ad-0dfc-67d0-071640804d1c"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1162), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("351e8e0b-cdd1-9453-805a-77f0a505bac0"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1973), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3cc5d5d1-3c87-a55b-b580-7c6640c9b664"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(343), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44989b56-8578-2206-ea4c-c0eb799f4f66"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3236), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("464ec528-4707-61e0-eafb-e98aceaa42f3"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(527), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4825dd1d-c379-4941-16b0-d7c46e34d3ff"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1250), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51d60f7e-0301-706c-2be5-64182a9f1be9"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2061), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5462b0c9-3674-00a1-28cd-b46047f66f8e"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 564, DateTimeKind.Local).AddTicks(8331), new DateTime(2026, 2, 14, 4, 38, 55, 564, DateTimeKind.Local).AddTicks(8407) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59d0cbaa-0630-9a0b-673c-d2ff1f639640"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(434), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c0fc61a-2c5c-cc5c-cdcc-3878e4bb1ac2"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2155), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("678e8b0c-38c1-8e31-1c6d-269d87b8783f"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 564, DateTimeKind.Local).AddTicks(9777), new DateTime(2026, 2, 14, 4, 38, 55, 564, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c397404-a345-8a74-2094-aa7fcdc61b3a"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(617), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73452c9c-78f0-f6f5-c02e-59ca7af9fd2f"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1790), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74540b9f-b460-2e28-b4a1-113d7afa8026"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1338), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("771cd60f-8921-dfda-4269-075a8912efdb"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2249), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7867a50f-28a0-2cda-18e5-8e8ea9e712b4"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1432), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8677d0ce-6049-6985-245c-4eca1c9aeb41"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 564, DateTimeKind.Local).AddTicks(9682), new DateTime(2026, 2, 14, 4, 38, 55, 564, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("893068d9-d15c-a851-bf32-0ef18f029c39"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2693), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ca83361-6bee-fbad-346b-3683cd25e632"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2780), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94655bcf-be19-2061-c0fd-455b42cb216b"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3323), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99282874-1f22-775f-02fd-b71dd36affcc"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1068), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9cac1b73-e92b-5bb1-f763-573c854cf16b"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3864), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9dc31d52-cf9f-adf5-c43d-c21a13be8db2"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(889), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fb22174-98a8-1427-4539-bc3bc0356bb4"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2423), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fe507a2-4ace-f610-d368-4ecd6a64ccdb"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1520), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a217f29a-3a34-ec64-3d60-6eac1603472b"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2604), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a421d182-8397-0347-5225-96a895e2bd38"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 564, DateTimeKind.Local).AddTicks(9544), new DateTime(2026, 2, 14, 4, 38, 55, 564, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a64ea75f-30b3-2ac8-57fa-83de752ceabf"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(705), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(711) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6cc7e6a-8f46-40e4-d2df-023ffc66ef78"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2336), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aad23ef7-d88c-d0c2-0150-3f29c4bb7a02"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(153), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac8a4ded-5ac0-379d-58af-f1a81e4f0d3e"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1879), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c10e919e-5aee-a465-0b87-f20872c8cfc9"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3149), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3cab5c5-bb6d-5514-025c-5c5026b2a0e1"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3689), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9745df3-4837-6095-5818-0ec786993db5"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2510), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbd4c843-2469-dce5-fdbe-25b964873743"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(794), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6fd75d5-a9a9-cd98-fd91-ff152fde5535"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3503), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc75941a-81bf-9e2b-280e-b94f4712882a"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 554, DateTimeKind.Local).AddTicks(9132), new DateTime(2026, 2, 14, 4, 38, 55, 555, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea8479b7-2004-4e54-a636-8aea5fa27d5f"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3051), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eda33259-a81e-865d-97cd-7adb40d65303"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3776), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5b4bfd0-91ff-645b-007a-3603e916373f"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(252), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff2c0c8d-4067-b830-6f0a-03804e7c30f9"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 564, DateTimeKind.Local).AddTicks(9967), new DateTime(2026, 2, 14, 4, 38, 55, 564, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff88a623-5aea-75ba-0289-f96e79484520"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1608), new DateTime(2026, 2, 14, 4, 38, 55, 565, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderHeaderId1",
                table: "OrderDetail",
                column: "OrderHeaderId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId1",
                table: "OrderDetail",
                column: "ProductId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "OrderHeader");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2564), new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 59, DateTimeKind.Local).AddTicks(1660), new DateTime(2026, 2, 14, 3, 49, 44, 64, DateTimeKind.Local).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28fa7d43-a972-cc5e-da01-06bd633d5911"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2645), new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3fad36d7-b10f-b541-05b3-adef06fe5c66"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2543), new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2603), new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2625), new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90a76fef-1a5c-2beb-d4a6-669a466a7406"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2521), new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("970a3739-d92a-3f5b-ba55-4488dea24542"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2500), new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2466), new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1c28515-b9f4-4602-e42e-0c21a90061bf"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2190), new DateTime(2026, 2, 14, 3, 49, 44, 66, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ad86cd3-d8e7-8620-2d5b-bc6debdf71c1"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3402), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d15590e-dd8b-330a-9e20-f38173dcfd23"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4061), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f0f7f2f-b3b1-7704-9fc3-908ac001cfa1"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2537), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("101002b0-8e10-e63f-ecc5-8d5aba151a60"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2368), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12b01ef6-8567-085b-f24b-b937a6b4dcc4"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5736), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d47f3a8-c3cf-1964-8038-421f6d6a8e98"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5328), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f82c6ca-e368-7613-8e03-e4318d4e5825"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5903), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3024c352-22b7-d635-f2f3-5261816bddc3"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5240), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3406be71-31ad-0dfc-67d0-071640804d1c"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3561), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("351e8e0b-cdd1-9453-805a-77f0a505bac0"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4311), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3cc5d5d1-3c87-a55b-b580-7c6640c9b664"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2803), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44989b56-8578-2206-ea4c-c0eb799f4f66"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5566), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("464ec528-4707-61e0-eafb-e98aceaa42f3"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2975), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4825dd1d-c379-4941-16b0-d7c46e34d3ff"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3648), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51d60f7e-0301-706c-2be5-64182a9f1be9"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4390), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5462b0c9-3674-00a1-28cd-b46047f66f8e"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(1188), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59d0cbaa-0630-9a0b-673c-d2ff1f639640"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2894), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c0fc61a-2c5c-cc5c-cdcc-3878e4bb1ac2"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4506), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("678e8b0c-38c1-8e31-1c6d-269d87b8783f"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2283), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c397404-a345-8a74-2094-aa7fcdc61b3a"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3062), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73452c9c-78f0-f6f5-c02e-59ca7af9fd2f"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4146), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74540b9f-b460-2e28-b4a1-113d7afa8026"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3728), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("771cd60f-8921-dfda-4269-075a8912efdb"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4586), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7867a50f-28a0-2cda-18e5-8e8ea9e712b4"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3808), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8677d0ce-6049-6985-245c-4eca1c9aeb41"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2177), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("893068d9-d15c-a851-bf32-0ef18f029c39"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5081), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ca83361-6bee-fbad-346b-3683cd25e632"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5161), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94655bcf-be19-2061-c0fd-455b42cb216b"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5654), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99282874-1f22-775f-02fd-b71dd36affcc"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3482), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9cac1b73-e92b-5bb1-f763-573c854cf16b"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(6148), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9dc31d52-cf9f-adf5-c43d-c21a13be8db2"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3317), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fb22174-98a8-1427-4539-bc3bc0356bb4"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4834), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fe507a2-4ace-f610-d368-4ecd6a64ccdb"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3892), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a217f29a-3a34-ec64-3d60-6eac1603472b"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4996), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a421d182-8397-0347-5225-96a895e2bd38"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2053), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a64ea75f-30b3-2ac8-57fa-83de752ceabf"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3156), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6cc7e6a-8f46-40e4-d2df-023ffc66ef78"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4664), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aad23ef7-d88c-d0c2-0150-3f29c4bb7a02"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2634), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac8a4ded-5ac0-379d-58af-f1a81e4f0d3e"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4232), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c10e919e-5aee-a465-0b87-f20872c8cfc9"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5487), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3cab5c5-bb6d-5514-025c-5c5026b2a0e1"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5982), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9745df3-4837-6095-5818-0ec786993db5"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4917), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbd4c843-2469-dce5-fdbe-25b964873743"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3237), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6fd75d5-a9a9-cd98-fd91-ff152fde5535"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5816), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc75941a-81bf-9e2b-280e-b94f4712882a"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 69, DateTimeKind.Local).AddTicks(9572), new DateTime(2026, 2, 14, 3, 49, 44, 70, DateTimeKind.Local).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea8479b7-2004-4e54-a636-8aea5fa27d5f"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5408), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eda33259-a81e-865d-97cd-7adb40d65303"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(6062), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5b4bfd0-91ff-645b-007a-3603e916373f"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2721), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff2c0c8d-4067-b830-6f0a-03804e7c30f9"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2453), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff88a623-5aea-75ba-0289-f96e79484520"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3982), new DateTime(2026, 2, 14, 3, 49, 44, 78, DateTimeKind.Local).AddTicks(3987) });
        }
    }
}
