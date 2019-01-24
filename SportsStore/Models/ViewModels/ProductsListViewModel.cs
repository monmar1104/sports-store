using System.Collections.Generic;
using SportsStore.Models;
namespace SportsStore.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<ProductE> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}