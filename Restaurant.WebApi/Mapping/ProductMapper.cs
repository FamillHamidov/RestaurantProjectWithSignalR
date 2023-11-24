using AutoMapper;
using Restaurant.EntityLayer.Dtos.Product;
using Restaurant.EntityLayer.Entities;

namespace Restaurant.WebApi.Mapping
{
    public class ProductMapper:Profile
    {
        public ProductMapper()
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
        }
    }
}
