using exampleSolution.Application.Catalog.Products.Dtos;
using exampleSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace exampleSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedResult<ProductViewModel> GetAllByCategory(GetProductPagingRequest request);
    }
}
