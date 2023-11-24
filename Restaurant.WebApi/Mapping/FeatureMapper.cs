using AutoMapper;
using Restaurant.EntityLayer.Dtos.Feature;
using Restaurant.EntityLayer.Entities;

namespace Restaurant.WebApi.Mapping
{
    public class FeatureMapper:Profile
    {
        public FeatureMapper()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetFeatureDto>().ReverseMap();
        }
    }
}
