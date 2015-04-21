using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Web.portfolio1.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class RecipeDBContext : DbContext
    {

        public DbSet<Recipe> Recipe { get; set; }

    }

}