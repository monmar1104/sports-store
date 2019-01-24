using System;
using System.Linq;

namespace SportsStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationDbContext context;
        public EFProductRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ProductE> Products => context.Products;
    }
}
