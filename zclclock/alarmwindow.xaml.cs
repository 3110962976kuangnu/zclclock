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
using System.Windows.Shapes;

namespace zclclock
{
    /// <summary>
    /// alarmwindow.xaml 的交互逻辑
    /// </summary>
    public partial class alarmwindow : Window
    {
        public alarmwindow(string msg)
        {
            InitializeComponent();

            text.Text = msg;
             MediaPlayer player = new MediaPlayer();
             //player.Open(new Uri("C:/Users/123/Documents/wpflearn/zclclock/zclclock/zclclock/Resources/alarm.wav"));
             player.Open(new Uri("./Resources/alarm.wav", UriKind.Relative));
             player.Volume = 0.9;
             player.Play();
            this.Closing += (sender, e) => { player.Stop(); };
        }

        private void ok_click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void no_clcik(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
