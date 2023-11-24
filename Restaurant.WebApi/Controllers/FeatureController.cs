using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BusinessLayer.Abstract;
using Restaurant.DataAccessLayer.EntityFramework;
using Restaurant.EntityLayer.Dtos.About;
using Restaurant.EntityLayer.Dtos.Feature;
using Restaurant.EntityLayer.Entities;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult FeatureList()
        {
            var values = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetList());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddFeature(CreateFeatureDto createFeatureDto)
        {
            Feature feature= _mapper.Map<Feature>(createFeatureDto);
            _featureService.TAdd(feature);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.TGetById(id);
            _featureService.TRemove(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            Feature feature= _mapper.Map<Feature>(updateFeatureDto);
            _featureService.TUpdate(feature);
            return Ok();
        }
        [HttpGet("GetFeature")]
        public IActionResult GetFeature(int id)
        {
            var values = _featureService.TGetById(id);
            return Ok(values);
        }
    }
}
