using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Miles.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedCarTablewithAuctionDatew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 575, DateTimeKind.Utc).AddTicks(1299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 968, DateTimeKind.Utc).AddTicks(5058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 576, DateTimeKind.Utc).AddTicks(1382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 969, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 574, DateTimeKind.Utc).AddTicks(4718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 968, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 577, DateTimeKind.Utc).AddTicks(7104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 988, DateTimeKind.Utc).AddTicks(2552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 576, DateTimeKind.Utc).AddTicks(4833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 969, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 576, DateTimeKind.Utc).AddTicks(7477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 969, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 575, DateTimeKind.Utc).AddTicks(6864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 969, DateTimeKind.Utc).AddTicks(655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 575, DateTimeKind.Utc).AddTicks(9492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 969, DateTimeKind.Utc).AddTicks(2625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 578, DateTimeKind.Utc).AddTicks(5086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 990, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 574, DateTimeKind.Utc).AddTicks(9721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 968, DateTimeKind.Utc).AddTicks(3475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fuels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 578, DateTimeKind.Utc).AddTicks(1191),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 989, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 575, DateTimeKind.Utc).AddTicks(3177),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 968, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 578, DateTimeKind.Utc).AddTicks(69),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 989, DateTimeKind.Utc).AddTicks(4954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 577, DateTimeKind.Utc).AddTicks(8852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 988, DateTimeKind.Utc).AddTicks(8107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 578, DateTimeKind.Utc).AddTicks(3056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 990, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 574, DateTimeKind.Utc).AddTicks(2559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 967, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 578, DateTimeKind.Utc).AddTicks(4072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 990, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 574, DateTimeKind.Utc).AddTicks(7338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 968, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 578, DateTimeKind.Utc).AddTicks(6083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 990, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 575, DateTimeKind.Utc).AddTicks(4598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 968, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 577, DateTimeKind.Utc).AddTicks(1014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 970, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 577, DateTimeKind.Utc).AddTicks(4552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 970, DateTimeKind.Utc).AddTicks(1985));

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
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BanId = table.Column<int>(type: "int", nullable: false),
                    ActionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 578, DateTimeKind.Utc).AddTicks(7774)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "CarImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    isMain = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 578, DateTimeKind.Utc).AddTicks(9315)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarImages_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarImages_CarId",
                table: "CarImages",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_AppUserId",
                table: "Cars",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BanId",
                table: "Cars",
                column: "BanId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ColorId",
                table: "Cars",
                column: "ColorId");

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
                name: "CarImages");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 968, DateTimeKind.Utc).AddTicks(5058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 575, DateTimeKind.Utc).AddTicks(1299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 969, DateTimeKind.Utc).AddTicks(4284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 576, DateTimeKind.Utc).AddTicks(1382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 968, DateTimeKind.Utc).AddTicks(580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 574, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 988, DateTimeKind.Utc).AddTicks(2552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 577, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 969, DateTimeKind.Utc).AddTicks(6212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 576, DateTimeKind.Utc).AddTicks(4833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 969, DateTimeKind.Utc).AddTicks(7853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 576, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 969, DateTimeKind.Utc).AddTicks(655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 575, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 969, DateTimeKind.Utc).AddTicks(2625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 575, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 990, DateTimeKind.Utc).AddTicks(6380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 578, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 968, DateTimeKind.Utc).AddTicks(3475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 574, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fuels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 989, DateTimeKind.Utc).AddTicks(8382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 578, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 968, DateTimeKind.Utc).AddTicks(7530),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 575, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 989, DateTimeKind.Utc).AddTicks(4954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 578, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 988, DateTimeKind.Utc).AddTicks(8107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 577, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 990, DateTimeKind.Utc).AddTicks(678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 578, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 967, DateTimeKind.Utc).AddTicks(9250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 574, DateTimeKind.Utc).AddTicks(2559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 990, DateTimeKind.Utc).AddTicks(3544),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 578, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 968, DateTimeKind.Utc).AddTicks(1905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 574, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 990, DateTimeKind.Utc).AddTicks(9689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 578, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 968, DateTimeKind.Utc).AddTicks(9160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 575, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 970, DateTimeKind.Utc).AddTicks(94),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 577, DateTimeKind.Utc).AddTicks(1014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 1, 1, 19, 970, DateTimeKind.Utc).AddTicks(1985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 1, 6, 43, 577, DateTimeKind.Utc).AddTicks(4552));
        }
    }
}
