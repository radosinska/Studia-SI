using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajecia1.Interfaces;
using Zajecia1.Implementations;

namespace Zajecia1.Searching {
    class Searching {
        static IEnumerable<IState> szukaj(IProblem problem, IFringe fringe) {
            while (!fringe.czy_pusto()) {
                Node node = fringe.pobierz();
                if (problem.czy_cel(node.State))
                    return getParentList(node);
                
                IEnumerable<IState> nastepniki = problem.nastepniki(node.State);
                foreach(IState state in nastepniki) {
                    if(sprawdz(state, node)) 
                        fringe.dodaj(new Node(state, node));
                }
            }
            return null;
        }

        static List<IState> getParentList(Node node) {
            List<IState> lista = new List<IState>();
            while (node.Parent != null) {
                lista.Add(node.State);
                node = node.Parent;
            }
            return lista;
        }

        static Boolean sprawdz(IState state, Node node) {
            if (node.State == state)
                return false;
            if (node.Parent == null) 
                return true;
            else 
                return sprawdz(state, node.Parent);            
        }

    }
}
