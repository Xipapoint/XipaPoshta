namespace XipaPoshta.Dto.User.Request
{
    public class LoginRequest
    {
        public string? Email {get; set;}

        public long? PhoneNumber { get; set;}

        public required string Password { get; set;}
    }
}
