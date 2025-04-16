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
using System.Windows.Threading;

namespace Practic11.Pages
{
    /// <summary>
    /// Логика взаимодействия для TimerClock.xaml
    /// </summary>
    public partial class TimerClock : Page
    {
        private DispatcherTimer dispatcherTimer;
        private int remainingSeconds;
        public TimerClock()
        {
            InitializeComponent();
            Refresh();
        }


        private void Refresh()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += Timer_Tick;
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;
            TBSelect.Text = $"{remainingSeconds} сек";

            if(remainingSeconds <= 0)
            {
                dispatcherTimer.Stop();
                TBSelect.Text = "Время вышло!";
            }

        }

        private void BT_Timer_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(TBInput.Text, out int seconds) && seconds > 0)
            {
                remainingSeconds = seconds;
                TBSelect.Text = $"{remainingSeconds} сек";
                dispatcherTimer.Start();

            }
            TBInput.Text = "";
        }

        private void TBInput_GotFocus(object sender, RoutedEventArgs e)
        {
            TBSelect.Text = "Введите время в секундах";
        }

        private void BT_Cancel_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            TBSelect.Text = "";
        }


        private void BTBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
