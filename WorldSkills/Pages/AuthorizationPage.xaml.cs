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
using WorldSkills.Model.Core;

namespace WorldSkills.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        Core db = new Core(); //Имя подключения
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void EntranceButton_Click(object sender, RoutedEventArgs e)
        {
            try

            {

                //считаем количество записей в таблице с заданными параметрами (логин, пароль)
                Users имяПеременной = db.context.Users.Where(
                x => x.Login == TextBoxLogin.Text && x.Password == TextBoxPassword.Text
                ).FirstOrDefault();

                if (имяПеременной == null)
                {
                    MessageBox.Show("Такой пользователь отсутствует!",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                }
                else

                {

                    switch (имяПеременной.IdRole)
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
