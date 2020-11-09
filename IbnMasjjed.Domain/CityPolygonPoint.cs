using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IbnMasjjed.Domain
{
    public class CityPolygonPoint
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CityPolygon")]
        public int PloygonId { get; set; }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public bool IsDeleted { get; set; }
        public CityPolygon CityPolygon { get; set; }
    }
}
