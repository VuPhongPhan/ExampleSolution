using ShowSolution.ViewModels.Catalog.Products;
using ShowSolution.ViewModels.Catalog.Products.Public;
using ShowSolution.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace exampleSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}
