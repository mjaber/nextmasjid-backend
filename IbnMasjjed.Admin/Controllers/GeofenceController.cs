using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IbnMasjjed.Admin.Models.UI.Geofence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SharpKml.Dom;
using SharpKml.Engine;

namespace IbnMasjjed.Admin.Controllers
{
    [Authorize]
    public class GeofenceController : Controller
    {

        public GeofenceController()
        {

        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Import()
        {
            return View();
        }


        [HttpPost]
        public JsonResult Import([FromBody] ImportModel model)
        {
            try
            {
                var _geofence = KmlToGeofence(model.Kml);
                return Json(new { isSuccess = true, result = _geofence });
            }
            catch (Exception ex)
            {

                return Json(new { isSuccess = false, message = ex.Message });
            }

            //return View();
        }

        private List<CityGeofenceModel> KmlToGeofence(string kmlString)
        {
            var result = new List<CityGeofenceModel>();

            byte[] byteArray = Encoding.ASCII.GetBytes(kmlString);
            MemoryStream stream = new MemoryStream(byteArray);

            var doc = ((Document)((Kml)KmlFile.Load(stream).Root).Feature);

           

            foreach (var docFeature in doc.Features.ToArray())
            {
                var folder = (Folder)docFeature;
                foreach (var f in folder.Features)
                {
                    var city = new CityGeofenceModel();

                    var placeMarker = (Placemark)f;

                    city.Name = placeMarker.Name.Trim();

                    if (placeMarker.Geometry is Polygon)
                    {
                        var polygon = (Polygon)placeMarker.Geometry;
                        var boundary = polygon.OuterBoundary;
                        var ring = boundary.LinearRing;

                        foreach (var coor in ring.Coordinates)
                        {
                            city.Points.Add(new Models.Point() { Latitude = coor.Latitude, Longitude = coor.Longitude });
                        }

                        result.Add(city);
                    }
                    else
                    {
                        foreach (var g in ((MultipleGeometry)placeMarker.Geometry).Geometry)
                        {

                            var polygon = (Polygon)g;
                            var boundary = polygon.OuterBoundary;
                            var ring = boundary.LinearRing;

                            foreach (var coor in ring.Coordinates)
                            {
                                city.Points.Add(new Models.Point() { Latitude = coor.Latitude, Longitude = coor.Longitude });
                            }

                            result.Add(city);
                        }
                    }

                }
            }

            return result;

        }

    }
}
