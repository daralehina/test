using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Data.Interfaces;
using test.Data.Models;

namespace test.Data.Repository
{
    public class PostRepository : IPosts
    {
        private readonly AppDBContent appDBContent;

        public PostRepository(AppDBContent appDBContent) {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Post> Posts => appDBContent.Post.Include(c => c.Category);

        public IEnumerable<Post> FavPosts => appDBContent.Post.Where(p => p.isFavourite).Include(c => c.Category);

        public Post GetObjectPost(int PostID) => appDBContent.Post.FirstOrDefault(p => p.id == PostID);
    }
}
