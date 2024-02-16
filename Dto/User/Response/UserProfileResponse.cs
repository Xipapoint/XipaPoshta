namespace XipaPoshta.Dto.User.Response
{
    public class UserProfileResponse
    {
        public long Id { get; set; }

        public required string Username { get; set; }

        public required string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public required string Avatar { get; set; }
    }
}
