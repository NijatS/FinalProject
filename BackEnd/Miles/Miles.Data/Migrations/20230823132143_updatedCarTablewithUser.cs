using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Miles.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedCarTablewithUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 727, DateTimeKind.Utc).AddTicks(3955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 668, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 729, DateTimeKind.Utc).AddTicks(1420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 669, DateTimeKind.Utc).AddTicks(2003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 726, DateTimeKind.Utc).AddTicks(5868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 667, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 730, DateTimeKind.Utc).AddTicks(5854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 669, DateTimeKind.Utc).AddTicks(9355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 729, DateTimeKind.Utc).AddTicks(5607),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 669, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 729, DateTimeKind.Utc).AddTicks(8074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 669, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 728, DateTimeKind.Utc).AddTicks(2263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 668, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 728, DateTimeKind.Utc).AddTicks(7154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 669, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 731, DateTimeKind.Utc).AddTicks(9054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 670, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 727, DateTimeKind.Utc).AddTicks(1168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 668, DateTimeKind.Utc).AddTicks(2763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fuels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 731, DateTimeKind.Utc).AddTicks(2596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 670, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 727, DateTimeKind.Utc).AddTicks(7342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 668, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 731, DateTimeKind.Utc).AddTicks(359),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 670, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 730, DateTimeKind.Utc).AddTicks(8046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 670, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 731, DateTimeKind.Utc).AddTicks(4558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 670, DateTimeKind.Utc).AddTicks(4902));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 726, DateTimeKind.Utc).AddTicks(3311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 667, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 732, DateTimeKind.Utc).AddTicks(5293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 671, DateTimeKind.Utc).AddTicks(1405));

            migrationBuilder.AddColumn<DateTime>(
                name: "ActionDate",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CarImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 732, DateTimeKind.Utc).AddTicks(8869),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 671, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 731, DateTimeKind.Utc).AddTicks(6715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 670, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 726, DateTimeKind.Utc).AddTicks(8304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 668, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 732, DateTimeKind.Utc).AddTicks(1139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 670, DateTimeKind.Utc).AddTicks(9022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 727, DateTimeKind.Utc).AddTicks(9801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 668, DateTimeKind.Utc).AddTicks(7498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 730, DateTimeKind.Utc).AddTicks(905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 669, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 730, DateTimeKind.Utc).AddTicks(3611),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 669, DateTimeKind.Utc).AddTicks(8160));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionDate",
                table: "Cars");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 668, DateTimeKind.Utc).AddTicks(4132),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 727, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 669, DateTimeKind.Utc).AddTicks(2003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 729, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 667, DateTimeKind.Utc).AddTicks(9508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 726, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 669, DateTimeKind.Utc).AddTicks(9355),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 730, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 669, DateTimeKind.Utc).AddTicks(3917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 729, DateTimeKind.Utc).AddTicks(5607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 669, DateTimeKind.Utc).AddTicks(5334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 729, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 668, DateTimeKind.Utc).AddTicks(8824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 728, DateTimeKind.Utc).AddTicks(2263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 669, DateTimeKind.Utc).AddTicks(531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 728, DateTimeKind.Utc).AddTicks(7154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 670, DateTimeKind.Utc).AddTicks(7714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 731, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 668, DateTimeKind.Utc).AddTicks(2763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 727, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fuels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 670, DateTimeKind.Utc).AddTicks(3586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 731, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 668, DateTimeKind.Utc).AddTicks(5913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 727, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 670, DateTimeKind.Utc).AddTicks(2350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 731, DateTimeKind.Utc).AddTicks(359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 670, DateTimeKind.Utc).AddTicks(861),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 730, DateTimeKind.Utc).AddTicks(8046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 670, DateTimeKind.Utc).AddTicks(4902),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 731, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 667, DateTimeKind.Utc).AddTicks(8091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 726, DateTimeKind.Utc).AddTicks(3311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 671, DateTimeKind.Utc).AddTicks(1405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 732, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CarImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 671, DateTimeKind.Utc).AddTicks(3767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 732, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 670, DateTimeKind.Utc).AddTicks(6406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 731, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 668, DateTimeKind.Utc).AddTicks(1140),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 726, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 670, DateTimeKind.Utc).AddTicks(9022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 732, DateTimeKind.Utc).AddTicks(1139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 668, DateTimeKind.Utc).AddTicks(7498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 727, DateTimeKind.Utc).AddTicks(9801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 669, DateTimeKind.Utc).AddTicks(6856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 730, DateTimeKind.Utc).AddTicks(905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 17, 18, 22, 669, DateTimeKind.Utc).AddTicks(8160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 17, 21, 42, 730, DateTimeKind.Utc).AddTicks(3611));
        }
    }
}
