using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Miles.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedAllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 237, DateTimeKind.Utc).AddTicks(8533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 933, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(5107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 933, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 237, DateTimeKind.Utc).AddTicks(4620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 932, DateTimeKind.Utc).AddTicks(4477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 239, DateTimeKind.Utc).AddTicks(727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 934, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Statuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 240, DateTimeKind.Utc).AddTicks(5054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 936, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(6444),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 933, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(7534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 934, DateTimeKind.Utc).AddTicks(457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(2352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 933, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(3852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 933, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 239, DateTimeKind.Utc).AddTicks(7428),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 935, DateTimeKind.Utc).AddTicks(2135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 237, DateTimeKind.Utc).AddTicks(7302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 932, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fuels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 239, DateTimeKind.Utc).AddTicks(3980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 934, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 933, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 239, DateTimeKind.Utc).AddTicks(2976),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 934, DateTimeKind.Utc).AddTicks(6416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 239, DateTimeKind.Utc).AddTicks(1756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 934, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 239, DateTimeKind.Utc).AddTicks(5162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 934, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 237, DateTimeKind.Utc).AddTicks(3584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 932, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 240, DateTimeKind.Utc).AddTicks(344),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 935, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CarImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 240, DateTimeKind.Utc).AddTicks(2054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 935, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 239, DateTimeKind.Utc).AddTicks(6206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 935, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 237, DateTimeKind.Utc).AddTicks(5957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 932, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bids",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 240, DateTimeKind.Utc).AddTicks(3150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 935, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 239, DateTimeKind.Utc).AddTicks(8541),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 935, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Auctions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 240, DateTimeKind.Utc).AddTicks(4017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 935, DateTimeKind.Utc).AddTicks(9565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(1332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 933, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(8610),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 934, DateTimeKind.Utc).AddTicks(1536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(9827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 934, DateTimeKind.Utc).AddTicks(2752));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 933, DateTimeKind.Utc).AddTicks(539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 237, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 933, DateTimeKind.Utc).AddTicks(8032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 932, DateTimeKind.Utc).AddTicks(4477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 237, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 934, DateTimeKind.Utc).AddTicks(3712),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 239, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Statuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 936, DateTimeKind.Utc).AddTicks(774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 240, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 933, DateTimeKind.Utc).AddTicks(9362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 934, DateTimeKind.Utc).AddTicks(457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 933, DateTimeKind.Utc).AddTicks(5101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(2352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 933, DateTimeKind.Utc).AddTicks(6370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 935, DateTimeKind.Utc).AddTicks(2135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 239, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 932, DateTimeKind.Utc).AddTicks(8416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 237, DateTimeKind.Utc).AddTicks(7302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fuels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 934, DateTimeKind.Utc).AddTicks(8162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 239, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 933, DateTimeKind.Utc).AddTicks(2386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 934, DateTimeKind.Utc).AddTicks(6416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 239, DateTimeKind.Utc).AddTicks(2976));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 934, DateTimeKind.Utc).AddTicks(4771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 239, DateTimeKind.Utc).AddTicks(1756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 934, DateTimeKind.Utc).AddTicks(9561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 239, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 932, DateTimeKind.Utc).AddTicks(2736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 237, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 935, DateTimeKind.Utc).AddTicks(5342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 240, DateTimeKind.Utc).AddTicks(344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CarImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 935, DateTimeKind.Utc).AddTicks(7388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 240, DateTimeKind.Utc).AddTicks(2054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 935, DateTimeKind.Utc).AddTicks(736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 239, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 932, DateTimeKind.Utc).AddTicks(5823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 237, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bids",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 935, DateTimeKind.Utc).AddTicks(8568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 240, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 935, DateTimeKind.Utc).AddTicks(3426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 239, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Auctions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 935, DateTimeKind.Utc).AddTicks(9565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 240, DateTimeKind.Utc).AddTicks(4017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 933, DateTimeKind.Utc).AddTicks(3899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(1332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 934, DateTimeKind.Utc).AddTicks(1536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 14, 42, 47, 934, DateTimeKind.Utc).AddTicks(2752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 8, 15, 27, 34, 238, DateTimeKind.Utc).AddTicks(9827));
        }
    }
}
