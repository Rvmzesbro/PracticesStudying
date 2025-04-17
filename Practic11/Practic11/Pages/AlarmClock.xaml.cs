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
    /// Логика взаимодействия для AlarmClock.xaml
    /// </summary>
    public partial class AlarmClock : Page
    {
        private DispatcherTimer timer;
        private DateTime AlarmTime;
        public AlarmClock()
        {
            InitializeComponent();
            GenerateTimes();
            Refresh();
        }

        private void Refresh()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= AlarmTime)
            {
                timer.Stop();
                TBSelect.Text = "Время вышло!";
            }
        }

        private void GenerateTimes()
        {
            for (int i = 0; i < 24; i++)
            {
                CBHourse.Items.Add(i.ToString("00"));
            }

            for (int i = 0; i < 60; i++)
            {
                CBMinuts.Items.Add(i.ToString("00"));
            }
        }

        private void BTBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        

        private void BT_On_Click(object sender, RoutedEventArgs e)
        {
            if(DPInput.SelectedDate.HasValue && CBHourse.SelectedItem != null && CBMinuts.SelectedItem != null)
            {
                TBSelect.Text = $"Вы поставили будильник на\n{DPInput.SelectedDate?.ToString("dd.MM.yyyy")} {CBHourse.SelectedItem}:{CBMinuts.SelectedItem}";

                int hour = int.Parse(CBHourse.SelectedItem.ToString());
                int minute = int.Parse(CBMinuts.SelectedItem.ToString());
                DateTime SelectedDate = DPInput.SelectedDate.Value.Date;

                AlarmTime = SelectedDate.AddMinutes(minute).AddHours(hour);

                if(AlarmTime <= DateTime.Now)
                {
                    AlarmTime = AlarmTime.AddDays(1);
                    TBSelect.Text = $"Вы поставили будильник на\n{AlarmTime.Date.ToString("dd.MM.yyyy")} {CBHourse.SelectedItem}:{CBMinuts.SelectedItem}";
                }

                timer.Start();
                DPInput.SelectedDate = null;
                CBHourse.SelectedItem = null;
                CBMinuts.SelectedItem = null;
            }

            else
            {
                return;
            }
        }

      

        private void BT_Off_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            TBSelect.Text = "";
            DPInput.SelectedDate = null;
            CBHourse.SelectedItem = null;
            CBMinuts.SelectedItem = null;
        }
    }
}
