using Microsoft.Win32;
using Practic9.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;

namespace Practic9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Education> Educations { get; set; } = new List<Education>();
        public List<CorrectInputUser> correctInputUsers { get; set; } = new List<CorrectInputUser>();
        public byte[] Avatar { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Avatar = File.ReadAllBytes("C:\\Users\\web2\\Desktop\\Новая папка\\PracticesStudying\\Practic9\\Practic9\\Resources\\Police.jpg");

            DgEduaction.ItemsSource = Educations;
            App.MainWindow = this;
            DataContext = this;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.MainWindow.Close();
        }

        private void ChoosePhoto_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = ".png, .jpg, .jpeg | *.png; *.jpg; *.jpeg" };
            if(dialog.ShowDialog().GetValueOrDefault())
            {
                var SelectedPhoto = dialog.FileName;
                Avatar = File.ReadAllBytes(SelectedPhoto);
            }
            DataContext = null;
            DataContext = this;

        }

        private void Rate_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(SalaryScale.Text) || string.IsNullOrWhiteSpace(ExtraCharge.Text) || string.IsNullOrWhiteSpace(Rate.Text))
            {
                Salary.Text = "";
            }
            else
            {
                double Result = double.Parse(Rate.Text) * double.Parse(SalaryScale.Text) + double.Parse(ExtraCharge.Text);
                Salary.Text = Result.ToString();
            }
            
            
        }

        private void SalaryScale_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Rate.Text) || string.IsNullOrWhiteSpace(ExtraCharge.Text) || string.IsNullOrWhiteSpace(SalaryScale.Text))
            {
                Salary.Text = "";
            }
            else
            {
                double Result = double.Parse(Rate.Text) * double.Parse(SalaryScale.Text) + double.Parse(ExtraCharge.Text);
                Salary.Text = Result.ToString();
            }
        }

        private void ExtraCharge_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SalaryScale.Text) || string.IsNullOrWhiteSpace(Rate.Text) || string.IsNullOrWhiteSpace(ExtraCharge.Text))
            {
                Salary.Text = "";
            }
            else
            {
                double Result = double.Parse(Rate.Text) * double.Parse(SalaryScale.Text) + double.Parse(ExtraCharge.Text);
                Salary.Text = Result.ToString();
            }
        }

        private void Rate_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !double.TryParse(e.Text, out _);
        }

        private void SalaryScale_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !double.TryParse(e.Text, out _);
        }

        private void ExtraCharge_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !double.TryParse(e.Text, out _);
        }
    }
}
