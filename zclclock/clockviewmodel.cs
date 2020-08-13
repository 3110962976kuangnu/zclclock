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
        



    }
}
