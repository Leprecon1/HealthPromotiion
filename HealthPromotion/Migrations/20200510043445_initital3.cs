using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthPromotion.Migrations
{
    public partial class initital3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(nullable: true),
                    Available = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    ShortDescription = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    PostOfWeek = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Food" },
                    { 2, "Motivation" },
                    { 3, "Training" },
                    { 4, "Science and medicine" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "AuthorName", "Available", "CategoryId", "DateTime", "Image", "Name", "PostOfWeek", "ShortDescription", "Text" },
                values: new object[,]
                {
                    { 1, "Илья Черкасов", true, 1, new DateTime(2020, 5, 10, 7, 34, 45, 33, DateTimeKind.Local).AddTicks(5591), "/img/dish.jpg", "Тарелка здорового питания", true, "Мы сделали красивую тарелку здорового питания", "" },
                    { 5, "Илья Черкасов", true, 1, new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6737), "/img/blog-post/blog-post1.jpg", "10 продуктов в холодильники диетолога", false, "Диетолог Елена Мельникова рассказала, какие продукты всегда есть в ее холодильнике и чем она сама обедает и перекусывает с максимальной пользой для своего здоровья.", "" },
                    { 3, "Илья Черкасов", true, 2, new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6685), "/img/self_development.jpg", "7 стадий самомотивации", true, "Психотерапевт, научный сотрудник Института мозга человека РАН Денис написал статью", "" },
                    { 4, "Илья Черкасов", true, 2, new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6714), "/img/Before_and_After.jpg", "ДО и ПОСЛЕ: 42 свежие фотоистории", false, "42 настоящие мотивирующие истории ДО и ПОСЛЕ", "" },
                    { 6, "Илья Черкасов", true, 2, new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6762), "/img/blog-post/blog-post2.jpg", "Тревожность как ресурс: позволение, принятие, объятие", false, "Психотерапевт Марина Сильченко дает подробную инструкцию с упражнениями - как подружиться с тревожностью и высвободить энергию на свершения за 3 этапа - Позволение, Принятие и Объятие.", "" },
                    { 7, "Илья Черкасов", true, 3, new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6784), "/img/blog-post/blog-post3.jpg", "7 шагов силовой подготовки бойца: баланс между силой, выносливостью и свободой движения", false, "Какими бы единоборствами вы ни занимались: от бокса до борьбы, от UFC до туйшоу - эти универсальные рецепты тренировок от знаменитого врача и тренера вам помогут.", "" },
                    { 8, "Илья Черкасов", true, 3, new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6853), "/img/blog-post/blog-post4.jpg", "Что эффективнее: одна высокоинтенсивная в неделю или регулярные среднеинтенсивные тренировки?", false, "Хороший научный аргумент против мнения о том, что надо либо тренироваться 3-4 раза в неделю, либо вообще не тренироваться", "" },
                    { 2, "Илья Черкасов", true, 4, new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6574), "/img/virus.jpg", "Короновирус. Как защититься.", true, "Все, что известно на сегодня о защите от коронавируса.", "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
