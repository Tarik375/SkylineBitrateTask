using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace skyline
{
    public class Nic
    {   
       
        [JsonPropertyName("Description")]
        public string? Description { get; set; }
        [JsonPropertyName("MAC")]
        public string? Mac { get; set; }
        [JsonPropertyName("Timestamp")]
        public DateTime Timestamp { get; set; }
        [JsonPropertyName("Rx")]
        [JsonConverter(typeof(StringToLong))]
        public long Rx { get; set; }
        [JsonPropertyName("Tx")]
        [JsonConverter(typeof(StringToLong))]
        public long Tx { get; set; }


        
    }
}