using AutoMapper;
using Restaurant.EntityLayer.Dtos.About;
using Restaurant.EntityLayer.Entities;

namespace Restaurant.WebApi.Mapping
{
    public class AboutMapper:Profile
    {
        public AboutMapper()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
        }
    }
}
