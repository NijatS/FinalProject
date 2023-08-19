using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Miles.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedAboutTextTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(9814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 223, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(6569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 224, DateTimeKind.Utc).AddTicks(4882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(5677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 223, DateTimeKind.Utc).AddTicks(1284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(7960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 224, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(9117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 225, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(3726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 224, DateTimeKind.Utc).AddTicks(1281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(5293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 224, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(8455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 223, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(1421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 223, DateTimeKind.Utc).AddTicks(8254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(4477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 221, DateTimeKind.Utc).AddTicks(8440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(7089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 223, DateTimeKind.Utc).AddTicks(2717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(2600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 223, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "AboutTexts",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "SubTitle",
                table: "AboutTexts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 286, DateTimeKind.Utc).AddTicks(564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 225, DateTimeKind.Utc).AddTicks(2919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 286, DateTimeKind.Utc).AddTicks(1777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 225, DateTimeKind.Utc).AddTicks(4575));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 223, DateTimeKind.Utc).AddTicks(5313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 224, DateTimeKind.Utc).AddTicks(4882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 223, DateTimeKind.Utc).AddTicks(1284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 224, DateTimeKind.Utc).AddTicks(7974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(7960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 225, DateTimeKind.Utc).AddTicks(721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(9117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 224, DateTimeKind.Utc).AddTicks(1281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 224, DateTimeKind.Utc).AddTicks(3101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 223, DateTimeKind.Utc).AddTicks(4129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(8455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 223, DateTimeKind.Utc).AddTicks(8254),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 221, DateTimeKind.Utc).AddTicks(8440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(4477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 223, DateTimeKind.Utc).AddTicks(2717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 223, DateTimeKind.Utc).AddTicks(9928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "AboutTexts",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "SubTitle",
                table: "AboutTexts",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 225, DateTimeKind.Utc).AddTicks(2919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 286, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 10, 6, 42, 225, DateTimeKind.Utc).AddTicks(4575),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 286, DateTimeKind.Utc).AddTicks(1777));
        }
    }
}
