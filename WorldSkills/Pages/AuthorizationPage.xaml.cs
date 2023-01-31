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
using WorldSkills.ViewModel;

namespace WorldSkills.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        Core db = new Core(); //Имя подключения
        UsersViewModel obj = new UsersViewModel();
        public AuthorizationPage()
        {
            InitializeComponent();
            
        }

        private void EntranceButton_Click(object sender, RoutedEventArgs e)
        {
            try

            {
                bool trueAuth = obj.Auth(TextBoxLogin.Text, TextBoxPassword.Text) ;

                if (trueAuth == false)
                {
                    MessageBox.Show("Такой пользователь отсутствует!",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                }
                else

                {
                    int role = obj.DefiningTheRole(TextBoxLogin.Text, TextBoxPassword.Text);
                    if (role != 0)
                    {
                        switch (role)
                        {
                            case 1:
                                this.NavigationService.Navigate(new StudentPage());

                                break;
                            case 2:
                                this.NavigationService.Navigate(new TeacherPage());

                                break;

                        }
                    }
                    }



                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критический сбор в работе приложения:" + ex.Message.ToString(),
                "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
            }


        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegistrationPage());
        }
    }
}
