using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajecia1.Interfaces;

namespace Zajecia1.Implementations.Osemka {
    class StanNki : IState {
        public int[] stan;

        public StanNki() {
            this.stan = new int[9];
        }

        public StanNki(int[] stan) {
            this.stan = stan;
        }

        public StanNki(StanNki stanNki) {
            this.stan = new int[stanNki.stan.Length];
            for(int i = 0; i<stanNki.stan.Length; i++)
                this.stan[i] = stanNki.stan[i];
        }

        public IState getState() {
            return this;
        }

        public StanNki copy() {
            return new StanNki(this);
        }

        public int indexOf(int stan) {
            for (int i = 0; i < this.stan.Length; i++)
                if (this.stan[i] == stan) return i;
            return -1;
        }

        public StanNki swap(int index1, int index2) {
            StanNki _state = new StanNki();
            for (int i = 0; i < this.stan.Length; i++) {
                _state.stan[i] = this.stan[i];
            }
            _state.stan[index1] = this.stan[index2];
            _state.stan[index2] = this.stan[index1];
            return _state;
        }

        override public String ToString() {
            String s = "";
            for (int i = 0; i < this.stan.Length; i++)
                s += this.stan[i];
            return s;
        }
    }
}
