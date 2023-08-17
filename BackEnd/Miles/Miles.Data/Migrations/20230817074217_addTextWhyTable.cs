using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Miles.Data.Migrations
{
    /// <inheritdoc />
    public partial class addTextWhyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TextWhy_Settings_SettingId",
                table: "TextWhy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TextWhy",
                table: "TextWhy");

            migrationBuilder.RenameTable(
                name: "TextWhy",
                newName: "TextWhies");

            migrationBuilder.RenameIndex(
                name: "IX_TextWhy_SettingId",
                table: "TextWhies",
                newName: "IX_TextWhies_SettingId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 842, DateTimeKind.Utc).AddTicks(5164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 842, DateTimeKind.Utc).AddTicks(1742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 893, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 842, DateTimeKind.Utc).AddTicks(9691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 843, DateTimeKind.Utc).AddTicks(1294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 842, DateTimeKind.Utc).AddTicks(4082),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 893, DateTimeKind.Utc).AddTicks(9487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 842, DateTimeKind.Utc).AddTicks(6912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 842, DateTimeKind.Utc).AddTicks(493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 893, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 842, DateTimeKind.Utc).AddTicks(2809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 893, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 842, DateTimeKind.Utc).AddTicks(8296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(2572));

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "TextWhies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 843, DateTimeKind.Utc).AddTicks(2392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "TextWhies",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TextWhies",
                table: "TextWhies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TextWhies_Settings_SettingId",
                table: "TextWhies",
                column: "SettingId",
                principalTable: "Settings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TextWhies_Settings_SettingId",
                table: "TextWhies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TextWhies",
                table: "TextWhies");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "TextWhies");

            migrationBuilder.RenameTable(
                name: "TextWhies",
                newName: "TextWhy");

            migrationBuilder.RenameIndex(
                name: "IX_TextWhies_SettingId",
                table: "TextWhy",
                newName: "IX_TextWhy_SettingId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 842, DateTimeKind.Utc).AddTicks(5164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 893, DateTimeKind.Utc).AddTicks(7458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 842, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(3404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 842, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(4591),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 843, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 893, DateTimeKind.Utc).AddTicks(9487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 842, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(1632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 842, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 893, DateTimeKind.Utc).AddTicks(6359),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 842, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 893, DateTimeKind.Utc).AddTicks(8356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 842, DateTimeKind.Utc).AddTicks(2809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(2572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 842, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "TextWhy",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhy",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 11, 42, 17, 843, DateTimeKind.Utc).AddTicks(2392));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TextWhy",
                table: "TextWhy",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TextWhy_Settings_SettingId",
                table: "TextWhy",
                column: "SettingId",
                principalTable: "Settings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
