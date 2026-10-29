using System.Collections.Generic;
using System.Windows;

namespace uipracticewin
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static List<User> RegisteredUsers { get; set; } = new List<User>();

        public App()
        {
            // Initialize with a default user for testing
            RegisteredUsers.Add(new User
            {
                FirstName = "John",
                LastName = "Doe",
                Username = "john",
                Password = "password123",
                PhoneNumber = "1234567890"
            });
        }
    }
}
