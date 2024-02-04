using System.Text.Json.Serialization;

namespace K1tson.Vinted.Repository.Models
{
    public class PayInMethods
    {
        public double Id { get; set; }

        public string Code { get; set; }

        [JsonPropertyName("Requires_Credit_Card")]
        public bool RequiresCreditCard { get; set; }

        [JsonPropertyName("Event_Tracking_Code")]
        public required string EventTrackingCode { get; set; }

        public required string Icon { get; set; }

        public bool Enabled { get; set; }

        [JsonPropertyName("Translated_Name")]
        public required string TranslatedName { get; set; }

        public required string Note { get; set; }

        [JsonPropertyName("Method_Change_Possible")]
        public bool MethodChangePossible { get; set; }
    }
}
