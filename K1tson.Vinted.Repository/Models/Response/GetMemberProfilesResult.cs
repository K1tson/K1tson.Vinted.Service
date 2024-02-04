namespace K1tson.Vinted.Repository.Models.Response
{
    public class GetMemberProfilesResult : BasePaginationResponse
    {
        public required IEnumerable<UserProfile> Users { get; set; }
    }
}
