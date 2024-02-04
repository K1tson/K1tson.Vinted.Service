using System.Text.Json.Serialization;

namespace K1tson.Vinted.Repository.Models
{
    public class UserProfile
    {
        public double Id { get; set; }

        [JsonPropertyName("Anon_Id")]
        public Guid AnonId { get; set; }

        public string Login { get; set; }

        /// <summary>
        /// M = Male, F = Female, O = Other & empty for not set
        /// </summary>
        public required string Gender { get; set; }

        /// <summary>
        /// How many items the user has listed
        /// </summary>
        [JsonPropertyName("Item_Count")]
        public double ItemCount { get; set; }

        [JsonPropertyName("Msg_Template_Count")]
        public double MsgTemplateCount { get; set; }

        /// <summary>
        /// Succesful sales
        /// </summary>
        [JsonPropertyName("Given_Item_Count")]
        public double GivenItemCount { get; set; }

        /// <summary>
        /// Succesful purchases
        /// </summary>
        [JsonPropertyName("Taken_Item_Count")]
        public double TakenItemCount { get; set; }

        [JsonPropertyName("Last_Loged_On_Ts")]
        public DateTimeOffset LastLogedOn { get; set; }

        [JsonPropertyName("Country_Code")]
        public required string CountryCode { get; set; }

        [JsonPropertyName("Country_Iso_Code")]
        public required string CountryIsoCode { get; set; }

        [JsonPropertyName("Country_Title")]
        public required string CountryTitle { get; set; }

        public bool Moderator { get; set; }

        [JsonPropertyName("Is_Catalog_Moderator")]
        public bool IsCatalogModerator { get; set; }

        /// <summary>
        /// How many brands the current user is following
        /// </summary>
        [JsonPropertyName("Following_Brands_Count")]
        public double FollowingBrandsCount { get; set; }

        [JsonPropertyName("Positive_Feedback_Count")]
        public double PositiveFeedbackCount { get; set; }

        [JsonPropertyName("Neutral_Feedback_Count")]
        public double NeutralFeedbackCount { get; set; }

        [JsonPropertyName("Negative_Feedback_Count")]
        public double NegativeFeedbackCount { get; set; }

        /// <summary>
        /// Total amount of feedback
        /// </summary>
        [JsonPropertyName("Feedback_Count")]
        public double FeedbackCount { get; set; }

        [JsonPropertyName("Is_Catalog_Role_Marketing_Photos")]
        public bool IsCatalogRoleMarketingPhotos { get; set; }

        [JsonPropertyName("Hide_Feedback")]
        public bool HideFeedback { get; set; }

        [JsonPropertyName("Business")]
        public bool IsBusinessAccount { get; set; }

        [JsonPropertyName("Total_Items_Count")]
        public double TotalItemsCount { get; set; }

        public string? About { get; set; }

        public required string Path { get; set; }

        public string? City { get; set; }

        [JsonPropertyName("Updated_On")]
        public double ProfileUpdatedOn { get; set; }

        public Photo Photo { get; set; }

        /// <summary>
        /// No idea??
        /// </summary>
        [JsonPropertyName("Is_Hated")]
        public bool IsHated { get; set; }

        /// <summary>
        /// No idea??
        /// </summary>
        [JsonPropertyName("Hates_You")]
        public bool HatesYou { get; set; }

        [JsonPropertyName("Is_Favourite")]
        public bool IsFavourite { get; set; }

        [JsonPropertyName("Profile_Url")]
        public required string ProfileUrl { get; set; }

        [JsonPropertyName("Share_Profile_Url")]
        public required string ShareProfileUrl { get; set; }

        /// <summary>
        /// Not Used or Hidden
        /// </summary>
        [JsonPropertyName("Facebook_User_Id")]
        public string? FacebookUserId { get; set; }

        [JsonPropertyName("Is_Online")]
        public bool IsOnline { get; set; }

        [JsonPropertyName("Can_View_Profile")]
        public bool CanViewProfile { get; set; }

        [JsonPropertyName("Country_Title_Local")]
        public string? CountryTitleLocal { get; set; }

        [JsonPropertyName("Accepted_Pay_In_Methods")]
        public required IEnumerable<PayInMethods> AcceptedPayInMethods { get; set; }

        /// <summary>
        /// Methods of verification the user has enabled
        /// </summary>
        public required Verification Verification { get; set; }
    }
}
