using InforceTest.Models;

namespace InforceTest.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
