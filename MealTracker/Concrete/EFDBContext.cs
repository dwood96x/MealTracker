using MealTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MealTracker.Concrete
{
    public class EFDBContext : DbContext
    {
        public EFDBContext()
            : base("name=EFDbContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}