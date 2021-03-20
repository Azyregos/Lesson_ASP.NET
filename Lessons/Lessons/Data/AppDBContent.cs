using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Lessons.Data.Models;

namespace Lessons.Data
{
    public class AppDBContent : DbContext
    {
        public DbSet<Car> Car { get; set; }

        public DbSet<Category> Category { get; set; }

        public AppDBContent(DbContextOptions<AppDBContent> options): base(options)
        {
            Database.EnsureCreated();
        }

        
    }
}
