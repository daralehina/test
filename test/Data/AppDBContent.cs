using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Data.Models;

namespace test.Data
{
    public class AppDBContent : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) { }

        public DbSet<Post> Post { get; set; }
        public DbSet<Category> Category { get; set; } 
    }
}
