﻿using System.Collections.Generic;
using System.Linq;
using Moq;
using SportsStore.Controllers;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

using Xunit;
namespace SportsStore.Tests
{
    public class ProductControllerTests
    {
        [Fact]
        public void Can_Paginate()
        {
            // Przygotowanie.
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new ProductE[] {
             new ProductE {Id = 1, Name = "P1"},
             new ProductE {Id = 2, Name = "P2"},
             new ProductE {Id = 3, Name = "P3"},
             new ProductE {Id = 4, Name = "P4"},
             new ProductE {Id = 5, Name = "P5"}
             }).AsQueryable<ProductE>());
            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;
            // Działanie.
            ProductsListViewModel result = controller.List(2).ViewData.Model as ProductsListViewModel;
            // Asercje.

            ProductE[] prodArray = result.Products.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.Equal("P4", prodArray[0].Name);
            Assert.Equal("P5", prodArray[1].Name);
        }



        [Fact]
        public void Can_Send_Pagination_View_Model()
        {
            // Przygotowanie.
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new ProductE[] {
             new ProductE {Id = 1, Name = "P1"},
             new ProductE {Id = 2, Name = "P2"},
             new ProductE {Id = 3, Name = "P3"},
             new ProductE {Id = 4, Name = "P4"},
             new ProductE {Id = 5, Name = "P5"}
             }).AsQueryable<ProductE>());
            // Przygotowanie.
            ProductController controller =
            new ProductController(mock.Object) { PageSize = 3 };
            // Działanie.
            ProductsListViewModel result = controller.List(2).ViewData.Model as ProductsListViewModel;
            // Asercje.
            PagingInfo pageInfo = result.PagingInfo;
            Assert.Equal(2, pageInfo.CurrentPage);
            Assert.Equal(3, pageInfo.ItemsPerPage);
            Assert.Equal(5, pageInfo.TotalItems);
            Assert.Equal(2, pageInfo.TotalPages);
        }
    }
}