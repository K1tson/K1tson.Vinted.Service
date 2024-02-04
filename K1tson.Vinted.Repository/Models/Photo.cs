using System.Text.Json.Serialization;

namespace K1tson.Vinted.Repository.Models
{
    public class Photo
    {
        public required double Id { get; set; }

        public required double Width { get; set; }

        public required double Height { get; set; }

        public required string Url { get; set; }

        [JsonPropertyName("Dominant_Color")]
        public string? DominantColor { get; set; }

        [JsonPropertyName("Dominant_Color_Opaque")]
        public string? DominantColorOpaque { get; set; }

        public IEnumerable<Thumbnail>? Thumbnails { get; set; }
    }

    public class Thumbnail
    {
        public required string Type { get; set; }

        public required string Url { get; set; }

        public required double Width { get; set; }

        public required double Height { get; set; }
    }
}
