namespace XipaPoshta.Dto.User.Request
{
    public class RegisterRequest
    {
        public required string Email { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required long PhoneNumber { get; set; }    
        public required DateTime BirthDate { get; set; }
    }
}
