using System.Windows;

namespace uipracticewin
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = FirstNameBox.Text;
            string lastName = LastNameBox.Text;
            string username = UsernameBox.Text;
            string phoneNumber = PhoneBox.Text;
            string password = PasswordBoxReg.Password;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                RegistrationError.Text = "Please fill in all required fields";
                return;
            }

            User existingUser = App.RegisteredUsers.Find(u => u.Username == username);
            if (existingUser != null)
            {
                RegistrationError.Text = "Username already exists";
                return;
            }

            User newUser = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password,
                PhoneNumber = phoneNumber
            };

            App.RegisteredUsers.Add(newUser);
            RegistrationError.Text = "Registration successful! Please login.";

            this.Close();
        }
    }
}