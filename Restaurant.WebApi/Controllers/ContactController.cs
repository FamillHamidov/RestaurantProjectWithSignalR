using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BusinessLayer.Abstract;
using Restaurant.DataAccessLayer.EntityFramework;
using Restaurant.EntityLayer.Dtos.About;
using Restaurant.EntityLayer.Dtos.Contact;
using Restaurant.EntityLayer.Entities;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _mapper.Map<List<ResultContactDto>>(_contactService.TGetList());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddContact(CreateContactDto createContactDto)
        {
            Contact contact= _mapper.Map<Contact>(createContactDto);
            _contactService.TAdd(contact);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetById(id);
            _contactService.TRemove(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            Contact contact= _mapper.Map<Contact>(updateContactDto);
            _contactService.TUpdate(contact);
            return Ok();
        }
        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var values = _contactService.TGetById(id);
            return Ok(values);
        }
    }
}
