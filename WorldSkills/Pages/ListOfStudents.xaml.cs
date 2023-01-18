﻿using System;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace WorldSkills.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListOfStudents.xaml
    /// </summary>
    public partial class ListOfStudents : Page
    {
        public ListOfStudents()
        {
            InitializeComponent();
        }

        private void ReportOutput_Click(object sender, RoutedEventArgs e)
        {
            var aplication = new Excel.Application();
            aplication.Visible = true;
        }
    }
}
