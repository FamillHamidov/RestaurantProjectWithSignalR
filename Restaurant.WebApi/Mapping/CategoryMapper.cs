using AutoMapper;
using Restaurant.EntityLayer.Dtos.Category;
using Restaurant.EntityLayer.Entities;

namespace Restaurant.WebApi.Mapping
{
    public class CategoryMapper:Profile
    {
        public CategoryMapper()
        {
            CreateMap<Category,ResultCategoryDto>().ReverseMap();
            CreateMap<Category,CreateCategoryDto>().ReverseMap();
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();
            CreateMap<Category,GetCategoryDto>().ReverseMap();
        }
    }
}
