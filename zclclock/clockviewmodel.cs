using GalaSoft.MvvmLight;
using zclclock.Model;

namespace zclclock.ViewModel
{
    class clockviewmodel:ViewModelBase
    {
        public clockviewmodel()
        {
            time_text = new clockmodel() { timetext = "time to change" };
            alarmmodel = new alarmmodel() { alarmtimeM = "11",alarmtimeH="23" };
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
        /// <summary>
        /// 闹钟界面
        /// </summary>
        private alarmmodel _alarmmodel;
        public alarmmodel alarmmodel
        {
            get { return _alarmmodel; }
            set { 
                _alarmmodel = value;
                RaisePropertyChanged(() =>alarmmodel);
            }
        }




    }
}
