using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IbnMasjjed.Domain
{
    public class CityLookup
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Region")]
        public int RegionId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public RegionLookup Region { get; set; }
    }
}
