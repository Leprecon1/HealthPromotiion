using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthPromotion.Migrations
{
    public partial class changeImageType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 31, 14, 19, 5, 864, DateTimeKind.Local).AddTicks(6288), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 31, 14, 19, 5, 865, DateTimeKind.Local).AddTicks(4741), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 31, 14, 19, 5, 865, DateTimeKind.Local).AddTicks(4818), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 31, 14, 19, 5, 865, DateTimeKind.Local).AddTicks(4836), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 31, 14, 19, 5, 865, DateTimeKind.Local).AddTicks(4850), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 31, 14, 19, 5, 865, DateTimeKind.Local).AddTicks(4867), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 31, 14, 19, 5, 865, DateTimeKind.Local).AddTicks(4881), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 31, 14, 19, 5, 865, DateTimeKind.Local).AddTicks(4894), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Avatar = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 31, 13, 25, 50, 664, DateTimeKind.Local).AddTicks(5196), "/img/blog-post/dish.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 31, 13, 25, 50, 665, DateTimeKind.Local).AddTicks(8092), "/img/blog-post/virus.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 31, 13, 25, 50, 665, DateTimeKind.Local).AddTicks(8219), "/img/blog-post/self_development.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 31, 13, 25, 50, 665, DateTimeKind.Local).AddTicks(8252), "/img/blog-post/Before_and_After.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 31, 13, 25, 50, 665, DateTimeKind.Local).AddTicks(8278), "/img/blog-post/blog-post1.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 31, 13, 25, 50, 665, DateTimeKind.Local).AddTicks(8307), "/img/blog-post/blog-post2.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 31, 13, 25, 50, 665, DateTimeKind.Local).AddTicks(8331), "/img/blog-post/blog-post3.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 31, 13, 25, 50, 665, DateTimeKind.Local).AddTicks(8355), "/img/blog-post/blog-post4.jpg" });
        }
    }
}
