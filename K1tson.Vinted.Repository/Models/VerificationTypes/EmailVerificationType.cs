namespace K1tson.Vinted.Repository.Models.VerificationTypes
{
    public class EmailVerificationType : IVerificationType
    {
        public bool Valid { get; set; }
        public bool Available { get; set; }
    }
}
