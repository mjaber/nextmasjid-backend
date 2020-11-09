using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IbnMasjjed.Admin.Models.UI.Geofence
{
    public class CityGeofenceModel
    {
        public int? CityId { get; set; }
        public string Name { get; set; }
        public List<Point> Points { get; set; } = new List<Point>();
    }
}
