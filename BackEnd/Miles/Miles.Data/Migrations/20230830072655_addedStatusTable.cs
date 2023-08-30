using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Miles.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedStatusTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 470, DateTimeKind.Utc).AddTicks(9731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(2003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 471, DateTimeKind.Utc).AddTicks(6145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 470, DateTimeKind.Utc).AddTicks(5856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 944, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(1899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(3492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 471, DateTimeKind.Utc).AddTicks(7492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(9426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 471, DateTimeKind.Utc).AddTicks(8563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 471, DateTimeKind.Utc).AddTicks(3500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 471, DateTimeKind.Utc).AddTicks(4839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(6983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(8459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(9727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 470, DateTimeKind.Utc).AddTicks(8547),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fuels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(5248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 471, DateTimeKind.Utc).AddTicks(1332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(3453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(4161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(2946),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(6272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 470, DateTimeKind.Utc).AddTicks(4087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 944, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 473, DateTimeKind.Utc).AddTicks(1571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 947, DateTimeKind.Utc).AddTicks(2586));

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "WinDate",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "WinnerId",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CarImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 473, DateTimeKind.Utc).AddTicks(3291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 947, DateTimeKind.Utc).AddTicks(4258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(7379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 470, DateTimeKind.Utc).AddTicks(7119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 944, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bids",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 473, DateTimeKind.Utc).AddTicks(4515),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 947, DateTimeKind.Utc).AddTicks(5251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(9495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 947, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 471, DateTimeKind.Utc).AddTicks(2437),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 471, DateTimeKind.Utc).AddTicks(9767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(2554));

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 473, DateTimeKind.Utc).AddTicks(5562)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_StatusId",
                table: "Cars",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Statuses_StatusId",
                table: "Cars",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Statuses_StatusId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Cars_StatusId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "WinDate",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "WinnerId",
                table: "Cars");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(2003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 470, DateTimeKind.Utc).AddTicks(9731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(8130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 471, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 944, DateTimeKind.Utc).AddTicks(8535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 470, DateTimeKind.Utc).AddTicks(5856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(3492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(9426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 471, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 471, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(5688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 471, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(6983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 471, DateTimeKind.Utc).AddTicks(4839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(9727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 470, DateTimeKind.Utc).AddTicks(8547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fuels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(6617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(5248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(3453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 471, DateTimeKind.Utc).AddTicks(1332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(5638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(4501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(2946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(7601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 944, DateTimeKind.Utc).AddTicks(7290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 470, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 947, DateTimeKind.Utc).AddTicks(2586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 473, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CarImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 947, DateTimeKind.Utc).AddTicks(4258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 473, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(8676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(7379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 944, DateTimeKind.Utc).AddTicks(9620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 470, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bids",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 947, DateTimeKind.Utc).AddTicks(5251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 473, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 947, DateTimeKind.Utc).AddTicks(715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(9495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 945, DateTimeKind.Utc).AddTicks(4643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 471, DateTimeKind.Utc).AddTicks(2437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(1424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 471, DateTimeKind.Utc).AddTicks(9767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 17, 55, 946, DateTimeKind.Utc).AddTicks(2554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 26, 55, 472, DateTimeKind.Utc).AddTicks(984));
        }
    }
}
