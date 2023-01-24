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

namespace WorldSkills.Pages
{
    /// <summary>
    /// Логика взаимодействия для TeacherPage.xaml
    /// </summary>
    public partial class TeacherPage : Page
    {
        public TeacherPage()
        {
            InitializeComponent();
        }

        private void ListOfStudentButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ListOfStudentsPage());
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddingAStudentPage());
        }

        private void AddMarkButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddMarkPage());
        }
    }
}
