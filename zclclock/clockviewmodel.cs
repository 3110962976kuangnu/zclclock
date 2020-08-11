using GalaSoft.MvvmLight;
using zclclock.Model;

namespace zclclock.ViewModel
{
    class clockviewmodel:ViewModelBase
    {
        public clockviewmodel()
        {
            time_text = new clockmodel() {timetext="time to change" };
        }
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
