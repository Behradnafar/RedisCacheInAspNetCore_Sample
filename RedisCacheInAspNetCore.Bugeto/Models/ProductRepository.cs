using RedisCacheInAspNetCore.Bugeto.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RedisCacheInAspNetCore.Bugeto.Models
{
    public interface IProductRepository
    {
        HomePageDto GetHomePageProducts();
    }
    public class ProductRepository: IProductRepository
    {
        public HomePageDto GetHomePageProducts()
        {
            Thread.Sleep(3000);
            return new HomePageDto()
            {
                 BestProduct = new BestProduct()
                {
                    Products = new List<ProductDto>()
                      {
                           new ProductDto { Id=1, Name="Solid Tutorial"},
                           new ProductDto { Id=2, Name="Design pattern Tutorial"}
                      }
                },
                 LastProduct = new LastProduct()
                {
                    Products = new List<ProductDto>()
                      {
                           new ProductDto { Id=3, Name="Microservices"},
                           new ProductDto { Id=4, Name="DDD"},
                           new ProductDto { Id=5, Name="C#"}
                      }
                }
            };
        }
    }
}
