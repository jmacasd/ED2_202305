using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class ArbolGeneral
    {
        private readonly Nodo raiz;
        public Nodo Raiz { get { return raiz; } }
        public ArbolGeneral(string dato)
        {
            raiz = new Nodo(dato);
        }
    }
}
