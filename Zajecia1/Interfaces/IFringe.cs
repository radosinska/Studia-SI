using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajecia1.Implementations;

namespace Zajecia1.Interfaces {
    interface IFringe {
        public void dodaj(Node node);
        public Boolean czy_pusto();
        public Node pobierz();
    }
}
