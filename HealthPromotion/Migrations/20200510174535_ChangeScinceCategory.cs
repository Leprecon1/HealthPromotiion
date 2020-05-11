using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthPromotion.Migrations
{
    public partial class ChangeScinceCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CategoryName",
                value: "Science");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 20, 45, 34, 783, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 20, 45, 34, 784, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 20, 45, 34, 784, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 20, 45, 34, 784, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 20, 45, 34, 784, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 20, 45, 34, 784, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 20, 45, 34, 784, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 20, 45, 34, 784, DateTimeKind.Local).AddTicks(8662));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CategoryName",
                value: "Science and medicine");

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
                column: "DateTime",
                value: new DateTime(2020, 5, 10, 7, 48, 41, 244, DateTimeKind.Local).AddTicks(8441));

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
    }
}
