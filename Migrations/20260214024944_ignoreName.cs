using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Migrations
{
    /// <inheritdoc />
    public partial class ignoreName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ShoppingCart");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ShoppingCart",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6698), new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 137, DateTimeKind.Local).AddTicks(1257), new DateTime(2026, 2, 14, 2, 46, 36, 142, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28fa7d43-a972-cc5e-da01-06bd633d5911"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6756), new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3fad36d7-b10f-b541-05b3-adef06fe5c66"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6678), new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6716), new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6736), new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90a76fef-1a5c-2beb-d4a6-669a466a7406"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6660), new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("970a3739-d92a-3f5b-ba55-4488dea24542"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6642), new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6614), new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1c28515-b9f4-4602-e42e-0c21a90061bf"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6299), new DateTime(2026, 2, 14, 2, 46, 36, 144, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ad86cd3-d8e7-8620-2d5b-bc6debdf71c1"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6875), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d15590e-dd8b-330a-9e20-f38173dcfd23"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7549), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f0f7f2f-b3b1-7704-9fc3-908ac001cfa1"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6022), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("101002b0-8e10-e63f-ecc5-8d5aba151a60"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(5856), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12b01ef6-8567-085b-f24b-b937a6b4dcc4"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(9118), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d47f3a8-c3cf-1964-8038-421f6d6a8e98"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8712), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f82c6ca-e368-7613-8e03-e4318d4e5825"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(9281), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(9286) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3024c352-22b7-d635-f2f3-5261816bddc3"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8628), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3406be71-31ad-0dfc-67d0-071640804d1c"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7031), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("351e8e0b-cdd1-9453-805a-77f0a505bac0"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7794), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3cc5d5d1-3c87-a55b-b580-7c6640c9b664"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6280), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44989b56-8578-2206-ea4c-c0eb799f4f66"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8949), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("464ec528-4707-61e0-eafb-e98aceaa42f3"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6456), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4825dd1d-c379-4941-16b0-d7c46e34d3ff"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7117), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51d60f7e-0301-706c-2be5-64182a9f1be9"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7873), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5462b0c9-3674-00a1-28cd-b46047f66f8e"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(4648), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59d0cbaa-0630-9a0b-673c-d2ff1f639640"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6375), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c0fc61a-2c5c-cc5c-cdcc-3878e4bb1ac2"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7970), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("678e8b0c-38c1-8e31-1c6d-269d87b8783f"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(5770), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c397404-a345-8a74-2094-aa7fcdc61b3a"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6538), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73452c9c-78f0-f6f5-c02e-59ca7af9fd2f"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7629), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74540b9f-b460-2e28-b4a1-113d7afa8026"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7197), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("771cd60f-8921-dfda-4269-075a8912efdb"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8048), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7867a50f-28a0-2cda-18e5-8e8ea9e712b4"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7302), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8677d0ce-6049-6985-245c-4eca1c9aeb41"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(5663), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("893068d9-d15c-a851-bf32-0ef18f029c39"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8469), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ca83361-6bee-fbad-346b-3683cd25e632"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8549), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94655bcf-be19-2061-c0fd-455b42cb216b"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(9040), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99282874-1f22-775f-02fd-b71dd36affcc"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6952), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9cac1b73-e92b-5bb1-f763-573c854cf16b"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(9520), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9dc31d52-cf9f-adf5-c43d-c21a13be8db2"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6787), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fb22174-98a8-1427-4539-bc3bc0356bb4"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8227), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fe507a2-4ace-f610-d368-4ecd6a64ccdb"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7391), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a217f29a-3a34-ec64-3d60-6eac1603472b"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8384), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a421d182-8397-0347-5225-96a895e2bd38"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(5552), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a64ea75f-30b3-2ac8-57fa-83de752ceabf"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6626), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6cc7e6a-8f46-40e4-d2df-023ffc66ef78"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8127), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aad23ef7-d88c-d0c2-0150-3f29c4bb7a02"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6113), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac8a4ded-5ac0-379d-58af-f1a81e4f0d3e"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7715), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c10e919e-5aee-a465-0b87-f20872c8cfc9"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8869), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3cab5c5-bb6d-5514-025c-5c5026b2a0e1"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(9358), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9745df3-4837-6095-5818-0ec786993db5"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8306), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbd4c843-2469-dce5-fdbe-25b964873743"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6707), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6fd75d5-a9a9-cd98-fd91-ff152fde5535"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(9195), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc75941a-81bf-9e2b-280e-b94f4712882a"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 162, DateTimeKind.Local).AddTicks(7257), new DateTime(2026, 2, 14, 2, 46, 36, 163, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea8479b7-2004-4e54-a636-8aea5fa27d5f"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8790), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eda33259-a81e-865d-97cd-7adb40d65303"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(9436), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5b4bfd0-91ff-645b-007a-3603e916373f"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6199), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff2c0c8d-4067-b830-6f0a-03804e7c30f9"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(5940), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff88a623-5aea-75ba-0289-f96e79484520"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7470), new DateTime(2026, 2, 14, 2, 46, 36, 171, DateTimeKind.Local).AddTicks(7475) });
        }
    }
}
