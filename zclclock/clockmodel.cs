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
        public static bool isalarmok=false;
        private string alarmtime = new TimeSpan(0,0,0).ToString();
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
            if (isalarmok)
            {
                if (timetext == alarmtime)
                {
                    //应是用一个自定义窗口
                    MessageBox.Show("it is time to go!");
                }
            }
        }
        public ICommand Buttoncommand
        {
            get
            {
                return new RelayCommand(() => {
                    alarmwindow alarmwindow = new alarmwindow();
                    bool? resualt=alarmwindow.ShowDialog();
                    if (resualt == true)
                    {
                        MessageBox.Show("is ok");
                    }

                    
                });
            }
        }
   
        private string _alarmtimeH;

        public string alarmtimeH
        {
            get{return _alarmtimeH;}
            set
            {
                int a=1;
                if (int.TryParse(value,out a)&&Convert.ToInt32(value)<25  &&  Convert.ToInt32(value)>0)
                {
                    _alarmtimeH = value;
                    
                }
                else
                {
                    MessageBox.Show("请输入正确的小时数字");
                }
                RaisePropertyChanged(() => alarmtimeH);
            }
        }
        private string _alarmtimeM;

        public string alarmtimeM
        {
            get { return _alarmtimeM; }
            set {
                int a = 1;
                if (int.TryParse(value, out a) && Convert.ToInt32(value) < 25 && Convert.ToInt32(value) > 0)
                {
                    _alarmtimeM = value;

                }
                else
                {
                    MessageBox.Show("请输入正确的分钟数字");
                }
                RaisePropertyChanged(() => alarmtimeH);
            }
        }
        private string _alarmstatus;

        public string alarmstatus
        {
            get { return _alarmstatus; }
            set { _alarmstatus = value; RaisePropertyChanged(() => alarmstatus); }
        }

        public ICommand Setalarm
        {
            get
            {
                return new RelayCommand(()=> {
                    isalarmok = true;
                    alarmtime = new TimeSpan(Convert.ToInt32(alarmtimeH), Convert.ToInt32(alarmtimeM), 0).ToString();
                    alarmstatus = "闹钟时间已设置为：" + alarmtime;
                });
            }
        }

        public ICommand Removealarm
        {
            get
            {
                return new RelayCommand(() =>
                {
                    isalarmok = false;
                    alarmstatus = "闹钟未设置";
                    
                });
            }
        }
    }
}
