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

namespace BmiBmrCalculator.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BTBMI_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BMI());
        }

        private void BTBMR_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BMR());
        }
    }
}
