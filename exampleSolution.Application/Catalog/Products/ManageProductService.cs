﻿using exampleSolution.Application.Catalog.Products.Dtos;
using exampleSolution.Application.Dtos;
using exampleSolution_Data.EF;
using exampleSolution_Data.Entities;
using Microsoft.EntityFrameworkCore;
using ShopSolution.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exampleSolution.Application.Catalog.Products
{
    public class ManageProductService /*: IManageProductService*/
    {
        private readonly ShopDbContext _context;
        public ManageProductService(ShopDbContext context)
        {
            _context = context;
        }

        public async Task AddViewcount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            product.ViewCount += 1;
            await _context.SaveChangesAsync();
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
                OriginalPrice = request.OriginalPrice,
                Stock = request.Stock,
                ViewCount = 0,
                DateCreated = DateTime.Now,
                ProductTranslations = new List<ProductTranslation>()
                {
                    new ProductTranslation()
                    {
                        /*Name = request.Name,
                        Description = request.*/

                    }
                }
            };
            _context.Products.Add(product);
             return await _context.SaveChangesAsync();
        }

        public async Task<int> Detele(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new ShopException($"Cannot find a product: {productId}");
            
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }
       /* public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            //1.select join
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        select new { p, pt, pic };
            //2. filter
            if (string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.pt.Name.Contains(request.Keyword));

            if (request.CategoryIds.Count > 0)
            {
                query = query.Where(p => request.CategoryIds.Contains(p.pic.CategoryId));
            }
            //3.Paging
            int totalRow = await query.CountAsync();
            var data = query.Skip((request.PageIndex - 1) * request.PageIndex).Take(request.PageIndex);
        }*/
        public async Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

       

        public async Task<int> Update(ProdutUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStock(int productId, int addedQuantity)
        {
            throw new NotImplementedException();
        }
    }
}
