using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apteka.Models
{
    internal class University
    {
        public string Country { get; set; }
        
        public IList<string> Domains { get; set; }
        
        public string Name { get; set; }
        
        [JsonProperty("state-province")]
        public string StateProvince { get; set; }
        
        [JsonProperty("web_pages")]
        public string[] WebPages { get; set; }

        [JsonProperty("alpha_two_code")]
        public string AlphaTwoCode { get; set; }
    }
}
