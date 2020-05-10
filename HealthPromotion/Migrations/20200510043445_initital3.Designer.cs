﻿// <auto-generated />
using System;
using HealthPromotion.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HealthPromotion.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200510043445_initital3")]
    partial class initital3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HealthPromotion.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Food"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Motivation"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Training"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Science and medicine"
                        });
                });

            modelBuilder.Entity("HealthPromotion.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PostOfWeek")
                        .HasColumnType("bit");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            AuthorName = "Илья Черкасов",
                            Available = true,
                            CategoryId = 1,
                            DateTime = new DateTime(2020, 5, 10, 7, 34, 45, 33, DateTimeKind.Local).AddTicks(5591),
                            Image = "/img/dish.jpg",
                            Name = "Тарелка здорового питания",
                            PostOfWeek = true,
                            ShortDescription = "Мы сделали красивую тарелку здорового питания",
                            Text = ""
                        },
                        new
                        {
                            PostId = 2,
                            AuthorName = "Илья Черкасов",
                            Available = true,
                            CategoryId = 4,
                            DateTime = new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6574),
                            Image = "/img/virus.jpg",
                            Name = "Короновирус. Как защититься.",
                            PostOfWeek = true,
                            ShortDescription = "Все, что известно на сегодня о защите от коронавируса.",
                            Text = ""
                        },
                        new
                        {
                            PostId = 3,
                            AuthorName = "Илья Черкасов",
                            Available = true,
                            CategoryId = 2,
                            DateTime = new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6685),
                            Image = "/img/self_development.jpg",
                            Name = "7 стадий самомотивации",
                            PostOfWeek = true,
                            ShortDescription = "Психотерапевт, научный сотрудник Института мозга человека РАН Денис написал статью",
                            Text = ""
                        },
                        new
                        {
                            PostId = 4,
                            AuthorName = "Илья Черкасов",
                            Available = true,
                            CategoryId = 2,
                            DateTime = new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6714),
                            Image = "/img/Before_and_After.jpg",
                            Name = "ДО и ПОСЛЕ: 42 свежие фотоистории",
                            PostOfWeek = false,
                            ShortDescription = "42 настоящие мотивирующие истории ДО и ПОСЛЕ",
                            Text = ""
                        },
                        new
                        {
                            PostId = 5,
                            AuthorName = "Илья Черкасов",
                            Available = true,
                            CategoryId = 1,
                            DateTime = new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6737),
                            Image = "/img/blog-post/blog-post1.jpg",
                            Name = "10 продуктов в холодильники диетолога",
                            PostOfWeek = false,
                            ShortDescription = "Диетолог Елена Мельникова рассказала, какие продукты всегда есть в ее холодильнике и чем она сама обедает и перекусывает с максимальной пользой для своего здоровья.",
                            Text = ""
                        },
                        new
                        {
                            PostId = 6,
                            AuthorName = "Илья Черкасов",
                            Available = true,
                            CategoryId = 2,
                            DateTime = new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6762),
                            Image = "/img/blog-post/blog-post2.jpg",
                            Name = "Тревожность как ресурс: позволение, принятие, объятие",
                            PostOfWeek = false,
                            ShortDescription = "Психотерапевт Марина Сильченко дает подробную инструкцию с упражнениями - как подружиться с тревожностью и высвободить энергию на свершения за 3 этапа - Позволение, Принятие и Объятие.",
                            Text = ""
                        },
                        new
                        {
                            PostId = 7,
                            AuthorName = "Илья Черкасов",
                            Available = true,
                            CategoryId = 3,
                            DateTime = new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6784),
                            Image = "/img/blog-post/blog-post3.jpg",
                            Name = "7 шагов силовой подготовки бойца: баланс между силой, выносливостью и свободой движения",
                            PostOfWeek = false,
                            ShortDescription = "Какими бы единоборствами вы ни занимались: от бокса до борьбы, от UFC до туйшоу - эти универсальные рецепты тренировок от знаменитого врача и тренера вам помогут.",
                            Text = ""
                        },
                        new
                        {
                            PostId = 8,
                            AuthorName = "Илья Черкасов",
                            Available = true,
                            CategoryId = 3,
                            DateTime = new DateTime(2020, 5, 10, 7, 34, 45, 34, DateTimeKind.Local).AddTicks(6853),
                            Image = "/img/blog-post/blog-post4.jpg",
                            Name = "Что эффективнее: одна высокоинтенсивная в неделю или регулярные среднеинтенсивные тренировки?",
                            PostOfWeek = false,
                            ShortDescription = "Хороший научный аргумент против мнения о том, что надо либо тренироваться 3-4 раза в неделю, либо вообще не тренироваться",
                            Text = ""
                        });
                });

            modelBuilder.Entity("HealthPromotion.Models.Post", b =>
                {
                    b.HasOne("HealthPromotion.Models.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
