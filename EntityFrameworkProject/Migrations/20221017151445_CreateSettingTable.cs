using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkProject.Migrations
{
    public partial class CreateSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 10, 17, 19, 14, 44, 605, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 10, 17, 19, 14, 44, 606, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 17, 19, 14, 44, 606, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "IsDeleted", "Key", "Value" },
                values: new object[,]
                {
                    { 1, false, "HeaderLogo", "logo.png" },
                    { 2, false, "Phone", "(055) 354-34-69" },
                    { 3, false, "ProductTake", "4" },
                    { 4, false, "Email", "p130@code.edu.az" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 10, 17, 17, 52, 48, 434, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 10, 17, 17, 52, 48, 435, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 17, 17, 52, 48, 435, DateTimeKind.Local).AddTicks(6823));
        }
    }
}
