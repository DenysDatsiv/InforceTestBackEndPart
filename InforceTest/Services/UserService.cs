using InforceTest.Models;
using InforceTest.Repository;

namespace InforceTest.Services
{
    public class UserService:IUserService
    {
        public User Get(UserLogin userLogin)
        {
            User user = UserRepository.Users.FirstOrDefault(o => o.Username.Equals(userLogin.UserName, StringComparison.OrdinalIgnoreCase) && o.Password.Equals(userLogin.Password));
            return user;
        }
    }
}
