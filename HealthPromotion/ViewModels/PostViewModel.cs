using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPromotion.ViewModels
{
    public class PostViewModel
    {
        public int PostId { get; set; }
        public string AuthorName { get; set; }
        public bool Available { get; set; }

        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Text { get; set; }
        public IFormFile Image { get; set; }
        public bool PostOfWeek { get; set; }
        public int CategoryId { get; set; }
    }
}
