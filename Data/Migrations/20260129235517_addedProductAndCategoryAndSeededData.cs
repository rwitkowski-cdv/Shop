using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Migrations
{
    /// <inheritdoc />
    public partial class addedProductAndCategoryAndSeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"), "Clothing" },
                    { new Guid("1ec213ba-958b-ada3-7541-c3b90b604696"), "Electronics" },
                    { new Guid("3da842e9-e1c9-282b-a65f-0c733e362c8e"), "Outdoors" },
                    { new Guid("45dc0705-b9a4-9ac9-839e-04d851859024"), "Tools" },
                    { new Guid("486d4f30-e0f9-91c8-5ce6-d7bbcdea7c72"), "Music" },
                    { new Guid("4b36427b-06c9-f038-cb04-0f87b57cd4b6"), "Music" },
                    { new Guid("55ba3f5b-8844-a2de-4542-264f55d97b4e"), "Health" },
                    { new Guid("b9f4c1c2-4602-2ee4-0c21-a90061bf1a9e"), "Health" },
                    { new Guid("db87dc8d-6282-b96d-6d20-6135fd199215"), "Grocery" },
                    { new Guid("f2ca3a01-32f0-f696-e535-9639370a972a"), "Electronics" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GrossAmount", "ImageUrl", "IsAvailable", "Name", "NetAmount", "SKU", "Tag", "TaxAmount" },
                values: new object[,]
                {
                    { new Guid("06f13db4-e20d-d175-4dc0-6102eb6ab8c3"), new Guid("55ba3f5b-8844-a2de-4542-264f55d97b4e"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 773.34m, "https://picsum.photos/640/480/?image=1047", false, "Sleek Fresh Tuna", 644.45m, "3713380303759", "Practical", 128.89m },
                    { new Guid("11ff64b9-fdf4-1396-0c8b-8e67c138318e"), new Guid("f2ca3a01-32f0-f696-e535-9639370a972a"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 631.78m, "https://picsum.photos/640/480/?image=863", true, "Generic Frozen Bacon", 526.48m, "9075701227705", "Unbranded", 105.30m },
                    { new Guid("1b01a032-bf97-0e38-b76a-e1f0ced07786"), new Guid("b9f4c1c2-4602-2ee4-0c21-a90061bf1a9e"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 569.30m, "https://picsum.photos/640/480/?image=398", true, "Generic Wooden Salad", 474.42m, "8499343245513", "Generic", 94.88m },
                    { new Guid("236fad4e-25a0-1871-720f-0f562caaa5ed"), new Guid("55ba3f5b-8844-a2de-4542-264f55d97b4e"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 817.24m, "https://picsum.photos/640/480/?image=959", true, "Ergonomic Granite Chips", 681.03m, "5317155095306", "Intelligent", 136.21m },
                    { new Guid("293f5001-bbc4-027a-3885-35f5e102c866"), new Guid("4b36427b-06c9-f038-cb04-0f87b57cd4b6"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 203.40m, "https://picsum.photos/640/480/?image=294", true, "Generic Steel Soap", 169.5m, "0648518648354", "Small", 33.90m },
                    { new Guid("2b094ff5-1088-24bb-0045-3a92ee845aa0"), new Guid("db87dc8d-6282-b96d-6d20-6135fd199215"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 934.18m, "https://picsum.photos/640/480/?image=433", true, "Small Granite Computer", 778.48m, "6834346173203", "Generic", 155.70m },
                    { new Guid("34dbed0b-384d-922b-af8f-2135437dfa28"), new Guid("f2ca3a01-32f0-f696-e535-9639370a972a"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 684.00m, "https://picsum.photos/640/480/?image=51", true, "Gorgeous Steel Sausages", 570.0m, "8231041512258", "Handcrafted", 114.00m },
                    { new Guid("3778422b-9360-8479-d534-91cb2da9cab7"), new Guid("4b36427b-06c9-f038-cb04-0f87b57cd4b6"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 583.92m, "https://picsum.photos/640/480/?image=1062", false, "Unbranded Wooden Ball", 486.6m, "8516700426429", "Sleek", 97.32m },
                    { new Guid("3e6f02bc-21e8-2fc8-0be6-1ec580cdb714"), new Guid("1ec213ba-958b-ada3-7541-c3b90b604696"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 849.72m, "https://picsum.photos/640/480/?image=146", true, "Ergonomic Fresh Soap", 708.1m, "8943450670954", "Handmade", 141.62m },
                    { new Guid("3f3716e9-251c-2195-4dc6-d2a85ec450d7"), new Guid("b9f4c1c2-4602-2ee4-0c21-a90061bf1a9e"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 233.35m, "https://picsum.photos/640/480/?image=579", true, "Licensed Frozen Pizza", 194.46m, "2651437507358", "Sleek", 38.89m },
                    { new Guid("3fc4f135-d414-4e46-be84-32614c946dad"), new Guid("3da842e9-e1c9-282b-a65f-0c733e362c8e"), "The Football Is Good For Training And Recreational Purposes", 75.37m, "https://picsum.photos/640/480/?image=1064", false, "Licensed Soft Salad", 62.81m, "0360669820501", "Rustic", 12.56m },
                    { new Guid("4c8b5c9d-dc71-da13-da94-9eede26702d9"), new Guid("f2ca3a01-32f0-f696-e535-9639370a972a"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 127.66m, "https://picsum.photos/640/480/?image=132", true, "Gorgeous Fresh Keyboard", 106.38m, "2782201720526", "Gorgeous", 21.28m },
                    { new Guid("53056b94-1dbf-b1fa-a5b7-8125ae06942c"), new Guid("db87dc8d-6282-b96d-6d20-6135fd199215"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 495.37m, "https://picsum.photos/640/480/?image=1031", true, "Unbranded Wooden Table", 412.81m, "9328865264278", "Licensed", 82.56m },
                    { new Guid("62afa0d8-69de-3b4f-d125-ec89ee717aaa"), new Guid("f2ca3a01-32f0-f696-e535-9639370a972a"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 721.85m, "https://picsum.photos/640/480/?image=169", false, "Intelligent Plastic Shirt", 601.54m, "2116260793298", "Small", 120.31m },
                    { new Guid("658db4a5-cb0a-4dd8-0d01-04245d18b820"), new Guid("45dc0705-b9a4-9ac9-839e-04d851859024"), "The Football Is Good For Training And Recreational Purposes", 818.25m, "https://picsum.photos/640/480/?image=400", true, "Incredible Concrete Pizza", 681.88m, "1159749098010", "Practical", 136.37m },
                    { new Guid("66014240-eac0-8ebc-e901-6a60dcec73fc"), new Guid("b9f4c1c2-4602-2ee4-0c21-a90061bf1a9e"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 883.88m, "https://picsum.photos/640/480/?image=188", true, "Licensed Frozen Computer", 736.57m, "5255768134114", "Gorgeous", 147.31m },
                    { new Guid("6c36892a-650e-3cbc-9acc-091032efe1a4"), new Guid("b9f4c1c2-4602-2ee4-0c21-a90061bf1a9e"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 57.80m, "https://picsum.photos/640/480/?image=187", true, "Gorgeous Rubber Bacon", 48.17m, "4676739810843", "Generic", 9.63m },
                    { new Guid("6d2a8812-1bb0-7943-4477-549867006bd5"), new Guid("55ba3f5b-8844-a2de-4542-264f55d97b4e"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 41.06m, "https://picsum.photos/640/480/?image=417", true, "Unbranded Rubber Gloves", 34.22m, "6621078653444", "Handcrafted", 6.84m },
                    { new Guid("71f3529f-82f6-6b2b-93ed-88f02a00cc6a"), new Guid("486d4f30-e0f9-91c8-5ce6-d7bbcdea7c72"), "The Football Is Good For Training And Recreational Purposes", 820.08m, "https://picsum.photos/640/480/?image=892", true, "Sleek Granite Car", 683.4m, "0286987635187", "Small", 136.68m },
                    { new Guid("746a469a-8506-ab04-41f9-aeb9a1ddaf2b"), new Guid("55ba3f5b-8844-a2de-4542-264f55d97b4e"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 959.93m, "https://picsum.photos/640/480/?image=511", true, "Refined Wooden Pizza", 799.94m, "5446087306966", "Rustic", 159.99m },
                    { new Guid("7704b3b1-c39f-8a90-c001-cfa1badf60e2"), new Guid("db87dc8d-6282-b96d-6d20-6135fd199215"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 344.09m, "https://picsum.photos/640/480/?image=1020", true, "Generic Granite Mouse", 286.74m, "4932095970097", "Handmade", 57.35m },
                    { new Guid("87beb2ae-eb2f-7ae1-b7d7-ab9177bb339d"), new Guid("db87dc8d-6282-b96d-6d20-6135fd199215"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 722.63m, "https://picsum.photos/640/480/?image=342", true, "Practical Rubber Bike", 602.19m, "4445048152865", "Awesome", 120.44m },
                    { new Guid("894b19d0-3c14-4737-c090-309e36088843"), new Guid("f2ca3a01-32f0-f696-e535-9639370a972a"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 956.80m, "https://picsum.photos/640/480/?image=389", true, "Fantastic Cotton Tuna", 797.33m, "2549571886494", "Fantastic", 159.47m },
                    { new Guid("8d5ab71c-034e-da9a-1086-01fde3f20e86"), new Guid("4b36427b-06c9-f038-cb04-0f87b57cd4b6"), "The Football Is Good For Training And Recreational Purposes", 504.63m, "https://picsum.photos/640/480/?image=603", false, "Ergonomic Plastic Computer", 420.52m, "3148886038346", "Awesome", 84.11m },
                    { new Guid("965447c4-df04-2eeb-9753-0eabaf176a5e"), new Guid("4b36427b-06c9-f038-cb04-0f87b57cd4b6"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 952.97m, "https://picsum.photos/640/480/?image=489", true, "Licensed Rubber Gloves", 794.14m, "0960171323134", "Small", 158.83m },
                    { new Guid("97ef5daf-2fdb-3978-eae1-21e4dd82ba8b"), new Guid("4b36427b-06c9-f038-cb04-0f87b57cd4b6"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 283.35m, "https://picsum.photos/640/480/?image=820", true, "Tasty Wooden Shirt", 236.12m, "7510879304466", "Licensed", 47.23m },
                    { new Guid("a0cbd37a-7940-45f5-0e79-64655bc4a32d"), new Guid("4b36427b-06c9-f038-cb04-0f87b57cd4b6"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 160.75m, "https://picsum.photos/640/480/?image=609", false, "Sleek Concrete Pants", 133.96m, "0016545660876", "Unbranded", 26.79m },
                    { new Guid("a8f32d88-faba-3c22-5eea-f5756ba728e1"), new Guid("b9f4c1c2-4602-2ee4-0c21-a90061bf1a9e"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 415.15m, "https://picsum.photos/640/480/?image=276", true, "Fantastic Wooden Car", 345.96m, "2105648250072", "Gorgeous", 69.19m },
                    { new Guid("ab80837d-b8ad-bda9-b804-74396c45a374"), new Guid("1ec213ba-958b-ada3-7541-c3b90b604696"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 417.72m, "https://picsum.photos/640/480/?image=124", true, "Sleek Soft Chair", 348.1m, "7961184618722", "Small", 69.62m },
                    { new Guid("ad36d7f5-0f3f-41b1-b505-b3adef06fe5c"), new Guid("55ba3f5b-8844-a2de-4542-264f55d97b4e"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 890.51m, "https://picsum.photos/640/480/?image=624", true, "Generic Wooden Cheese", 742.09m, "9936432295893", "Rustic", 148.42m },
                    { new Guid("ad7fc9ad-6982-ed0a-0c96-3a4183ed8096"), new Guid("db87dc8d-6282-b96d-6d20-6135fd199215"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 527.76m, "https://picsum.photos/640/480/?image=570", true, "Tasty Metal Towels", 439.8m, "5250898485808", "Sleek", 87.96m },
                    { new Guid("af5a9b26-5dc0-d53d-1e03-d7343b0cb15c"), new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 753.13m, "https://picsum.photos/640/480/?image=919", true, "Rustic Frozen Bacon", 627.61m, "9334829225223", "Handmade", 125.52m },
                    { new Guid("b16f6bf0-8fc6-01c4-45fc-25d1c2ae3ca1"), new Guid("db87dc8d-6282-b96d-6d20-6135fd199215"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 606.42m, "https://picsum.photos/640/480/?image=649", false, "Handmade Fresh Keyboard", 505.35m, "5661939151482", "Small", 101.07m },
                    { new Guid("b2f10e5e-5f40-4ea7-a6b3-30c82a57fa83"), new Guid("1ec213ba-958b-ada3-7541-c3b90b604696"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 609.57m, "https://picsum.photos/640/480/?image=219", false, "Licensed Soft Soap", 507.98m, "2841324405793", "Intelligent", 101.59m },
                    { new Guid("b8df9891-21a3-7aa1-7b27-6f226360b931"), new Guid("45dc0705-b9a4-9ac9-839e-04d851859024"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 241.33m, "https://picsum.photos/640/480/?image=241", false, "Intelligent Steel Table", 201.11m, "3334132477179", "Fantastic", 40.22m },
                    { new Guid("ba1759b9-d651-0c99-48fa-e0cc85e51afa"), new Guid("3da842e9-e1c9-282b-a65f-0c733e362c8e"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 743.84m, "https://picsum.photos/640/480/?image=68", true, "Licensed Frozen Fish", 619.87m, "7388607631654", "Generic", 123.97m },
                    { new Guid("bbcec637-02b0-1010-108e-3fe6ecc58d5a"), new Guid("3da842e9-e1c9-282b-a65f-0c733e362c8e"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 3.89m, "https://picsum.photos/640/480/?image=912", true, "Practical Metal Bacon", 3.24m, "1603134376585", "Ergonomic", 0.65m },
                    { new Guid("bc5b2d86-eb6d-71df-c1cc-47542edc083f"), new Guid("45dc0705-b9a4-9ac9-839e-04d851859024"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 532.43m, "https://picsum.photos/640/480/?image=308", true, "Sleek Wooden Car", 443.69m, "8103121513359", "Unbranded", 88.74m },
                    { new Guid("bc7be224-61dc-5b6c-b68b-92a0cdc3e596"), new Guid("1ec213ba-958b-ada3-7541-c3b90b604696"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 822.37m, "https://picsum.photos/640/480/?image=567", true, "Licensed Rubber Hat", 685.31m, "3899911894030", "Gorgeous", 137.06m },
                    { new Guid("bd379db1-419f-db03-1ee8-401393769f0b"), new Guid("b9f4c1c2-4602-2ee4-0c21-a90061bf1a9e"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 163.51m, "https://picsum.photos/640/480/?image=1028", true, "Incredible Soft Pants", 136.26m, "7640711982658", "Practical", 27.25m },
                    { new Guid("cb11250a-6e7c-f074-7045-cf5e8e2823c0"), new Guid("1ec213ba-958b-ada3-7541-c3b90b604696"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 718.84m, "https://picsum.photos/640/480/?image=237", true, "Ergonomic Frozen Salad", 599.03m, "4231303663739", "Handcrafted", 119.81m },
                    { new Guid("cdb56e7a-d565-201c-4357-80bfc83e11d0"), new Guid("3da842e9-e1c9-282b-a65f-0c733e362c8e"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 999.38m, "https://picsum.photos/640/480/?image=728", true, "Unbranded Steel Ball", 832.82m, "1732558543829", "Gorgeous", 166.56m },
                    { new Guid("cff34447-dac4-0bd6-34c9-17da5328c54e"), new Guid("55ba3f5b-8844-a2de-4542-264f55d97b4e"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 728.95m, "https://picsum.photos/640/480/?image=702", true, "Small Cotton Car", 607.46m, "1575584903133", "Handmade", 121.49m },
                    { new Guid("d2220f2f-1472-a119-4ab9-b50283d1a3c1"), new Guid("f2ca3a01-32f0-f696-e535-9639370a972a"), "The Football Is Good For Training And Recreational Purposes", 598.82m, "https://picsum.photos/640/480/?image=356", false, "Ergonomic Metal Ball", 499.02m, "5252267198791", "Intelligent", 99.80m },
                    { new Guid("d4c8431f-69cb-e524-dcfd-be25b9648737"), new Guid("4b36427b-06c9-f038-cb04-0f87b57cd4b6"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 870.70m, "https://picsum.photos/640/480/?image=220", false, "Handmade Concrete Ball", 725.58m, "9699099231610", "Fantastic", 145.12m },
                    { new Guid("d6aafc42-f6e3-acae-3318-1b594abf423a"), new Guid("3da842e9-e1c9-282b-a65f-0c733e362c8e"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 841.31m, "https://picsum.photos/640/480/?image=339", true, "Ergonomic Soft Bike", 701.09m, "5677535055604", "Tasty", 140.22m },
                    { new Guid("de86cb3c-614e-25b1-1716-23e995a6294f"), new Guid("f2ca3a01-32f0-f696-e535-9639370a972a"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 401.13m, "https://picsum.photos/640/480/?image=110", true, "Tasty Wooden Chicken", 334.28m, "3761355657222", "Tasty", 66.85m },
                    { new Guid("f5cf9f9d-c4ad-c23d-1a13-be8db2d1effa"), new Guid("1ec213ba-958b-ada3-7541-c3b90b604696"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 441.21m, "https://picsum.photos/640/480/?image=215", true, "Licensed Granite Bike", 367.68m, "1003210765737", "Sleek", 73.53m },
                    { new Guid("ff2c0c8d-4067-b830-6f0a-03804e7c30f9"), new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 135.18m, "https://picsum.photos/640/480/?image=693", true, "Sleek Plastic Chair", 112.65m, "2656616840851", "Incredible", 22.53m },
                    { new Guid("ff6ad31d-facc-a519-18e7-a3da67372034"), new Guid("1e1d4dcb-25d7-88b8-173b-ef553bbe2bf4"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 623.85m, "https://picsum.photos/640/480/?image=49", true, "Ergonomic Wooden Shoes", 519.88m, "0263455247615", "Practical", 103.97m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
