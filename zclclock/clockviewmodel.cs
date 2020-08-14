using GalaSoft.MvvmLight;
using zclclock.Model;

namespace zclclock.ViewModel
{
    class clockviewmodel:ViewModelBase
    {
        public clockviewmodel()
        {
            time_text = new clockmodel() {
                timetext = "",
                alarmtimeM = "11",
                alarmtimeH = "23",
                alarmstatus ="闹钟未设置"
            };
            timer = new countdown()
            {
                ctime = "",
                ctimeH = 0,
                ctimeM = 10,
                ctimeS=00
            };
            
        }
        /// <summary>
        /// 时钟界面
        /// </summary>
        private clockmodel _clockmodel;
        public clockmodel time_text
        {
            get { return _clockmodel; }
            set { 
                _clockmodel = value;
                RaisePropertyChanged(() => time_text);
            }
        }
        private countdown _timer;

        public countdown timer
        {
            get { return _timer; }
            set {
                _timer = value; 
                RaisePropertyChanged(() => timer); 
            }
        }





    }
}
