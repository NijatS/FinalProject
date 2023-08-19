using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Miles.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedSubscribeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(3145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(8584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 880, DateTimeKind.Utc).AddTicks(9556),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(9803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(7960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 882, DateTimeKind.Utc).AddTicks(749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(9117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(6392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(7552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(2043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(8455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(4412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 880, DateTimeKind.Utc).AddTicks(8544),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(4477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(825),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(5497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 882, DateTimeKind.Utc).AddTicks(1799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 286, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 882, DateTimeKind.Utc).AddTicks(2695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 286, DateTimeKind.Utc).AddTicks(1777));

            migrationBuilder.CreateTable(
                name: "Subscribes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 882, DateTimeKind.Utc).AddTicks(3566)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscribes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(9814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(3145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(6569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(5677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 880, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(7960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(9803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(9117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 882, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(3726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(5293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(8455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(2043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(1421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(4477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 880, DateTimeKind.Utc).AddTicks(8544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 284, DateTimeKind.Utc).AddTicks(7089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 285, DateTimeKind.Utc).AddTicks(2600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 881, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 286, DateTimeKind.Utc).AddTicks(564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 882, DateTimeKind.Utc).AddTicks(1799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 18, 16, 31, 39, 286, DateTimeKind.Utc).AddTicks(1777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 17, 23, 8, 882, DateTimeKind.Utc).AddTicks(2695));
        }
    }
}
