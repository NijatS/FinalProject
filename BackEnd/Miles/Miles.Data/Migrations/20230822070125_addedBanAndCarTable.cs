using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Miles.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedBanAndCarTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 988, DateTimeKind.Utc).AddTicks(7781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 654, DateTimeKind.Utc).AddTicks(9959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 989, DateTimeKind.Utc).AddTicks(5201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 655, DateTimeKind.Utc).AddTicks(7882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 988, DateTimeKind.Utc).AddTicks(3333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 654, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 990, DateTimeKind.Utc).AddTicks(1989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 656, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 989, DateTimeKind.Utc).AddTicks(6767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 655, DateTimeKind.Utc).AddTicks(9481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 989, DateTimeKind.Utc).AddTicks(8129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 656, DateTimeKind.Utc).AddTicks(927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 989, DateTimeKind.Utc).AddTicks(1899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 655, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 989, DateTimeKind.Utc).AddTicks(3638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 655, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 990, DateTimeKind.Utc).AddTicks(9630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 657, DateTimeKind.Utc).AddTicks(3903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 988, DateTimeKind.Utc).AddTicks(6423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 654, DateTimeKind.Utc).AddTicks(8517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fuels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 990, DateTimeKind.Utc).AddTicks(5793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 656, DateTimeKind.Utc).AddTicks(9774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 988, DateTimeKind.Utc).AddTicks(9388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 655, DateTimeKind.Utc).AddTicks(1846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 990, DateTimeKind.Utc).AddTicks(4705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 656, DateTimeKind.Utc).AddTicks(8506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 990, DateTimeKind.Utc).AddTicks(3361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 656, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 990, DateTimeKind.Utc).AddTicks(7006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 657, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 988, DateTimeKind.Utc).AddTicks(1846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 654, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 990, DateTimeKind.Utc).AddTicks(8217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 657, DateTimeKind.Utc).AddTicks(2403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 988, DateTimeKind.Utc).AddTicks(4859),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 654, DateTimeKind.Utc).AddTicks(6782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 989, DateTimeKind.Utc).AddTicks(603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 655, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 989, DateTimeKind.Utc).AddTicks(9469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 656, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 990, DateTimeKind.Utc).AddTicks(839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 656, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.CreateTable(
                name: "Bans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 991, DateTimeKind.Utc).AddTicks(827)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vin = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    FabricationYear = table.Column<int>(type: "int", nullable: false),
                    Odometer = table.Column<double>(type: "float", nullable: false),
                    FuelId = table.Column<int>(type: "int", nullable: false),
                    NoGears = table.Column<int>(type: "int", nullable: false),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuelCity = table.Column<int>(type: "int", nullable: false),
                    FuelWay = table.Column<int>(type: "int", nullable: false),
                    Motor = table.Column<double>(type: "float", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    BanId = table.Column<int>(type: "int", nullable: false),
                    AppUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 991, DateTimeKind.Utc).AddTicks(2986)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_AspNetUsers_AppUserId1",
                        column: x => x.AppUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cars_Bans_BanId",
                        column: x => x.BanId,
                        principalTable: "Bans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Fuels_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Fuels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarImage_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarImage_CarId",
                table: "CarImage",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_AppUserId1",
                table: "Cars",
                column: "AppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BanId",
                table: "Cars",
                column: "BanId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ColorId",
                table: "Cars",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CountryId",
                table: "Cars",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FuelId",
                table: "Cars",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ModelId",
                table: "Cars",
                column: "ModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarImage");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Bans");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 654, DateTimeKind.Utc).AddTicks(9959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 988, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 655, DateTimeKind.Utc).AddTicks(7882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 989, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 654, DateTimeKind.Utc).AddTicks(5392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 988, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 656, DateTimeKind.Utc).AddTicks(5026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 990, DateTimeKind.Utc).AddTicks(1989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 655, DateTimeKind.Utc).AddTicks(9481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 989, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 656, DateTimeKind.Utc).AddTicks(927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 989, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 655, DateTimeKind.Utc).AddTicks(4599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 989, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 655, DateTimeKind.Utc).AddTicks(6430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 989, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 657, DateTimeKind.Utc).AddTicks(3903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 990, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 654, DateTimeKind.Utc).AddTicks(8517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 988, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fuels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 656, DateTimeKind.Utc).AddTicks(9774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 990, DateTimeKind.Utc).AddTicks(5793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 655, DateTimeKind.Utc).AddTicks(1846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 988, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 656, DateTimeKind.Utc).AddTicks(8506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 990, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 656, DateTimeKind.Utc).AddTicks(6590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 990, DateTimeKind.Utc).AddTicks(3361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 657, DateTimeKind.Utc).AddTicks(1091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 990, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 654, DateTimeKind.Utc).AddTicks(3931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 988, DateTimeKind.Utc).AddTicks(1846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 657, DateTimeKind.Utc).AddTicks(2403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 990, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 654, DateTimeKind.Utc).AddTicks(6782),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 988, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 655, DateTimeKind.Utc).AddTicks(3239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 989, DateTimeKind.Utc).AddTicks(603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 656, DateTimeKind.Utc).AddTicks(2473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 989, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 19, 17, 45, 656, DateTimeKind.Utc).AddTicks(3828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 1, 24, 990, DateTimeKind.Utc).AddTicks(839));
        }
    }
}
