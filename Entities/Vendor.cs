using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace skyline
{
    public class Vendor
    {           
        
        [JsonPropertyName("Device")]
        public string? Device { get; set; }
        [JsonPropertyName("Model")]
        public string? Model { get; set; }
        [JsonPropertyName("NIC")]
        public List<Nic>? Nics { get; set; }

    }
}