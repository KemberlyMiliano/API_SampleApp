using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APISampleApp.Models
{
    public class RandomBeer
    {

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
