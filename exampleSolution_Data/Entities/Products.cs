using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace exampleSolution_Data.Entities
{
    public class Products
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public string SeoAlias { set; get; }
    }
}
