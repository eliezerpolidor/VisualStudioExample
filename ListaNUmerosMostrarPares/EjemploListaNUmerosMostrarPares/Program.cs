/****************************************************************************************************************
 * Dado una lista de numero del 1 - 10, mostrar por pantalla solos los pares
 *****************************************************************************************************************/

using System;
using System.Collections.Generic;

namespace EjemploListaNUmerosMostrarPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valoresNumericos = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Números Pares: ");

            List<int> numerosPares = new List<int>();

            foreach (int i in valoresNumericos)
            {
                if (i % 2 == 0)
                {
                    numerosPares.Add(i);
                }
            }

            foreach (int i in numerosPares)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
