using System.Windows;

namespace RegistrationMaterialDesignWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sign_Click(object sender, RoutedEventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            EnterForm enter = new EnterForm();
            enter.Show();
        }
    }
}
