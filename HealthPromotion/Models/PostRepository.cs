using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPromotion.Models
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext appDbContext;

        public PostRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }


        public IEnumerable<Post> AllPost
        {
            get
            {
                return appDbContext.Posts.Include(c => c.Category);
            }
        }

        public IEnumerable<Post> PostOfTheWeek
        {
            get
            {
                return appDbContext.Posts.Include(c => c.Category).Where(p => p.PostOfWeek);
            }
        }

        public Post getPostById(int postId)
        {
            return appDbContext.Posts.First(x => x.PostId == postId); 
        }
    }
}
