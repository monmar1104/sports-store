using System;
using System.Linq;

namespace SportsStore.Models
{
    public interface IProductRepository
    {
        IQueryable<ProductE> Products { get; }
    }
}
