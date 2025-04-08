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

            else if(CBLanguage.SelectedIndex == 1)
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
    }
}
