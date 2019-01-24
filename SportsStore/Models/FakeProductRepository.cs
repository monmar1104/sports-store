using System;
using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<ProductE> Products => new List<ProductE>
        {
            new ProductE { Name = "Piłka nożna", Price = 25 },
            new ProductE { Name = "Deska surfingowa", Price = 179 },
            new ProductE { Name = "Buty do biegania", Price = 95 }
        }.AsQueryable<ProductE>();
    }
}
