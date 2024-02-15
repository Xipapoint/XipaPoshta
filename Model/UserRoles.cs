namespace Xipa_Poshta.Model
{
    public class UserRoles
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int RoleId { get; set; }

        public required User User { get; set; }

        public required Role Role { get; set; }
    }
}
