using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using zclclock.ViewModel;
using GalaSoft.MvvmLight;


namespace zclclock
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new clockviewmodel();
            /*showtimer = new DispatcherTimer();
            showtimer.Tick += new EventHandler(ShowCurTimer);
            showtimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            showtimer.Start();*/
        }
        bool B_alarm = false;
        string alarmTime;
       
        
        /*
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            alarmTime = new TimeSpan(Convert.ToInt32(alarmH.Text), Convert.ToInt32(alarmM.Text), 0).ToString();
            B_alarm = true;
            L1.Content = "闹钟已设置为："+alarmTime;

        */
            /**/

            /*if (B_alarm)
            {
                if (alarmTime == "")
                {
                    //MessageBox.Show("time ");
                    Window alarmwindow = new Window();
                    alarmwindow.Height = 200;
                    alarmwindow.Width = 200;
                    alarmwindow.ShowInTaskbar = false;
                    Button isok = new Button();
                    isok.Content = "闹钟到了";
                    isok.Margin = new Thickness(15);
                    alarmwindow.Content = isok;
                    alarmwindow.Show();

                    //System.Media.SystemSounds.Asterisk.Play();
                }
            }*/
            /*
        }
*/
       /* private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            B_alarm = false;
            alarmH.Text = "12";
            alarmM.Text = "0";
            L1.Content = "";
        }*/
    }
}
