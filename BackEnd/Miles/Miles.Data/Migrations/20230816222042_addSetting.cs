using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Miles.Data.Migrations
{
    /// <inheritdoc />
    public partial class addSetting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 1, 34, 18, 492, DateTimeKind.Utc).AddTicks(2209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 893, DateTimeKind.Utc).AddTicks(7458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 1, 34, 18, 491, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(3404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 1, 34, 18, 492, DateTimeKind.Utc).AddTicks(8121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 893, DateTimeKind.Utc).AddTicks(9487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 1, 34, 18, 492, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(1632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 1, 34, 18, 492, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 893, DateTimeKind.Utc).AddTicks(6359),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 1, 34, 18, 491, DateTimeKind.Utc).AddTicks(4825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 893, DateTimeKind.Utc).AddTicks(8356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 1, 34, 18, 491, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(2572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 1, 34, 18, 492, DateTimeKind.Utc).AddTicks(6496));

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoWhy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoWhyUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(4591)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Social",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SettingId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Social", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Social_Settings_SettingId",
                        column: x => x.SettingId,
                        principalTable: "Settings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TextWhy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SettingId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextWhy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TextWhy_Settings_SettingId",
                        column: x => x.SettingId,
                        principalTable: "Settings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Social_SettingId",
                table: "Social",
                column: "SettingId");

            migrationBuilder.CreateIndex(
                name: "IX_TextWhy_SettingId",
                table: "TextWhy",
                column: "SettingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Social");

            migrationBuilder.DropTable(
                name: "TextWhy");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserPricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 1, 34, 18, 492, DateTimeKind.Utc).AddTicks(2209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 1, 34, 18, 491, DateTimeKind.Utc).AddTicks(6671),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 893, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 1, 34, 18, 492, DateTimeKind.Utc).AddTicks(8121),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 1, 34, 18, 492, DateTimeKind.Utc).AddTicks(361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 893, DateTimeKind.Utc).AddTicks(9487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 1, 34, 18, 492, DateTimeKind.Utc).AddTicks(4725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 1, 34, 18, 491, DateTimeKind.Utc).AddTicks(4825),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 893, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 1, 34, 18, 491, DateTimeKind.Utc).AddTicks(8414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 893, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Associates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 1, 34, 18, 492, DateTimeKind.Utc).AddTicks(6496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 2, 20, 41, 894, DateTimeKind.Utc).AddTicks(2572));
        }
    }
}
