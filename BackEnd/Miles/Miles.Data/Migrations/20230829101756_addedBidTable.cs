using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Miles.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedBidTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(2003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 526, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(8130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(3143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 944, DateTimeKind.Utc).AddTicks(8535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 526, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(3492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(8854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(9426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(5688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(6983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(1995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(9727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 528, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 526, DateTimeKind.Utc).AddTicks(5964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fuels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(6617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 528, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(3453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 526, DateTimeKind.Utc).AddTicks(8581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(5638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 528, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(4501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(7601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 528, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 944, DateTimeKind.Utc).AddTicks(7290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 526, DateTimeKind.Utc).AddTicks(2171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 947, DateTimeKind.Utc).AddTicks(2586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 528, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CarImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 947, DateTimeKind.Utc).AddTicks(4258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 528, DateTimeKind.Utc).AddTicks(9732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(8676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 528, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 944, DateTimeKind.Utc).AddTicks(9620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 526, DateTimeKind.Utc).AddTicks(4743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 947, DateTimeKind.Utc).AddTicks(715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 528, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(4643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 526, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(1424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(2554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(7877));

            migrationBuilder.CreateTable(
                name: "Bids",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<double>(type: "float", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 947, DateTimeKind.Utc).AddTicks(5251)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bids", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bids_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bids_AppUserId",
                table: "Bids",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bids");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 526, DateTimeKind.Utc).AddTicks(7150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(2003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(3143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 526, DateTimeKind.Utc).AddTicks(3608),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 944, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(8854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(3492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(4479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(9426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(5504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(1995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(6983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 528, DateTimeKind.Utc).AddTicks(5098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(9727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 526, DateTimeKind.Utc).AddTicks(5964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fuels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 528, DateTimeKind.Utc).AddTicks(2109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 526, DateTimeKind.Utc).AddTicks(8581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(3453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 528, DateTimeKind.Utc).AddTicks(1095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(9834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 528, DateTimeKind.Utc).AddTicks(3077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 526, DateTimeKind.Utc).AddTicks(2171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 944, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 528, DateTimeKind.Utc).AddTicks(8111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 947, DateTimeKind.Utc).AddTicks(2586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CarImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 528, DateTimeKind.Utc).AddTicks(9732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 947, DateTimeKind.Utc).AddTicks(4258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 528, DateTimeKind.Utc).AddTicks(4085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 526, DateTimeKind.Utc).AddTicks(4743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 944, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 528, DateTimeKind.Utc).AddTicks(6299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 947, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 526, DateTimeKind.Utc).AddTicks(9639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(6812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 15, 19, 527, DateTimeKind.Utc).AddTicks(7877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(2554));
        }
    }
}
