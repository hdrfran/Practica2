﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PagedList.Models
{
    public class Album
    {
        [JsonProperty("albumId")]
        public int AlbumId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string? Title { get; set; }
        [JsonProperty("url")]
        public string? Url { get; set; }
        [JsonProperty("thumbnailUrl")]
        public string? ThumbnailUrl { get; set; }
    }
}
