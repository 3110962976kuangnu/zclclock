using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;


namespace newclock.Model
{
    public class Model1 :ObservableObject
    {
        private String _ttt;

        public String ttt
        {
            get { return _ttt; }
            set {
                _ttt = value;
                RaisePropertyChanged(() => ttt);
            }
        }

    }
}
