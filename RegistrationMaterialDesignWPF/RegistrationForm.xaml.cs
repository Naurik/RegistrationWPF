using Registration.DataAccess;
using Registration.Model;
using System.Linq;
using System.Windows;

namespace RegistrationMaterialDesignWPF
{
    /// <summary>
    /// Логика взаимодействия для RegistrationForm.xaml
    /// </summary>
    public partial class RegistrationForm : Window
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void CheckRegistration(object sender, RoutedEventArgs e)
        {
            string login = signLogin.Text;
            string password = signPassword.Password;
            string phoneNumber = signNumber.Text;

            using (var context = new RegistrationContext())
            {
                var getLogin = (from user in context.User
                                where login == user.Login
                                select user.Login).FirstOrDefault();

                if(string.IsNullOrEmpty(getLogin))
                {
                    var users = new Users
                    {
                        Login = login,
                        Password = password,
                        PhoneNumber = phoneNumber
                    };
                    context.User.Add(users);
                    context.SaveChanges();
                    MessageBox.Show("Successfull");

                    signLogin.Text = string.Empty;
                    signPassword.Password = string.Empty;
                    signNumber.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Login already exists");
                    signLogin.Text = string.Empty;
                    signPassword.Password = string.Empty;
                    signNumber.Text = string.Empty;
                    return;
                }
            }
        }
    }
}
