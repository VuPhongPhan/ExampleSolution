using ShowSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowSolution.ViewModels.Catalog.Products.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string LanguageId { get; set; }
        public int? CategoryId { get; set; }
    }
}
