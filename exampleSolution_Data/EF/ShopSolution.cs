using exampleSolution_Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace exampleSolution_Data.EF
{
    public class ShopSolution : DbContext
    {
        public ShopSolution(DbContextOptions options) : base(options)
        {
           
        }
        public DbSet<Products> Products { set; get; }
        public DbSet<Category> Categories { set; get; }
    }
}
