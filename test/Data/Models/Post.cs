using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Data.Models
{
    public class Post
    {
        public int id { set; get; }

        public string name { set; get; }

        public string shortDesc { set; get; }

        public string longDesc { set; get; }

        public string img { set; get; }

        public bool isFavourite { set; get; }

        //public bool available { set; get; }

        public int categoryID { set; get; }

        public virtual Category Category { set; get; }


    }
}
