using exampleSolution.Application.Catalog.Products.Dtos;
using exampleSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace exampleSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProdutUpdateRequest request);

        Task<int> Detele(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);

        Task<List<ProductViewModel>> GetAll();

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);

    }
}
