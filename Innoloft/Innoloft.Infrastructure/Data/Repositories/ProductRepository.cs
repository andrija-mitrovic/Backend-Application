using Innoloft.Core.Helpers;
using Innoloft.Core.Interfaces;
using Innoloft.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Innoloft.Infrastructure.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<Product>> GetProductsWithTypeAndUserAsync()
        {
            return await _context.Products
                                 .Include(t => t.ProductType)
                                 .Include(u=>u.User)
                                 .ThenInclude(a => a.Address)
                                 .ThenInclude(p => p.Geo)
                                 .Include(u => u.User)
                                 .ThenInclude(c => c.Company)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsWithTypeAndUserAsync(PagingParams pagingParams)
        {
            var products = _context.Products
                                 .Include(t => t.ProductType)
                                 .Include(u => u.User)
                                 .ThenInclude(a => a.Address)
                                 .ThenInclude(p => p.Geo)
                                 .Include(u => u.User)
                                 .ThenInclude(c => c.Company)
                                 .AsQueryable();

            if (pagingParams.ProductTypeId > 0)
                products = products.Where(p => p.ProductTypeId == pagingParams.ProductTypeId);

            return await PagedList<Product>.CreateAsync(products, pagingParams.PageNumber, pagingParams.PageSize);
        }

        public async Task<Product> GetProductWithTypeAndUserByIdAsync(int id)
        {
            return await _context.Products
                                 .Include(t => t.ProductType)
                                 .Include(u => u.User)
                                 .ThenInclude(a => a.Address)
                                 .ThenInclude(p => p.Geo)
                                 .Include(u => u.User)
                                 .ThenInclude(c => c.Company)
                                 .Include(u => u.User).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
