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
    public class PolygonController : ControllerBase
    {
        private readonly IPolygonService _polygonService;
        public PolygonController(IPolygonService polygonService)
        {
            _polygonService = polygonService;
        }


        [HttpGet]
        [Route("api/v1/city/{Id}/[controller]")]
        public async Task<ActionResult<ReturnResult<DomainView.CityPolygonView[]>>> GetPloygonByCityId(int Id)
        {
            var result = await _polygonService.GetPloygonByCityId(Id);
            return StatusCode((int)result.HttpStatusCode, result);
        }

        [HttpPost]
        [Route("api/v1/[controller]")]
        public async Task<ActionResult<ReturnResult<int>>> Create([FromBody]DomainView.CityPolygonView polygon)
        {
            if (polygon == null)
                return BadRequest();

            var result = await _polygonService.Create(polygon);
            return StatusCode((int)result.HttpStatusCode, result);
        }




    }
}
