using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BusinessLayer.Abstract;
using Restaurant.DataAccessLayer.EntityFramework;
using Restaurant.EntityLayer.Dtos.About;
using Restaurant.EntityLayer.Dtos.Booking;
using Restaurant.EntityLayer.Entities;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _mapper.Map<List<ResultBookingDto>>(_bookingService.TGetList());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(CreateBookingDto createBookingDto)
        {
            Booking booking= _mapper.Map<Booking>(createBookingDto);
            _bookingService.TAdd(booking);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            _bookingService.TRemove(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking= _mapper.Map<Booking>(updateBookingDto);
            _bookingService.TUpdate(booking);
            return Ok();
        }
        [HttpGet("GetBooking")]
        public IActionResult GetBooing(int id)
        {
            var values = _bookingService.TGetById(id);
            return Ok(values);
        }
    }
}
