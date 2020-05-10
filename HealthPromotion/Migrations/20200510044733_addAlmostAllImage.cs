using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthPromotion.Migrations
{
    public partial class addAlmostAllImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 10, 7, 47, 32, 792, DateTimeKind.Local).AddTicks(7225), "/img/blog-post/dish.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 10, 7, 47, 32, 793, DateTimeKind.Local).AddTicks(8782), "/img/blog-post/virus.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 10, 7, 47, 32, 793, DateTimeKind.Local).AddTicks(8894), "/img/blog-post/self_development.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 47, 32, 793, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 47, 32, 793, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 47, 32, 793, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 47, 32, 793, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 47, 32, 793, DateTimeKind.Local).AddTicks(9017));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 10, 7, 34, 45, 33, DateTimeKind.Local).AddTicks(5591), "/img/dish.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6574), "/img/virus.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6685), "/img/self_development.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6853));
        }
    }
}
