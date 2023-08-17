using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Miles.Data.Migrations
{
    /// <inheritdoc />
    public partial class addSocialTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Social_Settings_SettingId",
                table: "Social");

            migrationBuilder.DropForeignKey(
                name: "FK_Social_Staffs_StaffId",
                table: "Social");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Social",
                table: "Social");

            migrationBuilder.RenameTable(
                name: "Social",
                newName: "Socials");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Socials",
                newName: "Icon");

            migrationBuilder.RenameIndex(
                name: "IX_Social_StaffId",
                table: "Socials",
                newName: "IX_Socials_StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_Social_SettingId",
                table: "Socials",
                newName: "IX_Socials_SettingId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 731, DateTimeKind.Utc).AddTicks(5632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 849, DateTimeKind.Utc).AddTicks(2565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 732, DateTimeKind.Utc).AddTicks(1750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 849, DateTimeKind.Utc).AddTicks(9868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 731, DateTimeKind.Utc).AddTicks(2110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 848, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 732, DateTimeKind.Utc).AddTicks(3170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 850, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 731, DateTimeKind.Utc).AddTicks(9323),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 849, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 732, DateTimeKind.Utc).AddTicks(589),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 849, DateTimeKind.Utc).AddTicks(7993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 731, DateTimeKind.Utc).AddTicks(4637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 849, DateTimeKind.Utc).AddTicks(1456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 731, DateTimeKind.Utc).AddTicks(7039),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 849, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 731, DateTimeKind.Utc).AddTicks(1003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 848, DateTimeKind.Utc).AddTicks(7593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 731, DateTimeKind.Utc).AddTicks(3311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 849, DateTimeKind.Utc).AddTicks(111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 731, DateTimeKind.Utc).AddTicks(8275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 849, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.AlterColumn<int>(
                name: "SettingId",
                table: "Socials",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Socials",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 732, DateTimeKind.Utc).AddTicks(4239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Socials",
                table: "Socials",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Socials_Settings_SettingId",
                table: "Socials",
                column: "SettingId",
                principalTable: "Settings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Socials_Staffs_StaffId",
                table: "Socials",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socials_Settings_SettingId",
                table: "Socials");

            migrationBuilder.DropForeignKey(
                name: "FK_Socials_Staffs_StaffId",
                table: "Socials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Socials",
                table: "Socials");

            migrationBuilder.RenameTable(
                name: "Socials",
                newName: "Social");

            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "Social",
                newName: "Logo");

            migrationBuilder.RenameIndex(
                name: "IX_Socials_StaffId",
                table: "Social",
                newName: "IX_Social_StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_Socials_SettingId",
                table: "Social",
                newName: "IX_Social_SettingId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 849, DateTimeKind.Utc).AddTicks(2565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 731, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TextWhies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 849, DateTimeKind.Utc).AddTicks(9868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 732, DateTimeKind.Utc).AddTicks(1750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 848, DateTimeKind.Utc).AddTicks(9004),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 731, DateTimeKind.Utc).AddTicks(2110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 850, DateTimeKind.Utc).AddTicks(1929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 732, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 849, DateTimeKind.Utc).AddTicks(6589),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 731, DateTimeKind.Utc).AddTicks(9323));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 849, DateTimeKind.Utc).AddTicks(7993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 732, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 849, DateTimeKind.Utc).AddTicks(1456),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 731, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 849, DateTimeKind.Utc).AddTicks(4211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 731, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 848, DateTimeKind.Utc).AddTicks(7593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 731, DateTimeKind.Utc).AddTicks(1003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 849, DateTimeKind.Utc).AddTicks(111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 731, DateTimeKind.Utc).AddTicks(3311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 13, 15, 27, 849, DateTimeKind.Utc).AddTicks(5564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 731, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.AlterColumn<int>(
                name: "SettingId",
                table: "Social",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Social",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 14, 12, 2, 732, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Social",
                table: "Social",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Social_Settings_SettingId",
                table: "Social",
                column: "SettingId",
                principalTable: "Settings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Social_Staffs_StaffId",
                table: "Social",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id");
        }
    }
}
