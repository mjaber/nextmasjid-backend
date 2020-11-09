using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IbnMasjjed.Proxy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IbnMasjjed.Admin.Controllers
{
    [Authorize]
    public class CityController : Controller
    {
        private readonly ICityProxy _cityProxy;

        public  CityController(ICityProxy cityProxy)
        {
            _cityProxy = cityProxy;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _cityProxy.GetAll();

            if (result.IsSuccess)
                return View(result.Data);

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var result = await _cityProxy.GetById(id);

            if (result.IsSuccess)
                return View(result.Data);

            return new StatusCodeResult((int)result.HttpStatusCode);
        }

        [HttpGet]
        public async Task<JsonResult> GetAll()
        {
            var result = await _cityProxy.GetAll();
            var citiesList = result.Data.Select(p => new { p.Id, p.Name }).ToArray();
            return Json(citiesList);
        }


    }
}
