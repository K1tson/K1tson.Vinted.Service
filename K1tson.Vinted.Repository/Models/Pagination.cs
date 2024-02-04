using System.Text.Json.Serialization;

namespace K1tson.Vinted.Repository.Models
{
    public class Pagination
    {
        [JsonPropertyName("Current_Page")]
        public double CurrentPage { get; set; }

        [JsonPropertyName("Total_Pages")]
        public double TotalPages { get; set; }

        [JsonPropertyName("Total_Entries")]
        public double TotalEntries { get; set; }

        [JsonPropertyName("Per_Page")]
        public double PerPage { get; set; }

        public double Time { get; set; }
    }
}
