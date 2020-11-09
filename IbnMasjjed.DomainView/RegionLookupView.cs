using System;
using System.Collections.Generic;
using System.Text;

namespace IbnMasjjed.DomainView
{
   public class RegionLookupView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public bool IsDeleted { get; set; }

        public ICollection<CityLookupView> Cities { get; set; }
    }
}
