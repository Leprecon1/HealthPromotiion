using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthPromotion.Migrations
{
    public partial class addAllImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 48, 41, 243, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 48, 41, 244, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 48, 41, 244, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 10, 7, 48, 41, 244, DateTimeKind.Local).AddTicks(8441), "/img/blog-post/Before_and_After.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 48, 41, 244, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 48, 41, 244, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 48, 41, 244, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 48, 41, 244, DateTimeKind.Local).AddTicks(8531));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 47, 32, 792, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 47, 32, 793, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 47, 32, 793, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2020, 5, 10, 7, 47, 32, 793, DateTimeKind.Local).AddTicks(8923), "/img/Before_and_After.jpg" });

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
    }
}
