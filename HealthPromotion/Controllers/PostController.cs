using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using HealthPromotion.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthPromotion.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostRepository postRepository;
        private readonly AppDbContext db;

        public PostController(IPostRepository postRepository, AppDbContext db)
        {
            this.postRepository = postRepository;
            this.db = db;
        }
   
        [HttpGet]
        public IActionResult AddPost()
        {
            return View();
        }
        

        [HttpPost]
        public RedirectResult AddPost(PostViewModel pst)
        {
            Post post = new Post { DateTime = DateTime.UtcNow, PostOfWeek = false};

            byte[] imageData = null;
            using (var binaryReader = new BinaryReader(pst.image.OpenReadStream()))
            {
                imageData = binaryReader.ReadBytes((int)post.Image.Length);
            }
            post.Image = imageData;

            db.Posts.Add(post); 
            db.SaveChanges();
            return Redirect("/Home/Index");
        }

        
       
    }
}