using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IbnMasjjed.DomainView.Models
{
    public class AppSettings
    {
        public ApiConfiguration ApiConfiguration { get; set; }
        public GoogleMapConfiguration GoogleMapConfiguration { get; set; }
    }

    public class ApiConfiguration
    {
        public string BaseUrl { get; set; }
        public string Key { get; set; }
    }

    public class GoogleMapConfiguration
    {
        public string key { get; set; }
    }

}
