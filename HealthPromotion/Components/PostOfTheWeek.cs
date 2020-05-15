using HealthPromotion.Models;
using HealthPromotion.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPromotion.Components
{
    public class PostOfTheWeek:ViewComponent
    {
        private readonly IPostRepository postRepository;

        public PostOfTheWeek(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public IViewComponentResult Invoke()
        {
            var PostOfTheWeek = new PostOfWeekViewModel
            {
                PostOfWeek = postRepository.AllPost.Where(x => x.PostOfWeek == true)
            };
            return View(PostOfTheWeek);
        }

    }
}
