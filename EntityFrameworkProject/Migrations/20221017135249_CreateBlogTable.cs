using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkProject.Migrations
{
    public partial class CreateBlogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Date", "Description", "Image", "IsDeleted", "Title" },
                values: new object[] { 1, new DateTime(2022, 10, 17, 17, 52, 48, 434, DateTimeKind.Local).AddTicks(3268), "Description-1", "blog-feature-img-1.jpg", false, "Blog-1" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Date", "Description", "Image", "IsDeleted", "Title" },
                values: new object[] { 2, new DateTime(2022, 10, 17, 17, 52, 48, 435, DateTimeKind.Local).AddTicks(6768), "Description-2", "blog-feature-img-3.jpg", false, "Blog-2" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Date", "Description", "Image", "IsDeleted", "Title" },
                values: new object[] { 3, new DateTime(2022, 10, 17, 17, 52, 48, 435, DateTimeKind.Local).AddTicks(6823), "Description-3", "blog-feature-img-4.jpg", false, "Blog-3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
