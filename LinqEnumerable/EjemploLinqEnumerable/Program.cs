using System;
using System.Collections.Generic;
using System.Linq;

namespace EjemploLinqEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valoresNumericos = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Numeros Pares: ");

            IEnumerable<int> numerosPares = from numero in valoresNumericos where numero % 2 == 0 select numero;

            foreach(int i in numerosPares) 
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
