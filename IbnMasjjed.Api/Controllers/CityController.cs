using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IbnMasjjed.DomainView.Models;
using IbnMasjjed.ServiceInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IbnMasjjed.Api.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }


        [HttpGet]
        [Route("api/v1/[controller]/{Id}")]
        public async Task<ActionResult<ReturnResult<DomainView.CityLookupView>>> CityById(int Id)
        {
            var result = await _cityService.CityById(Id);
            return StatusCode((int)result.HttpStatusCode, result);
        }

        [HttpGet]
        [Route("api/v1/[controller]")]
        public async Task<ActionResult<ReturnResult<DomainView.CityLookupView[]>>> GetAllCities()
        {
            var result = await _cityService.CityAll();
            return StatusCode((int)result.HttpStatusCode, result);
        }


    }
}
