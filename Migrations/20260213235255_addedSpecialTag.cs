using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Migrations
{
    /// <inheritdoc />
    public partial class addedSpecialTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AddColumn<string>(
                name: "SpecialTag",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(2285), new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 368, DateTimeKind.Local).AddTicks(660), new DateTime(2026, 2, 14, 0, 52, 52, 373, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28fa7d43-a972-cc5e-da01-06bd633d5911"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(2388), new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3fad36d7-b10f-b541-05b3-adef06fe5c66"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(2267), new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(2303), new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(2322), new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90a76fef-1a5c-2beb-d4a6-669a466a7406"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(2249), new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("970a3739-d92a-3f5b-ba55-4488dea24542"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(2232), new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(2204), new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1c28515-b9f4-4602-e42e-0c21a90061bf"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(1960), new DateTime(2026, 2, 14, 0, 52, 52, 375, DateTimeKind.Local).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ad86cd3-d8e7-8620-2d5b-bc6debdf71c1"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1098), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1103), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d15590e-dd8b-330a-9e20-f38173dcfd23"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1762), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1767), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f0f7f2f-b3b1-7704-9fc3-908ac001cfa1"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(265), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(270), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("101002b0-8e10-e63f-ecc5-8d5aba151a60"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(91), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(95), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12b01ef6-8567-085b-f24b-b937a6b4dcc4"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3439), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3444), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d47f3a8-c3cf-1964-8038-421f6d6a8e98"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3036), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3041), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f82c6ca-e368-7613-8e03-e4318d4e5825"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3597), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3602), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3024c352-22b7-d635-f2f3-5261816bddc3"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2956), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2961), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3406be71-31ad-0dfc-67d0-071640804d1c"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1267), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1272), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("351e8e0b-cdd1-9453-805a-77f0a505bac0"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2007), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2012), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3cc5d5d1-3c87-a55b-b580-7c6640c9b664"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(517), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(522), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44989b56-8578-2206-ea4c-c0eb799f4f66"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3276), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3281), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("464ec528-4707-61e0-eafb-e98aceaa42f3"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(684), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(689), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4825dd1d-c379-4941-16b0-d7c46e34d3ff"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1348), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1353), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51d60f7e-0301-706c-2be5-64182a9f1be9"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2087), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2092), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5462b0c9-3674-00a1-28cd-b46047f66f8e"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 399, DateTimeKind.Local).AddTicks(9169), new DateTime(2026, 2, 14, 0, 52, 52, 399, DateTimeKind.Local).AddTicks(9206), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59d0cbaa-0630-9a0b-673c-d2ff1f639640"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(598), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(603), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c0fc61a-2c5c-cc5c-cdcc-3878e4bb1ac2"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2176), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2181), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("678e8b0c-38c1-8e31-1c6d-269d87b8783f"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(7), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(11), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c397404-a345-8a74-2094-aa7fcdc61b3a"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(767), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(772), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73452c9c-78f0-f6f5-c02e-59ca7af9fd2f"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1843), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1847), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74540b9f-b460-2e28-b4a1-113d7afa8026"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1427), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1432), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("771cd60f-8921-dfda-4269-075a8912efdb"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2256), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2261), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7867a50f-28a0-2cda-18e5-8e8ea9e712b4"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1515), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1520), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8677d0ce-6049-6985-245c-4eca1c9aeb41"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 399, DateTimeKind.Local).AddTicks(9920), new DateTime(2026, 2, 14, 0, 52, 52, 399, DateTimeKind.Local).AddTicks(9925), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("893068d9-d15c-a851-bf32-0ef18f029c39"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2792), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2797), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ca83361-6bee-fbad-346b-3683cd25e632"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2871), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2876), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94655bcf-be19-2061-c0fd-455b42cb216b"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3352), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3357), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99282874-1f22-775f-02fd-b71dd36affcc"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1179), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1184), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9cac1b73-e92b-5bb1-f763-573c854cf16b"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3837), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3842), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9dc31d52-cf9f-adf5-c43d-c21a13be8db2"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1019), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1024), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fb22174-98a8-1427-4539-bc3bc0356bb4"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2547), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2552), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fe507a2-4ace-f610-d368-4ecd6a64ccdb"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1597), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1602), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a217f29a-3a34-ec64-3d60-6eac1603472b"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2713), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2718), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a421d182-8397-0347-5225-96a895e2bd38"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 399, DateTimeKind.Local).AddTicks(9797), new DateTime(2026, 2, 14, 0, 52, 52, 399, DateTimeKind.Local).AddTicks(9804), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a64ea75f-30b3-2ac8-57fa-83de752ceabf"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(849), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(854), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6cc7e6a-8f46-40e4-d2df-023ffc66ef78"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2467), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2473), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aad23ef7-d88c-d0c2-0150-3f29c4bb7a02"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(347), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(352), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac8a4ded-5ac0-379d-58af-f1a81e4f0d3e"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1922), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1927), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c10e919e-5aee-a465-0b87-f20872c8cfc9"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3198), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3203), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3cab5c5-bb6d-5514-025c-5c5026b2a0e1"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3683), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3688), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9745df3-4837-6095-5818-0ec786993db5"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2626), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(2630), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbd4c843-2469-dce5-fdbe-25b964873743"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(931), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(936), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6fd75d5-a9a9-cd98-fd91-ff152fde5535"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3519), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3524), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc75941a-81bf-9e2b-280e-b94f4712882a"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 392, DateTimeKind.Local).AddTicks(657), new DateTime(2026, 2, 14, 0, 52, 52, 392, DateTimeKind.Local).AddTicks(3878), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea8479b7-2004-4e54-a636-8aea5fa27d5f"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3113), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3118), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eda33259-a81e-865d-97cd-7adb40d65303"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3760), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(3765), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5b4bfd0-91ff-645b-007a-3603e916373f"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(436), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(441), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff2c0c8d-4067-b830-6f0a-03804e7c30f9"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(180), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(185), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff88a623-5aea-75ba-0289-f96e79484520"),
                columns: new[] { "CreatedOn", "ModifiedOn", "SpecialTag" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1677), new DateTime(2026, 2, 14, 0, 52, 52, 400, DateTimeKind.Local).AddTicks(1682), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecialTag",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0731b960-5860-df79-d1ab-44d853c2abb3"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2940), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 37, DateTimeKind.Local).AddTicks(2613), new DateTime(2026, 2, 12, 2, 7, 24, 42, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28fa7d43-a972-cc5e-da01-06bd633d5911"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(3008), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3fad36d7-b10f-b541-05b3-adef06fe5c66"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2921), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("587c98c7-4979-c38b-65e2-7ddcbc026f3e"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2958), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2977), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90a76fef-1a5c-2beb-d4a6-669a466a7406"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2901), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("970a3739-d92a-3f5b-ba55-4488dea24542"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2881), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a964660-42e9-3da8-c9e1-2b28a65f0c73"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2843), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1c28515-b9f4-4602-e42e-0c21a90061bf"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2617), new DateTime(2026, 2, 12, 2, 7, 24, 44, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ad86cd3-d8e7-8620-2d5b-bc6debdf71c1"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2564), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d15590e-dd8b-330a-9e20-f38173dcfd23"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3237), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f0f7f2f-b3b1-7704-9fc3-908ac001cfa1"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1614), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("101002b0-8e10-e63f-ecc5-8d5aba151a60"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1441), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12b01ef6-8567-085b-f24b-b937a6b4dcc4"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4833), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d47f3a8-c3cf-1964-8038-421f6d6a8e98"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4423), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f82c6ca-e368-7613-8e03-e4318d4e5825"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(5003), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(5008) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3024c352-22b7-d635-f2f3-5261816bddc3"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4333), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3406be71-31ad-0dfc-67d0-071640804d1c"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2729), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("351e8e0b-cdd1-9453-805a-77f0a505bac0"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3492), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3cc5d5d1-3c87-a55b-b580-7c6640c9b664"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1872), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44989b56-8578-2206-ea4c-c0eb799f4f66"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4670), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("464ec528-4707-61e0-eafb-e98aceaa42f3"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2046), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4825dd1d-c379-4941-16b0-d7c46e34d3ff"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2817), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51d60f7e-0301-706c-2be5-64182a9f1be9"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3573), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5462b0c9-3674-00a1-28cd-b46047f66f8e"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(532), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59d0cbaa-0630-9a0b-673c-d2ff1f639640"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1965), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c0fc61a-2c5c-cc5c-cdcc-3878e4bb1ac2"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3670), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("678e8b0c-38c1-8e31-1c6d-269d87b8783f"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1343), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c397404-a345-8a74-2094-aa7fcdc61b3a"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2128), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73452c9c-78f0-f6f5-c02e-59ca7af9fd2f"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3319), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74540b9f-b460-2e28-b4a1-113d7afa8026"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2900), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("771cd60f-8921-dfda-4269-075a8912efdb"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3751), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7867a50f-28a0-2cda-18e5-8e8ea9e712b4"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2980), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8677d0ce-6049-6985-245c-4eca1c9aeb41"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1248), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("893068d9-d15c-a851-bf32-0ef18f029c39"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4169), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ca83361-6bee-fbad-346b-3683cd25e632"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4252), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94655bcf-be19-2061-c0fd-455b42cb216b"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4750), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99282874-1f22-775f-02fd-b71dd36affcc"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2648), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9cac1b73-e92b-5bb1-f763-573c854cf16b"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(5253), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9dc31d52-cf9f-adf5-c43d-c21a13be8db2"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2474), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fb22174-98a8-1427-4539-bc3bc0356bb4"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3918), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fe507a2-4ace-f610-d368-4ecd6a64ccdb"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3071), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a217f29a-3a34-ec64-3d60-6eac1603472b"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4080), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a421d182-8397-0347-5225-96a895e2bd38"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1120), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a64ea75f-30b3-2ac8-57fa-83de752ceabf"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2300), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6cc7e6a-8f46-40e4-d2df-023ffc66ef78"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3830), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aad23ef7-d88c-d0c2-0150-3f29c4bb7a02"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1706), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac8a4ded-5ac0-379d-58af-f1a81e4f0d3e"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3407), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c10e919e-5aee-a465-0b87-f20872c8cfc9"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4581), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3cab5c5-bb6d-5514-025c-5c5026b2a0e1"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(5085), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9745df3-4837-6095-5818-0ec786993db5"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3999), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbd4c843-2469-dce5-fdbe-25b964873743"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2391), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6fd75d5-a9a9-cd98-fd91-ff152fde5535"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4921), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc75941a-81bf-9e2b-280e-b94f4712882a"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 47, DateTimeKind.Local).AddTicks(4092), new DateTime(2026, 2, 12, 2, 7, 24, 47, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea8479b7-2004-4e54-a636-8aea5fa27d5f"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4502), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eda33259-a81e-865d-97cd-7adb40d65303"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(5172), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5b4bfd0-91ff-645b-007a-3603e916373f"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1791), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff2c0c8d-4067-b830-6f0a-03804e7c30f9"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1527), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff88a623-5aea-75ba-0289-f96e79484520"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3155), new DateTime(2026, 2, 12, 2, 7, 24, 55, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }
    }
}
