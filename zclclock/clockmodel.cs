using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace zclclock.Model
{
    class clockmodel:ObservableObject
    { 
        /// <summary>
        /// 时钟model
        /// </summary>
        public clockmodel()
        {
            this.timetext = DateTime.Now.ToString();
            showtimer = new DispatcherTimer();
            showtimer.Tick += new EventHandler(uptime);
            showtimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            showtimer.Start();
        }
        private string _timetext;

       

        public string timetext
        {
            get { return _timetext; }
            set {
                _timetext = value;
                RaisePropertyChanged(() => timetext);
            }
        }
        private DispatcherTimer showtimer;
        public void uptime(object sender, EventArgs e)
        {
            timetext= DateTime.Now.ToString("HH:mm:ss");
        }
        public ICommand Buttoncommand
        {
            get
            {
                return new RelayCommand(() => MessageBox.Show(timetext));
            }
        }
    }
    /// <summary>
    /// 闹钟model
    /// </summary>
    class alarmmodel : ObservableObject
    {
        private string _alarmtimeH;

        public string alarmtimeH
        {
            get{return _alarmtimeH;}
            set
            {
                _alarmtimeH = value;
                RaisePropertyChanged(() => alarmtimeH);
            }
        }
        private string _alarmtimeM;

        public string alarmtimeM
        {
            get { return _alarmtimeM; }
            set { 
                _alarmtimeM = value;
                RaisePropertyChanged(()=>alarmtimeM);
            }
        }
        public ICommand Setalarm
        {
            get
            {
                return new RelayCommand(()=> {
                    alarmtimeH = "10";
                    alarmtimeM = "10";
                });
            }
        }

        public ICommand Removealarm
        {
            get
            {
                return new RelayCommand(() =>
                {
                    alarmtimeH = "11";
                    alarmtimeM = "11";
                });
            }
        }
    }
}
