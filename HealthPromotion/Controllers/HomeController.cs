
using HealthPromotion.Models;
using HealthPromotion.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.IO;
using Microsoft.AspNetCore.Hosting;

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
                GetAllPosts = posts,
                CurrCategory = _category
            };
            return View(homeViewModel);
        }

        public IActionResult PostDetails(int id) // CALL TWO TIME! 
        {
            if (id == 0)
            {
                return NotFound("Публикация не найдена");
            }
            var post = postRepository.getPostById(id);

            return View(post);
        }

        public IActionResult Search(string postName) {
            var posts = postRepository.AllPost;
            if (!string.IsNullOrEmpty(postName))
            {
                posts = postRepository.AllPost.
                    Where(x => x.Name.ToLower().Trim() == postName.ToLower().Trim());
            }
            else
            {
                return RedirectToAction("Index");
            }
            var homeViewMoel = new HomeViewModel
            {
                GetAllPosts = posts,
            };
            return View(homeViewMoel);
        }

    

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string login, string password)
        {
            string authData = $"Login: {login} Password: {password}";
            return Content(authData);
        }

        public IActionResult Blog() => View();
        public IActionResult FeedBack() => View();
    }
}
