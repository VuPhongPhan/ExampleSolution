﻿using ShowSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowSolution.ViewModels.Catalog.Products.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}