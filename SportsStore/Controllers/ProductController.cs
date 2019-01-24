using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productRepository;
        public int PageSize = 4;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public ViewResult List(int productPage = 1) =>
            View(new ProductsListViewModel
            {
                Products = productRepository.Products
                    .OrderBy(p => p.Id)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = productRepository.Products.Count()
                }
            }
            );
    }
}
