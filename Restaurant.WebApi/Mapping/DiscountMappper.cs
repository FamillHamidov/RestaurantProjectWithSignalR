using AutoMapper;
using Restaurant.EntityLayer.Dtos.Discount;
using Restaurant.EntityLayer.Entities;

namespace Restaurant.WebApi.Mapping
{
    public class DiscountMappper:Profile
    {
        public DiscountMappper()
        {
            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
            CreateMap<Discount, GetDiscountDto>().ReverseMap();
        }
    }
}
