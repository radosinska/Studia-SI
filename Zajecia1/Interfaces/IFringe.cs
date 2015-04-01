using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajecia1.Implementations;

namespace Zajecia1.Interfaces {
    interface IFringe {
        void add(Node node);
        Boolean isEmpty();
        Node getFirst();
    }
}
