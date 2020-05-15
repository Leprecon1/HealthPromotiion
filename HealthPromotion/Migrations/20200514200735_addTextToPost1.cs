using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthPromotion.Migrations
{
    public partial class addTextToPost1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "DateTime", "Text" },
                values: new object[] { new DateTime(2020, 5, 14, 23, 7, 34, 707, DateTimeKind.Local).AddTicks(1423), "Так выглядит современная тарелка здорового питания. Мы в проекте пошли еще дальше – взяли за основу пропорции Гарвардской тарелки, добавили современные рекомендации ВОЗ, и составили перечень рекомендуемых продуктов и их соотношения на одном рисунке тарелки. Например, мы добавили в здоровый “белок” яйца – по современным научным рекомендациям можно не бояться добавлять их в рацион. Кроме того, мы расширили перечень овощей и примеры цельнозерновых и в целом показали, с помощью каких продуктов можно составить себе здоровый рацион именно в России. Мы также добавили в тарелку небольшой сектор со сладостями, во-первых, можно по ВОЗ – до 5-10% от общей калорийности, во-вторых, некоторые уважаемые нами эксперты, например, Алан Арагон наоборот – рекомендует добавлять «вредные» сладости (или немного фастфуда) до 10% от рациона. Для психологической разгрузки наличие легких послаблений позволяет эффективнее придерживаться здорового питания (смотрите также обзор 5 исследований: чем жестче диета, тем меньше шансов на похудение)." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 5, 14, 23, 7, 34, 708, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 5, 14, 23, 7, 34, 708, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 5, 14, 23, 7, 34, 708, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 5, 14, 23, 7, 34, 708, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2020, 5, 14, 23, 7, 34, 708, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 5, 14, 23, 7, 34, 708, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2020, 5, 14, 23, 7, 34, 708, DateTimeKind.Local).AddTicks(2850));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "DateTime", "Text" },
                values: new object[] { new DateTime(2020, 5, 10, 20, 45, 34, 783, DateTimeKind.Local).AddTicks(7022), "" });

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
    }
}
