using System;
using System.Collections.Generic;
using System.Text;

namespace IbnMasjjed.DomainView
{
    public class CityPolygonPointView
    {
        public int Id { get; set; }

        public int PloygonId { get; set; }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }


        public CityPolygonView CityPolygon { get; set; }
    }
}
