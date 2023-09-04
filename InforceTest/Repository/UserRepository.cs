using InforceTest.Models;

namespace InforceTest.Repository
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
        new() { Username = "admin", EmailAddress = "denys.admin@email.com", Password = "admin123", GivenName = "Denys", Surname = "Datsiv", Role = "Administrator" },
            new() { Username = "denys_standard", EmailAddress = "denys.standard@email.com", Password = "dehebu38", GivenName = "Emil", Surname = "Khalus", Role = "Standard" },

            new() { Username = "denys1_standard", EmailAddress = "denys.standard@email.com", Password = "dehebu387", GivenName = "Emil", Surname = "Khalus", Role = "Standard" },
        };
    }
}