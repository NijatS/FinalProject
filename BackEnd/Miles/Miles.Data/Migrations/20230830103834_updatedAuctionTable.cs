using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Miles.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedAuctionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 887, DateTimeKind.Utc).AddTicks(9932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 778, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 889, DateTimeKind.Utc).AddTicks(6646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 779, DateTimeKind.Utc).AddTicks(191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 887, DateTimeKind.Utc).AddTicks(2342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 777, DateTimeKind.Utc).AddTicks(9162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 891, DateTimeKind.Utc).AddTicks(1255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 779, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Statuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 895, DateTimeKind.Utc).AddTicks(4314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 781, DateTimeKind.Utc).AddTicks(6363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 890, DateTimeKind.Utc).AddTicks(490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 779, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 890, DateTimeKind.Utc).AddTicks(3133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 779, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 888, DateTimeKind.Utc).AddTicks(9956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 778, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 889, DateTimeKind.Utc).AddTicks(3501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 778, DateTimeKind.Utc).AddTicks(8897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 892, DateTimeKind.Utc).AddTicks(7322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 780, DateTimeKind.Utc).AddTicks(7704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 887, DateTimeKind.Utc).AddTicks(7188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 778, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fuels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 891, DateTimeKind.Utc).AddTicks(9235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 780, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 888, DateTimeKind.Utc).AddTicks(3716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 778, DateTimeKind.Utc).AddTicks(4615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 891, DateTimeKind.Utc).AddTicks(6836),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 780, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 891, DateTimeKind.Utc).AddTicks(4037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 780, DateTimeKind.Utc).AddTicks(1398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 892, DateTimeKind.Utc).AddTicks(1726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 780, DateTimeKind.Utc).AddTicks(5256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 886, DateTimeKind.Utc).AddTicks(9531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 777, DateTimeKind.Utc).AddTicks(7621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 893, DateTimeKind.Utc).AddTicks(8186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 781, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CarImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 894, DateTimeKind.Utc).AddTicks(3776),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 781, DateTimeKind.Utc).AddTicks(2425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 892, DateTimeKind.Utc).AddTicks(4518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 780, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 887, DateTimeKind.Utc).AddTicks(4539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 778, DateTimeKind.Utc).AddTicks(409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bids",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 894, DateTimeKind.Utc).AddTicks(7316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 781, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 893, DateTimeKind.Utc).AddTicks(365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 780, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Auctions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 895, DateTimeKind.Utc).AddTicks(1716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 781, DateTimeKind.Utc).AddTicks(5329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuctionStart",
                table: "Auctions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 894, DateTimeKind.Utc).AddTicks(9321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 781, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuctionEnd",
                table: "Auctions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 53, 895, DateTimeKind.Utc).AddTicks(496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 23, 781, DateTimeKind.Utc).AddTicks(4927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 888, DateTimeKind.Utc).AddTicks(6959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 778, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 890, DateTimeKind.Utc).AddTicks(6149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 779, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 890, DateTimeKind.Utc).AddTicks(8788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 779, DateTimeKind.Utc).AddTicks(8621));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 778, DateTimeKind.Utc).AddTicks(2955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 887, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 779, DateTimeKind.Utc).AddTicks(191),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 889, DateTimeKind.Utc).AddTicks(6646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 777, DateTimeKind.Utc).AddTicks(9162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 887, DateTimeKind.Utc).AddTicks(2342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 779, DateTimeKind.Utc).AddTicks(9981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 891, DateTimeKind.Utc).AddTicks(1255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Statuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 781, DateTimeKind.Utc).AddTicks(6363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 895, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 779, DateTimeKind.Utc).AddTicks(3071),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 890, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 779, DateTimeKind.Utc).AddTicks(5190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 890, DateTimeKind.Utc).AddTicks(3133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 778, DateTimeKind.Utc).AddTicks(7067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 888, DateTimeKind.Utc).AddTicks(9956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 778, DateTimeKind.Utc).AddTicks(8897),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 889, DateTimeKind.Utc).AddTicks(3501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 780, DateTimeKind.Utc).AddTicks(7704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 892, DateTimeKind.Utc).AddTicks(7322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 778, DateTimeKind.Utc).AddTicks(1751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 887, DateTimeKind.Utc).AddTicks(7188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fuels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 780, DateTimeKind.Utc).AddTicks(4092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 891, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 778, DateTimeKind.Utc).AddTicks(4615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 888, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 780, DateTimeKind.Utc).AddTicks(3043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 891, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 780, DateTimeKind.Utc).AddTicks(1398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 891, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 780, DateTimeKind.Utc).AddTicks(5256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 892, DateTimeKind.Utc).AddTicks(1726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 777, DateTimeKind.Utc).AddTicks(7621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 886, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 781, DateTimeKind.Utc).AddTicks(534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 893, DateTimeKind.Utc).AddTicks(8186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CarImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 781, DateTimeKind.Utc).AddTicks(2425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 894, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 780, DateTimeKind.Utc).AddTicks(6524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 892, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 778, DateTimeKind.Utc).AddTicks(409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 887, DateTimeKind.Utc).AddTicks(4539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bids",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 781, DateTimeKind.Utc).AddTicks(3593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 894, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 780, DateTimeKind.Utc).AddTicks(8743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 893, DateTimeKind.Utc).AddTicks(365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Auctions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 781, DateTimeKind.Utc).AddTicks(5329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 895, DateTimeKind.Utc).AddTicks(1716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuctionStart",
                table: "Auctions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 781, DateTimeKind.Utc).AddTicks(4498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 894, DateTimeKind.Utc).AddTicks(9321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuctionEnd",
                table: "Auctions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 23, 781, DateTimeKind.Utc).AddTicks(4927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 53, 895, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 778, DateTimeKind.Utc).AddTicks(5913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 888, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 779, DateTimeKind.Utc).AddTicks(6690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 890, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 12, 16, 3, 779, DateTimeKind.Utc).AddTicks(8621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 14, 38, 33, 890, DateTimeKind.Utc).AddTicks(8788));
        }
    }
}
