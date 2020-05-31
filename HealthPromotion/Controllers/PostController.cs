using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using HealthPromotion.Models;
using HealthPromotion.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthPromotion.Controllers
{
    public class PostController : Controller
    {

        private readonly AppDbContext db;

        public PostController(AppDbContext db)
        {   
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
            Post post =
                new Post {
                    AuthorName = pst.AuthorName,
                    Available = pst.Available,
                    Name = pst.Name,
                    DateTime = DateTime.Now,
                    ShortDescription = pst.ShortDescription,
                    Text = pst.Text,
                    PostOfWeek = false,
                    CategoryId = pst.CategoryId
                };

            byte[] imageData = null;
            using (var binaryReader = new BinaryReader(pst.Image.OpenReadStream()))
            {
                imageData = binaryReader.ReadBytes((int)pst.Image.Length);
            }
            post.Image = imageData;

            db.Posts.Add(post); 
            db.SaveChanges();
            return Redirect("/Home/Index");
        }
    }
}