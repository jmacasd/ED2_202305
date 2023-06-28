using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolGeneral arbolGeneral = new ArbolGeneral("A");

            Nodo nodoB = arbolGeneral.InsertarNodo("B", arbolGeneral.Raiz);
            Nodo nodoD = arbolGeneral.InsertarNodo("D", nodoB);
            Nodo nodoI = arbolGeneral.InsertarNodo("I", nodoD);
            Nodo nodoE = arbolGeneral.InsertarNodo("E", nodoB);
            Nodo nodoF = arbolGeneral.InsertarNodo("F", nodoB);
            Nodo nodoJ = arbolGeneral.InsertarNodo("J", nodoF);
            Nodo nodoK = arbolGeneral.InsertarNodo("K", nodoF);
            Nodo nodoC = arbolGeneral.InsertarNodo("C", arbolGeneral.Raiz);
            Nodo nodoG = arbolGeneral.InsertarNodo("G", nodoC);
            Nodo nodoH = arbolGeneral.InsertarNodo("H", nodoC);
            Nodo nodoL = arbolGeneral.InsertarNodo("L", nodoH);

            string arbol = arbolGeneral.ObtenerArbol();

            string[] renglones = arbol.Split('\n');

            foreach (string renglon in renglones)
            {
                int contarGuiones = renglon.Count(caracter => caracter.ToString() == "-") + 2;
                
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), contarGuiones.ToString());
                
                Console.WriteLine(renglon);
                
                Console.ResetColor();
            }

            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadLine();
        }
    }
}
