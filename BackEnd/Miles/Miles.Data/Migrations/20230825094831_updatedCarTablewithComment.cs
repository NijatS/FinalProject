using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Miles.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedCarTablewithComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 891, DateTimeKind.Utc).AddTicks(9434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 846, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(4503),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 891, DateTimeKind.Utc).AddTicks(6536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 846, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(9220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(77));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(5599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(6459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(2329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(2986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(3534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(4450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 891, DateTimeKind.Utc).AddTicks(8538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 846, DateTimeKind.Utc).AddTicks(8983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fuels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(1939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(1123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(64),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(1076));

            migrationBuilder.AlterColumn<int>(
                name: "BlogId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CarID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(2737),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(4755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 891, DateTimeKind.Utc).AddTicks(5596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 846, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(6947),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CarImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(8385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 849, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(3613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 891, DateTimeKind.Utc).AddTicks(7403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 846, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(5400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(1520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(2052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(7593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(8489),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CarID",
                table: "Comments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 846, DateTimeKind.Utc).AddTicks(9913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 891, DateTimeKind.Utc).AddTicks(9434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(5125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 846, DateTimeKind.Utc).AddTicks(6861),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 891, DateTimeKind.Utc).AddTicks(6536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(77),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(6266),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(7311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(2986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(2329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(4142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(6860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 846, DateTimeKind.Utc).AddTicks(8983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 891, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fuels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(3941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(1117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(3081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(1076),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(64));

            migrationBuilder.AlterColumn<int>(
                name: "BlogId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(4755),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(2737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 846, DateTimeKind.Utc).AddTicks(5883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 891, DateTimeKind.Utc).AddTicks(5596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(9573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(6947));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CarImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 849, DateTimeKind.Utc).AddTicks(1006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(8385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(5786),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 846, DateTimeKind.Utc).AddTicks(7810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 891, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 848, DateTimeKind.Utc).AddTicks(7747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 893, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(2052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutTexts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(8355),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(7593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutSkills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 11, 59, 847, DateTimeKind.Utc).AddTicks(9304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 48, 30, 892, DateTimeKind.Utc).AddTicks(8489));

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
