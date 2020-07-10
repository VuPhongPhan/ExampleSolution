using System;
using System.Collections.Generic;
using System.Text;

namespace exampleSolution.Application.Catalog.Products.Dtos
{
    public class ProductCreateRequest
    {
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
    }
}
