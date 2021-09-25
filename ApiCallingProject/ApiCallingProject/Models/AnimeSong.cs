using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ApiCallingProject.Models
{
    public class AnimeSong
    {
            [JsonPropertyName("anime_id")]
            public int AnimeId { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("artist")]
            public string Artist { get; set; }

            [JsonPropertyName("album")]
            public string Album { get; set; }

            [JsonPropertyName("year")]
            public int Year { get; set; }

            [JsonPropertyName("season")]
            public int Season { get; set; }

            [JsonPropertyName("duration")]
            public int Duration { get; set; }

            [JsonPropertyName("preview_url")]
            public string PreviewUrl { get; set; }

            [JsonPropertyName("open_spotify_url")]
            public string OpenSpotifyUrl { get; set; }

            [JsonPropertyName("local_spotify_url")]
            public string LocalSpotifyUrl { get; set; }

            [JsonPropertyName("type")]
            public int Type { get; set; }

            [JsonPropertyName("id")]
            public int Id { get; set; }
    }
}
