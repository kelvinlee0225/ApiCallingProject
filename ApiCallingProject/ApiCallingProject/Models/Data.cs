using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ApiCallingProject.Models
{
    public class Data
    {
        [JsonPropertyName("current_page")]
        public int CurrentPage { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("documents")]
        public List<AnimeSong> AnimeSongs { get; set; }

        [JsonPropertyName("last_page")]
        public int LastPage { get; set; }
    }
}
