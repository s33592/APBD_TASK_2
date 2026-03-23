using Project.Entities;

namespace Project.Services.UserServices
{
    public interface IUserService
    {
        public void AddUser(User user);

        public User GetUserById(int id);

        public List<User> GetUsers();

    }
}
