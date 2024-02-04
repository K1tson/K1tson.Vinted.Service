using System.Text.Json.Serialization;

namespace K1tson.Vinted.Repository.Models
{
    public class User
    {
        public double Id { get; set; }

        public required string Login { get; set; }

        public bool Business { get; set; }

        [JsonPropertyName("Profile_Url")]
        public required string ProfileUrl { get; set; }

        public Photo? Photo { get; set; }
    }
}
