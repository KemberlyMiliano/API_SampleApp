using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APISampleApp.Models
{
    public class Data
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameDisplay")]
        public string NameDisplay { get; set; }

        [JsonProperty("abv")]
        public string Abv { get; set; }

        [JsonProperty("styleId")]
        public int StyleId { get; set; }

        [JsonProperty("isRetired")]
        public string IsRetired { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusDisplay")]
        public string StatusDisplay { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("style")]
        public Style Style { get; set; }
    }
}
