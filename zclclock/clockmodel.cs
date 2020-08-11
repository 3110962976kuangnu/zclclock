using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using GalaSoft.MvvmLight;

namespace zclclock.Model
{
    class clockmodel:ObservableObject
    { 
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










    }
}
