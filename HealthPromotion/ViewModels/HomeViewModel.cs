using HealthPromotion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPromotion.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Post> PostOfWeek { get; set; }
        public IEnumerable<Post> GetAllPosts { get; set; }
        public string CurrCategory { get; set; }

    }
}
