using Xipa_Poshta.Model;

namespace XipaPoshta.Repository
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
        User GetUserById(int id);

        bool login();
    }
}
