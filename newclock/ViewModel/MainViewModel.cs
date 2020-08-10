using GalaSoft.MvvmLight;
using newclock.Model;
using System.Runtime.InteropServices;

namespace newclock.ViewModel
{
   
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            wel = new Model1(){ttt="time" };
        }
        private Model1 _wel;

        public Model1 wel
        {
            get { return _wel; }
            set {
                _wel = value;
                RaisePropertyChanged(() => wel);
            }
        }


    }
}