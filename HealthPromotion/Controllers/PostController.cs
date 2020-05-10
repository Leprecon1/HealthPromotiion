
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
        AppDbContext db;

        public PostController(AppDbContext dbContext)
        {
            db = dbContext;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Page of posts";
            PostListViewModel postListViewModel = new PostListViewModel();
            postListViewModel.GetAllPosts = db.Posts.ToList();
            postListViewModel.CurrCategory = "Посты";
            return View(postListViewModel);
        }
    }
}
