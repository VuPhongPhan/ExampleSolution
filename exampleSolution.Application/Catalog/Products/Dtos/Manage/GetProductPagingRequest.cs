using exampleSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace exampleSolution.Application.Catalog.Products.Dtos
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryIds { get; set; }


    }
}
