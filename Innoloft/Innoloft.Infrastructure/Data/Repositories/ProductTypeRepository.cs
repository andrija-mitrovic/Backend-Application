using Innoloft.Core.Interfaces;
using Innoloft.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Innoloft.Infrastructure.Data.Repositories
{
    public class ProductTypeRepository : GenericRepository<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(ApplicationDbContext context) : base(context) { }
    }
}
