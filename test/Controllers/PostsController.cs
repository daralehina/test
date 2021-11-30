using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Data.Interfaces;
using test.ViewModels;


namespace test.Controllers
{
    public class PostsController : Controller
    {
        private readonly IPosts _allposts;
        private readonly ICategory _allcategory;

        public PostsController(IPosts iposts, ICategory icategory) {
            _allposts = iposts;
            _allcategory = icategory;
        }

        public ViewResult List() {
            ViewBag.Title = "Блог";
            PostsListViewModel obj = new PostsListViewModel();
            obj.allPosts = _allposts.Posts;
            obj.currCategory = "Лента";
            //var posts = _allposts.Posts;
            return View(obj);
        }
    }
}
