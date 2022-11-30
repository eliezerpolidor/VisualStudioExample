using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArbolGenerico
{
    class Program
    {
        static void Main(string[] args)
        {
            CArbol arbol = new CArbol();

            CNodo raiz = arbol.Insertar("A", null);

            arbol.Insertar("B", raiz);
            arbol.Insertar("C", raiz);

           // arbol.TransversaPreO(raiz);

            CNodo n = arbol.Insertar("D", raiz);
            arbol.Insertar("H", n);

            n = arbol.Insertar("E", raiz);
            arbol.Insertar("i", n);
            n = arbol.Insertar("J", n);
            arbol.Insertar("P", n);
            arbol.Insertar("q", n);

            //arbol.TransversaPreO(raiz);

            n = arbol.Insertar("F", raiz);
            arbol.Insertar("K", n);
            arbol.Insertar("L", n);
            arbol.Insertar("M",n);

            n = arbol.Insertar("G", raiz);
            arbol.Insertar("N", n);

            arbol.TransversaPreO(raiz);
            Console.WriteLine("----------------------");

            //arbol.TransversaPostO(raiz);
            //Console.WriteLine("-----------------------");

            CNodo encontrado = arbol.Buscar("z", raiz);
            if (encontrado != null)
                Console.WriteLine("Encontro a: " + encontrado.Dato);
            else
                Console.WriteLine("No lo Encontre....");
            
            Console.WriteLine("----------------------");
            string donde = " ";
            string que = " ";
            Console.WriteLine("En donde deseas Insertar");
            donde = Console.ReadLine();
            Console.WriteLine("Que deseas insertar");
            que = Console.ReadLine();

            encontrado = arbol.Buscar(donde, raiz);
            arbol.Insertar(que, encontrado);
            arbol.TransversaPreO(raiz);

            Console.ReadKey();
        }
    }
}
