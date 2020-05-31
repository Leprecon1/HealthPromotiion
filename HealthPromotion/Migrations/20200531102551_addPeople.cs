using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthPromotion.Migrations
{
    public partial class addPeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Avatar = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 5, 31, 13, 25, 50, 664, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 5, 31, 13, 25, 50, 665, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 5, 31, 13, 25, 50, 665, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 5, 31, 13, 25, 50, 665, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 5, 31, 13, 25, 50, 665, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2020, 5, 31, 13, 25, 50, 665, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 5, 31, 13, 25, 50, 665, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2020, 5, 31, 13, 25, 50, 665, DateTimeKind.Local).AddTicks(8355));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 5, 15, 8, 18, 44, 371, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 5, 15, 8, 18, 44, 373, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 5, 15, 8, 18, 44, 373, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 5, 15, 8, 18, 44, 373, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 5, 15, 8, 18, 44, 373, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2020, 5, 15, 8, 18, 44, 373, DateTimeKind.Local).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 5, 15, 8, 18, 44, 373, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2020, 5, 15, 8, 18, 44, 373, DateTimeKind.Local).AddTicks(1900));
        }
    }
}
