using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia1.Interfaces {
    interface IProblem {
        public IState stan_poczatkowy();
        public Boolean czy_cel(IState state);
        public IEnumerable<IState> nastepniki(IState state);
    }
}
