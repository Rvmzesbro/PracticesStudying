using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Логика взаимодействия для BMI.xaml
    /// </summary>
    public partial class BMI : Page
    {
        public BMI()
        {
            InitializeComponent();
            BTMale.Checked += GenderButton_Checked;
            BTFemale.Checked += GenderButton_Checked;
        }

        //private void BTCalculate_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void BTCancel_Click(object sender, RoutedEventArgs e)
        //{
        //    TBGrowth.Clear();
        //    TBWeight.Clear();
        //}

        private void GenderButton_Checked(object sender, RoutedEventArgs e)
        {
            var button = (ToggleButton)sender;

            if (button == BTMale)
            {
                BTMale.BorderBrush = Brushes.Blue;
                BTMale.BorderThickness = new Thickness(2);
                BTFemale.IsChecked = false;
                BTFemale.BorderBrush = Brushes.Transparent;
            }
            else if (button == BTFemale)
            {
                BTFemale.BorderBrush = Brushes.Blue;
                BTFemale.BorderThickness = new Thickness(2);
                BTMale.IsChecked = false;
                BTMale.BorderBrush = Brushes.Transparent;
            }
        }

        private void BTCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (BTFemale.IsChecked == true || BTMale.IsChecked == true)
            {

                if (!double.TryParse(TBGrowth.Text, out double height) ||
                    !double.TryParse(TBWeight.Text, out double weight))
                {
                    MessageBox.Show("Пожалуйста, введите корректные значения роста и веса.", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Конвертируем рост из см в метры
                height = height / 100;

                // Рассчитываем BMI
                double bmi = weight / (height * height);
                BMI_Value.Text = bmi.ToString("0.0");

                // Устанавливаем значение на слайдере
                BMI_Slider.Value = bmi;

                // Определяем категорию и устанавливаем соответствующее изображение
                if (bmi < 18.5)
                {
                    BMI_Category.Text = "Недостаточный вес";
                    var bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri("pack://application:,,,/Resources/bmi-underweight-icon.png");
                    bitmap.EndInit();
                    BMI_Image.Source = bitmap;
                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    BMI_Category.Text = "Здоровый вес";
                    var bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri("pack://application:,,,/Resources/bmi-healthy-icon.png");
                    bitmap.EndInit();
                    BMI_Image.Source = bitmap;
                }
                else if (bmi > 24.9 && bmi <= 29.9)
                {
                    BMI_Category.Text = "Избыточный вес";
                    var bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri("pack://application:,,,/Resources/bmi-overweight-icon.png");
                    bitmap.EndInit();
                    BMI_Image.Source = bitmap;
                }
                else if (bmi > 29.9)
                {
                    BMI_Category.Text = "Ожирение";
                    var bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri("pack://application:,,,/Resources/bmi-obese-icon.png");
                    bitmap.EndInit();
                    BMI_Image.Source = bitmap;
                }
            }
        }

        private void BTCancel_Click(object sender, RoutedEventArgs e)
        {
            // Сброс значений
            TBGrowth.Text = "";
            TBWeight.Text = "";
            BMI_Value.Text = "-";
            BMI_Slider.Value = 10;
            BMI_Category.Text = "Введите данные";
            BMI_Image.Source = new System.Windows.Media.Imaging.BitmapImage(
                new Uri("pack://application:,,,/Resources/normal.png"));

            // Сброс выбора пола
            BTMale.IsChecked = true;
            BTFemale.IsChecked = false;
        }
    }
}

