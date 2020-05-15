using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthPromotion.Migrations
{
    public partial class addTextFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "DateTime", "Text" },
                values: new object[] { new DateTime(2020, 5, 15, 8, 18, 44, 373, DateTimeKind.Local).AddTicks(1722), "Вопросами мотивации сегодня не занимается только ленивый. Попадаются достаточно любопытные взгляды – с привлечением таких понятий как «смысл», «служение» и другие. Я бы хотел предложить взглянуть на мотивацию как процесс движения к большей воодушевленности через интенциональность (намеренность). Сам процесс достаточно подробно описал известный психотерапевт Джеймс Бьюдженталь в своей книге «Искусство психотерапевта». Мы разберем главный тезис – как происходит внутренняя самомотивация человека? Как люди, мы принимаем участия в процессе созидания действительности. Мы имеем способности к намерениям, постановке целей и действиям по их реализации. Как сказал классик: «Мы – процесс того, что мы делаем. Мы не то, что мы делаем, мы – само делание. Мы не то, о чем мы думаем – мы само мышление». Итак, побуждение, намерение (или мотив) проходит эти стадии, прежде чем превратиться в реальность. Интенциональность. Это рождение глубоко внутреннего сигнала быть и делать из самых глубин подсознания. Пока это все потенциальное. Желания. Появление обобщенных желаний, которые легки и непостоянны, типа «хотел бы иметь крылья и летать, как птица» или «как узнать опыт других людей». Хотения. Проверенные реальностью желания – мы продолжаем желать, но уже в реальности. Появляется список действительных возможностей: «можно летать на самолете, заняться экстремальным вингсьютингом или летать в аэротрубе» или «смотреть интервью с интересными людьми, читать книги или авторские статьи». Волевое намерение. Наше столкновение с отказом от одних хотений в пользу других. Выбирая самолет, я смогу заняться вингсьютингом только позже. А может быть, и не смогу совсем. Выбираю книгу, а не просмотр видео-интервью. Действие. Вот здесь – резкий переход от внутреннего к внешнему. Я беру с полки одну книгу и листаю ее, откладываю в сторону, беру другую, сравниваю внутри себя, выбираю. Пока действие предварительное. Я только определяюсь, например, делая предварительный звонок в школу пилотов. Актуализация. Оказалось, что книга именно о том, меня интересует, что школа пилотов мне подходит – тогда намерение становится частью моей реальности. Для меня это важно. Я читаю книгу целиком, или заканчиваю курсы пилотов, или хожу на тренировки в спортзал, или держу диету. Взаимодействие. Выбор неизбежно вызовет перестройку среди других побуждений (мотивов). Отодвинет на второй план другие дела, произведет пересмотр ценностей, поменяет систему отношений. Поэтому глубинная психотерапия меняет и человека, и его жизнь.    " });

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
                columns: new[] { "DateTime", "Text" },
                values: new object[] { new DateTime(2020, 5, 15, 8, 18, 44, 373, DateTimeKind.Local).AddTicks(1857), "Размышляли ли вы когда-нибудь о том, что любое качество в вашем характере одновременно является и недостатком и достоинством? Например, общительность в неподходящее время может проявляться как навязчивость, а интровертивность/молчаливость, может быть интерпретирована как дар скромности. Секрет лишь в том, как мы выбираем относиться к своим качествам. И тревожность в этом контексте не исключение. Однако как нести ущерб от тревожного состояния вы уже наверняка знаете, а вот как заводить с ним дружбу – нужно еще разобраться. Об этом и пойдет речь в этой статье, которая появилась на основе тематического вебинара «Тревога как ресурс» (Сильченко М., Ободовская Ю., 2018)." });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 5, 15, 8, 12, 49, 168, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 5, 15, 8, 12, 49, 169, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "DateTime", "Text" },
                values: new object[] { new DateTime(2020, 5, 15, 8, 12, 49, 169, DateTimeKind.Local).AddTicks(887), "" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 5, 15, 8, 12, 49, 169, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 5, 15, 8, 12, 49, 169, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                columns: new[] { "DateTime", "Text" },
                values: new object[] { new DateTime(2020, 5, 15, 8, 12, 49, 169, DateTimeKind.Local).AddTicks(955), "" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 5, 15, 8, 12, 49, 169, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2020, 5, 15, 8, 12, 49, 169, DateTimeKind.Local).AddTicks(993));
        }
    }
}
