using K1tson.Vinted.Repository.JsonConverters;
using System.Text.Json.Serialization;

namespace K1tson.Vinted.Repository.Models
{
    public class Item
    {

        public double Id { get; set; }

        public required string Title { get; set; }

        public required string Price { get; set; }

        [JsonPropertyName("Is_Visible")]
        [JsonConverter(typeof(BoolConverter))]
        public bool IsVisible { get; set; }

        public bool IsForSwap { get; set; }

        public required string Currency { get; set; }

        [JsonPropertyName("Brand_Title")]
        public string? BrandTitle { get; set; }

        public User? User { get; set; }

        public Photo? Photo { get; set; }

        public required string Url { get; set; }

        [JsonPropertyName("Content_Source")]
        public string? ContentSource { get; set; }

        [JsonPropertyName("Favourite_Count")]
        public int Favourite_Count { get; set; }

        [JsonPropertyName("Is_Favourite")]
        public bool IsFavourite { get; set; }

        [JsonPropertyName("Service_Fee")]
        public required string ServiceFee { get; set; }

        [JsonPropertyName("Total_Item_Price")]
        public required string TotalItemPrice { get; set; }

        public string Status { get; set; }

        public bool Promoted { get; set; }

        [JsonPropertyName("View_Count")]
        public int ViewCount { get; set; }
    }
}
