using Innoloft.Core.Helpers;
using Innoloft.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Innoloft.Core.Interfaces
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsWithTypeAndUserAsync();
        Task<IEnumerable<Product>> GetProductsWithTypeAndUserAsync(PagingParams pagingParams);
        Task<Product> GetProductWithTypeAndUserByIdAsync(int id);
    }
}
