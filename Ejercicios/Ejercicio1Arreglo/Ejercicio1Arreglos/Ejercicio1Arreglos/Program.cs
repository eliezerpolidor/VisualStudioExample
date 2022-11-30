using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Arreglos
{
    class Program
    {
        //public static int[] sueldo = { 1200, 750, 820, 550, 490 };
        private static int[] sueldo = new int[5];
        static void Main(string[] args)
        {
            Program arreg = new Program();
            Console.WriteLine("**********Llenar Arreglo*****************");
            arreg.llenarArreglo();
            Console.WriteLine("******************************************************");
            Console.WriteLine("************Mostrar Arreglo***************");
            arreg.imprimir();
         }
        void llenarArreglo() 
        {
            for (int i = 0; i < sueldo.Length; i++)
            {
                Console.WriteLine($"Introduzca Sueldo: {++i} ", i--);
                string linea = Console.ReadLine();
                sueldo[i] = int.Parse(linea);
            }
        }
        void imprimir() 
        {
            Console.WriteLine("Sueldos: ");
            for (int j = 0; j < sueldo.Length; j++)
            {
                Console.WriteLine($"Sueldo{++j}: {j--} {sueldo[j]}");
            }
            Console.ReadKey();
        }
    }   
}
