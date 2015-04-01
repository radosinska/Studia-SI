using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajecia1.Implementations;
using Zajecia1.Implementations.Osemka;
using Zajecia1.Searching;

namespace Zajecia1 {
    class Program {
        static void Main(string[] args) {
            int[] initial_state_tab = { 0, 6, 2, 1, 5, 7, 4, 8, 3 };
            int[] end_state_tab = { 1, 2, 3, 4, 5, 6, 7, 8, 0 };
            StanNki initial_state = new StanNki(initial_state_tab);
            StanNki end_state = new StanNki(end_state_tab);
            Problem problemOsemki = new Problem(initial_state, end_state);

            FringeFIFO fifo = new FringeFIFO();
            TreeSearchWithQueue treeSearchWithQueue = new TreeSearchWithQueue();
            Console.WriteLine("start");
            var result = treeSearchWithQueue.search(problemOsemki, fifo);
            foreach (var state in result) {
                StanNki _state = state as StanNki;
                Console.WriteLine(_state.ToString());
            }
            Console.WriteLine("end");
            Console.ReadLine();
        }
    }
}
