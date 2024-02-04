using K1tson.Vinted.Repository.Models.VerificationTypes;

namespace K1tson.Vinted.Repository.Models
{
    public class Verification
    {
        public required EmailVerificationType Email { get; set; }
        public required FacebookVerificationType Facebook { get; set; }
        public required GoogleVerificationType Google { get; set; }
        public required PhoneVerificationType Phone { get; set; }
    }
}
