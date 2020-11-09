using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IbnMasjjed.Api.Models
{
    
        public class AppSettings
        {
            public ConnectionStrings ConnectionStrings { get; set; }
            public Security Security { get; set; }
        }

        public class ConnectionStrings
        {
            public string Context { get; set; }
        }


        public class Security
        {
            public string ApiKey { get; set; }
        }
   
}
