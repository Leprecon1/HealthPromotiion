using HealthPromotion.Models;
using HealthPromotion.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPromotion.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostRepository postRepository;
        private readonly AppDbContext db;

        public HomeController(IPostRepository postRepository, AppDbContext db)
        {
            this.postRepository = postRepository;
            this.db = db;
        }

     
        public IActionResult Index(string category)
        {
            string _category = category;
            IEnumerable<Post> posts;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                posts = postRepository.AllPost.OrderBy(i => i.PostId);
                currCategory = "All posts";
            }
            else
            {
                posts = postRepository.AllPost.Where(x => x.Category.CategoryName == category).OrderBy(i => i.PostId);
                currCategory = _category;
               
            }

            var homeViewModel = new HomeViewModel
            {
                PostOfWeek = postRepository.PostOfTheWeek,
                GetAllPosts = posts,
                CurrCategory = _category
            };
            return View(homeViewModel);
        }

        public IActionResult PostDetails(int id)
        {
            var post = postRepository.getPostById(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.PostId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
            return "Спасибо за публикацию!";
        }
      
    }
}
