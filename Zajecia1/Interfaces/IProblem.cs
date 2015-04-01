using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia1.Interfaces {
    interface IProblem {
        IState initialState();
        Boolean isTarget(IState state);
        IEnumerable<IState> nextStates(IState state);
    }
}
