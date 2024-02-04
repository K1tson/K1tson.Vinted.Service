using System.Text.Json.Serialization;

namespace K1tson.Vinted.Repository.Models.VerificationTypes
{
    public class FacebookVerificationType : IVerificationType
    {
        public bool Valid { get; set; }

        public bool Available { get; set; }

        [JsonPropertyName("Verified_At")]
        public DateTimeOffset? VerifiedAt { get; set; }
    }
}
