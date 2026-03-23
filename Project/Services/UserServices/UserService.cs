using Project.Entities;
using Project.Exceptions;

namespace Project.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly List<User> users = [];

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public User GetUserById(int userId)
        {
            return users.FirstOrDefault(user => user.Id == userId)
                   ?? throw new UserNotFoundException(userId);
        }

        public List<User> GetUsers()
        {
            return users;
        }
    }
}
