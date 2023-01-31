using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WorldSkills.Model;

namespace WorldSkills.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        Core db = new Core();

        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            try

            {
                Users ObjectName = new Users()
                {
                    Login = LoginBox.Text,
                    Password = PasswordBox.Text,
                    IdRole=1
                   
};

                db.context.Users.Add(ObjectName);
                db.context.SaveChanges();

                MessageBox.Show("Добавление выполнено успешно !",
                "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Information);


            }
            catch
            {
                MessageBox.Show("Критический сбор в работе приложения:", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
