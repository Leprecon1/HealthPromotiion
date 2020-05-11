
using HealthPromotion.Models;
using HealthPromotion.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPromotion.Controllers
{
    public class PostController:Controller
    {
        private readonly AppDbContext db;

        public PostController(AppDbContext dbContext)
        {
            db = dbContext;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Page of posts";
            PostListViewModel postListViewModel = new PostListViewModel
            {
                GetAllPosts = db.Posts.ToList(),
                CurrCategory = "Посты"
            };
            return View(postListViewModel);
        }
    }
}
