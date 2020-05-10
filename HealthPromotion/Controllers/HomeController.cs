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

        public HomeController(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PostOfWeek = postRepository.PostOfTheWeek,
                GetAllPosts = postRepository.AllPost
                
            };
            return View(homeViewModel);
        }
    }
}
