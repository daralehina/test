using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Data.Models;

namespace test.ViewModels
{
    public class PostsListViewModel
    {

        public IEnumerable<Post> allPosts { get; set; }

        public string currCategory { get; set; }
    }
}
