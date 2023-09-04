using Microsoft.VisualStudio.TestTools.UnitTesting;
using InforceTest.Services;
using InforceTest.Models;
using System.Collections.Generic;
using System.Linq;
using InforceTest.Repository;

namespace InforceTest.Services.Tests
{
    [TestClass]
    public class UserServiceTests
    {
        [TestMethod]
        public void Get_ValidUser_ReturnsUser()
        {
            var userService = new UserService();

            var users = new List<User>
            {
                new User { Username = "user1", Password = "password1" },
                new User { Username = "user2", Password = "password2" },
            };

            UserRepository.Users = users;

            var validUserLogin = new UserLogin { UserName = "user1", Password = "password1" };

            var result = userService.Get(validUserLogin);

            Assert.IsNotNull(result);
            Assert.AreEqual("user1", result.Username);
        }

        [TestMethod]
        public void Get_InvalidUser_ReturnsNull()
        {
            
            var userService = new UserService();

           
            var users = new List<User>
            {
                new User { Username = "user1", Password = "password1" },
                new User { Username = "user2", Password = "password2" },
              
            };


            UserRepository.Users = users;

            var invalidUserLogin = new UserLogin { UserName = "invalidUser", Password = "invalidPassword" };

     
            var result = userService.Get(invalidUserLogin);

            Assert.IsNull(result);
        }
    }

}
