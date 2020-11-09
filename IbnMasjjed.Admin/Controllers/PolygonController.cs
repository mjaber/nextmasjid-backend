using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IbnMasjjed.DomainView;
using IbnMasjjed.DomainView.Models;
using IbnMasjjed.Proxy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using IbnMasjjed.Admin.Models.UI;

namespace IbnMasjjed.Admin.Controllers
{
    [Authorize]
    public class PolygonController : Controller
    {
        private readonly IPolygonProxy _polygonProxy;

        public PolygonController(IPolygonProxy polygonProxy)
        {
            _polygonProxy = polygonProxy;
        }

        [HttpGet("city/{Id}/polygon")]
        public async Task<JsonResult> GetByCityId(int Id)
        {
            var result = await _polygonProxy.GetByCityId(Id);
            return Json(new { result });

        }

        //[HttpPost("city/{Id}/polygon")]
        //public async Task<JsonResult> CreatePolygon([FromBody]CreatePolygonModel model)
        //{

        //    XDocument doc = XDocument.Parse(model.Xml);// XDocument.Load(FILENAME);
        //    XElement root = doc.Root;
        //    XNamespace ns = root.GetDefaultNamespace();

        //    //List<XElement> simpleFields;

        //    //List<XElement> extendedDatas = doc.Descendants(ns + "Polygon").ToList();

        //    var _polygonName = "{" + ns + "}polygon";
        //    List<XElement> extendedDatas = doc.Descendants().Where(x => x.Name.ToString().ToLower().Contains($"{_polygonName}")).ToList();

        //    //List<XElement> extendedDatas = doc.Descendants().Where(x =>  String.Equals((string)x.Attribute("name"), $"{ns}polygon",
        //    //                                    StringComparison.InvariantCultureIgnoreCase)).ToList();

        //    foreach (XElement extendedData in extendedDatas)
        //    {
        //        //List<XElement> coordinates = doc.Descendants().Where(x => String.Equals((string)x.Attribute("name"), $"{ns}coordinates",
        //        //                            StringComparison.InvariantCultureIgnoreCase)).ToList();

        //        //var coordinates = extendedData.Descendants(ns + "coordinates").ToList();
        //        var _coordinatesName = "{" + ns + "}coordinates";
        //        List<XElement> coordinates = doc.Descendants().Where(x => x.Name.ToString().ToLower().Contains($"{_coordinatesName}")).ToList();


        //        var coordinatesList = coordinates[0].Value.Trim().Split('\n');

        //        var result = await _polygonProxy.Create(new CityPolygonView()
        //        {
        //            CityId = model.Id,
        //            Name = "" + DateTime.Now.Ticks
        //        });

        //    }

        //    return Json(new {  });

        //}



    }
}
