using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IbnMasjjed.Domain
{
    public class RegionLookup
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<CityLookup> Cities { get; set; }
    }
}
