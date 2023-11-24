using AutoMapper;
using Restaurant.EntityLayer.Dtos.Contact;
using Restaurant.EntityLayer.Entities;

namespace Restaurant.WebApi.Mapping
{
    public class ContactMapper:Profile
    {
        public ContactMapper()
        {
            CreateMap<Contact, ResultContactDto>().ReverseMap();   
            CreateMap<Contact, CreateContactDto>().ReverseMap();   
            CreateMap<Contact, UpdateContactDto>().ReverseMap();   
            CreateMap<Contact, GetContactDto>().ReverseMap();   
        }
    }
}
