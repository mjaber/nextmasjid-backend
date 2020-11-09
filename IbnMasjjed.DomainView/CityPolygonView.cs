using System;
using System.Collections.Generic;
using System.Text;

namespace IbnMasjjed.DomainView
{
    public class CityPolygonView
    {
        public int Id { get; set; }

        public int CityId { get; set; }
        public string Name { get; set; }

        public CityLookupView City { get; set; }
    }
}
