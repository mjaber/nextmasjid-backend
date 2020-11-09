using System;
using System.Collections.Generic;
using System.Text;

namespace IbnMasjjed.DomainView
{
    public class CityLookupView
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public string Name { get; set; }
        //public bool IsDeleted { get; set; }
        public RegionLookupView Region { get; set; }

    }
}
