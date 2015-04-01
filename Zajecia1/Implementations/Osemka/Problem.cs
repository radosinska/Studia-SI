using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajecia1.Interfaces;

namespace Zajecia1.Implementations.Osemka {

    class Problem : IProblem{
        StanNki initialState;
        StanNki endState;

        public Problem(StanNki initialState, StanNki endState) {
            this.initialState = initialState;
            this.endState = endState;
        }
        IState IProblem.initialState() {
            return this.initialState;
        }

        public bool isTarget(IState state) {
            var tmp_state = state as StanNki;
            for (int i = 0; i < tmp_state.stan.Length; i++) {
                if (tmp_state.stan[i] != this.endState.stan[i]) return false;
            }
            return true;
        }

        public IEnumerable<IState> nextStates(IState state) {
            var state_e = state as StanNki;
            int position_0 = state_e.indexOf(0);
            const int size = 3;
            List<StanNki> next = new List<StanNki>();
            if(position_0 - 3>=0)
                next.Add(state_e.copy().swap(position_0, position_0 - 3));
            if (position_0 + size < size * size)
                next.Add(state_e.copy().swap(position_0, position_0 + 3));
            if (position_0 % size != 0)
                next.Add(state_e.copy().swap(position_0, position_0 - 1));
            if (position_0 % size != size - 1)
                next.Add(state_e.copy().swap(position_0, position_0 + 1));

            return next;
        }
    }
}
