using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Practic10
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





        private void TBName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (CBLanguage.SelectedIndex == 0)
            {
                Regex regex = new Regex("^[а-яА-ЯёЁ]+$");
                if (!regex.IsMatch(e.Text))
                {
                    e.Handled = true;
                }
            }

            else if (CBLanguage.SelectedIndex == 1)
            {
                Regex regex = new Regex("^[a-zA-Z]+$");
                if (!regex.IsMatch(e.Text))
                {
                    e.Handled = true;
                }
            }
        }

        private void CBLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TBName.Clear();
        }

        private string GenerateLogin(string name, DateTime birthDate)
        {
            // Русский и английский алфавиты
            string rusAlphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string engAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder loginBuilder = new StringBuilder();

            foreach (char c in name.ToUpper())
            {
                int index;

                if ((index = rusAlphabet.IndexOf(c)) != -1)
                    loginBuilder.Append(index + 1);
                else if ((index = engAlphabet.IndexOf(c)) != -1)
                    loginBuilder.Append(index + 1);
            }

            int dateSum = birthDate.ToString("ddMMyyyy")
                .ToCharArray()
                .Select(ch => int.Parse(ch.ToString()))
                .Sum();

            loginBuilder.Append(dateSum);

            return loginBuilder.ToString();
        }

        private string GeneratePassword()
        {
            const string specialChars = "-;+_=\"[-@#$%^&?**)(!]";
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";

            Random rnd = new Random();
            StringBuilder password = new StringBuilder();

            // Вставим один спецсимвол
            char specialChar = specialChars[rnd.Next(specialChars.Length)];
            password.Append(specialChar);

            // Вставим одну заглавную букву
            password.Append(upper[rnd.Next(upper.Length)]);

            // Остальное — маленькие буквы и максимум 5 цифр (не подряд)
            int digitsUsed = 0;
            while (password.Length < 10)
            {
                bool addDigit = rnd.Next(2) == 0 && digitsUsed < 5;

                if (addDigit)
                {
                    // Проверим, не стоит ли уже цифра перед этим
                    if (password.Length > 0 && char.IsDigit(password[digitsUsed ^ 1]))
                        continue;

                    password.Append(digits[rnd.Next(digits.Length)]);
                    digitsUsed++;
                }
                else
                {
                    password.Append(lower[rnd.Next(lower.Length)]);
                }
            }

            // Перемешать символы
            return new string(password.ToString().OrderBy(_ => rnd.Next()).ToArray());
        }

        private void BTLogin_Click(object sender, RoutedEventArgs e)
        {
            string name = TBName.Text.Trim();
            DateTime? birthDate = DPBirthDay.SelectedDate;

            if (string.IsNullOrEmpty(name) || birthDate == null)
            {
                MessageBox.Show("Вы не ввели имя или дату рождения.");
                return;
            }

            string login = GenerateLogin(name, birthDate.Value);
            

            TBLogin.Text = login;
            
        }

        private void BTPassword_Click(object sender, RoutedEventArgs e)
        {
            string name = TBName.Text.Trim();
            DateTime? birthDate = DPBirthDay.SelectedDate;

            if (string.IsNullOrEmpty(name) || birthDate == null)
            {
                MessageBox.Show("Пожалуйста, введите имя и дату рождения.");
                return;
            }

            string password = GeneratePassword();
            TBPassword.Text = password;
        }
    }
}
