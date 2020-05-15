
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
        private readonly IWebHostEnvironment _appEnvironment;

        public HomeController(IPostRepository postRepository, AppDbContext db, IWebHostEnvironment appEnvironment)
        {
            this.postRepository = postRepository;
            this.db = db;
            _appEnvironment = appEnvironment;
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

        public IActionResult PostDetails(int id)
        {
            var post = postRepository.getPostById(id);
            if (post == null)
            {
                return NotFound("Публикация не найдена");
            }
      
            return View(post);
        }

        public IActionResult Search(string postName) {
            var posts = postRepository.AllPost;
            if (!string.IsNullOrEmpty(postName))
            {
                posts = postRepository.AllPost.Where(x => x.Name == postName);
            }
            var homeViewMoel = new HomeViewModel
            {
                GetAllPosts = posts,
            };
            return View(homeViewMoel);
        }

        [HttpGet]
        public IActionResult AddPost(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.PostId = id;
            return View();
        }

        [HttpPost]
        public string AddPost(Post post)
        {
        
            db.Posts.Add(post); // indentity insert off
            db.SaveChanges();
            return "Спасибо за публикацию!";
        }

        public IActionResult Blog() => View();
        public IActionResult FeedBack() => View();


        public IActionResult GetFile()
        {
            // Путь к файлу
            string file_path = Path.Combine(_appEnvironment.ContentRootPath, "Files/book.pdf");
            // Тип файла - content-type
            string file_type = "application/pdf";
            // Имя файла - необязательно
            string file_name = "book.pdf";
            return PhysicalFile(file_path, file_type, file_name);
        }
    }
}
