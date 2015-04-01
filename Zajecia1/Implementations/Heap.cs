using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajecia1.Interfaces;

namespace Zajecia1.Implementations {
    class Heap<T, K> where K : IComparable<K>, IFringe {
        public Func<T, K> Key;                          //key to priorytet, to jest nasze pole, które przyjmuje funkcje, która przyjmuje jako arg T, i zwraca K
        private List<T> list = new List<T>();
        
        public Heap(Func<T, K> _key) {
            Key = _key;
        }

        public T Get() {
            var element = list.First();

            this.list[0] = this.list[this.list.Count - 1];
            this.list.RemoveAt(this.list.Count - 1);
            this.ShiftDown(0);                  //przesuń na swoje miejsce

            return element;
        }

        public void Add(T element) {
            this.list.Add(element);
            this.ShiftUp(this.list.Count - 1);
        }

        private void ShiftDown(int child) {
            int parent;
            do {
                parent = child;                                                                                           //dziecko na index rodzica
                if (2 * parent - 1 < list.Count && Key(list[2 * parent - 1]).CompareTo(Key(list[child]))>0)               //czy dziecko istnieje i czy jest większe od rodzica
                    child = 2 * parent - 1;                      
                if (2 * parent < list.Count && Key(list[2 * parent - 1]).CompareTo(Key(list[child]))>0)                   //tu musimy porównać nie z rodzicem, ale z tym pierwszym dzieckiem
                    child = 2 * parent;
                T tmp = list[parent];
                list[child] = tmp;                                                                                        //k staje się maks (rodzic, dziecko1, dziecko2)
            } while (parent != child);
        }

        private void ShiftUp(int child) {
            //porównujemy z rodzicem
            //jak parzyste to rpzez 2
            //jak nieparzyste to przez 2 i dodać 1
            int parent;
            do {
                if (child % 2 == 0) parent = child / 2;
                else parent = (child / 2) + 1;
                if (Key(this.list[child]).CompareTo(Key(this.list[parent])) > 0) {
                    T tmp = list[parent];
                    list[child] = tmp;
                }
            } while (child != parent);
        }
    }
}
