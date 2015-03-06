using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajecia1.Interfaces;

namespace Zajecia1.Implementations {
    class Node {
        private IState state;
        internal IState State {
            get { return state; }
            set { state = value; }
        }

        private Node parent;
        internal Node Parent {
            get { return parent; }
            set { parent = value; }
        }
        public Node(IState state, Node parent) {
            this.state = state;
            this.parent = parent;
        }
        
    }
}
