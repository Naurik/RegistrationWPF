using Registration.DataAccess;
using System.Linq;
using System.Windows;

namespace RegistrationMaterialDesignWPF
{
    /// <summary>
    /// Логика взаимодействия для EnterForm.xaml
    /// </summary>
    public partial class EnterForm : Window
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        private void CheckEnter(object sender, RoutedEventArgs e)
        {
            string login = enterLogin.Text;
            string password = enterPassword.Password;

            using (var context = new RegistrationContext())
            {
                var getLogin = (from user in context.User
                                where login == user.Login
                                select user.Login).FirstOrDefault();

                var getPassword = (from user in context.User
                                   where password == user.Password
                                   select user.Password).FirstOrDefault();

                if (string.IsNullOrEmpty(getLogin))
                {
                    MessageBox.Show("Login doesn't exist or Password wrong!!! Try again");

                    enterLogin.Text = string.Empty;
                    enterPassword.Password = string.Empty;
                }
                else if (string.IsNullOrEmpty(getPassword))
                {
                    MessageBox.Show("Login doesn't exist or Password wrong!!! Try again");

                    enterLogin.Text = string.Empty;
                    enterPassword.Password = string.Empty;
                }
                else
                {
                    MessageBox.Show("Successfully!!!");

                    enterLogin.Text = string.Empty;
                    enterPassword.Password = string.Empty;
                    return;
                }
            }
        }
    }
}
