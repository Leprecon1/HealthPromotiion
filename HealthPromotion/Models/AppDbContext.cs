using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPromotion.Models
{
    public class AppDbContext : DbContext   
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Food" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Motivation" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Training" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Science and medicine" });

            modelBuilder.Entity<Post>().HasData(new Post
            {
                PostId = 1,
                AuthorName = "Илья Черкасов",
                Available = true,
                Name = "Тарелка здорового питания",
                DateTime = DateTime.Now,
                ShortDescription = "Мы сделали красивую тарелку здорового питания",
                Text = "",
                Image = "/img/blog-post/dish.jpg",
                PostOfWeek = true,
                CategoryId = 1
            });

            modelBuilder.Entity<Post>().HasData(new Post
            {
                PostId = 2,
                AuthorName = "Илья Черкасов",
                Available = true,
                Name = "Короновирус. Как защититься.",
                DateTime = DateTime.Now,
                ShortDescription = "Все, что известно на сегодня о защите от коронавируса.",
                Text = "",
                Image = "/img/blog-post/virus.jpg",
                PostOfWeek = true,
                CategoryId = 4
            });

            modelBuilder.Entity<Post>().HasData(new Post
            {
                PostId = 3,
                AuthorName = "Илья Черкасов",
                Available = true,
                Name = "7 стадий самомотивации",
                DateTime = DateTime.Now,
                ShortDescription = "Психотерапевт, научный сотрудник Института мозга человека РАН Денис написал статью",
                Text = "",
                Image = "/img/blog-post/self_development.jpg",
                PostOfWeek = true,
                CategoryId = 2,
            });

            modelBuilder.Entity<Post>().HasData(new Post
            {
                PostId = 4,
                AuthorName = "Илья Черкасов",
                Available = true,
                Name = "ДО и ПОСЛЕ: 42 свежие фотоистории",
                DateTime = DateTime.Now,
                ShortDescription = "42 настоящие мотивирующие истории ДО и ПОСЛЕ",
                Text = "",
                Image = "/img/blog-post/Before_and_After.jpg",
                PostOfWeek = false,
                CategoryId = 2
            });

            modelBuilder.Entity<Post>().HasData(new Post
            {
                PostId = 5,
                AuthorName = "Илья Черкасов",
                Available = true,
                Name = "10 продуктов в холодильники диетолога",
                DateTime = DateTime.Now,
                ShortDescription = "Диетолог Елена Мельникова рассказала, какие продукты " +
                "всегда есть в ее холодильнике и чем она сама обедает и перекусывает с" +
               " максимальной пользой для своего здоровья.",
                Text = "",
                Image = "/img/blog-post/blog-post1.jpg",
                PostOfWeek = false,
                CategoryId = 1,
            });

            modelBuilder.Entity<Post>().HasData(new Post
            {
                PostId = 6,
                AuthorName = "Илья Черкасов",
                Available = true,
                Name = "Тревожность как ресурс: позволение, принятие, объятие",
                DateTime = DateTime.Now,
                ShortDescription = "Психотерапевт Марина Сильченко дает подробную инструкцию с упражнениями - как подружиться" +
                " с тревожностью и высвободить энергию на свершения за 3 этапа - Позволение, Принятие и Объятие.",
                Text = "",
                Image = "/img/blog-post/blog-post2.jpg",
                PostOfWeek = false,
                CategoryId = 2
            });

            modelBuilder.Entity<Post>().HasData(new Post
            {
                PostId = 7,
                AuthorName = "Илья Черкасов",
                Available = true,
                Name = "7 шагов силовой подготовки бойца: баланс между силой, выносливостью и свободой движения",
                DateTime = DateTime.Now,
                ShortDescription = "Какими бы единоборствами вы ни занимались: от бокса до борьбы, от UFC до туйшоу - " +
                "эти универсальные рецепты тренировок от знаменитого врача и тренера вам помогут.",
                Text = "",
                Image = "/img/blog-post/blog-post3.jpg",
                PostOfWeek = false,
                CategoryId = 3
            }) ;

            modelBuilder.Entity<Post>().HasData(new Post
            {
                PostId = 8,
                AuthorName = "Илья Черкасов",
                Available = true,
                Name = "Что эффективнее: одна высокоинтенсивная в неделю или регулярные среднеинтенсивные тренировки?",
                DateTime = DateTime.Now,
                ShortDescription = "Хороший научный аргумент против мнения о том, что надо либо тренироваться" +
                " 3-4 раза в неделю, либо вообще не тренироваться",
                Text = "",
                Image = "/img/blog-post/blog-post4.jpg",
                PostOfWeek = false,
                CategoryId = 3
            });


        }
    }
}
