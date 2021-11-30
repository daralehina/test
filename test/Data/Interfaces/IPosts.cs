using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Data.Models;

namespace test.Data.Interfaces
{
    public interface IPosts
    {
        IEnumerable<Post> Posts { get; }
        IEnumerable<Post> FavPosts { get; }

        Post GetObjectPost( int PostID);
    }
}
