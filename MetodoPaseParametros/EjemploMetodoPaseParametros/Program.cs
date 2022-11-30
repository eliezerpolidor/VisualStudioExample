using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploMetodoPaseParametros
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var (val1, val2) = CapturarValores();
            Console.WriteLine($"La Suma es: {SumaNumeros(val1, val2)}");
            Console.WriteLine($"La Resta es: {RestaNumeros(val1, val2)}");
            Console.WriteLine($"La Multiplicación es: {MultiplicacionNumeros(val1, val2)}");
            Console.WriteLine($"La División es: {DivisionNumeros(val1, val2)}");
            Console.ReadKey();
        }

        private static int MultiplicacionNumeros(int val1, int val2) => val1 * val2;

        private static int RestaNumeros(int val1, int val2) 
        {
            return val1 - val2;
        }

        
        private static int DivisionNumeros(int val1, int val2)
        {
            if (val2 == 0) 
            {
                Console.WriteLine("No se puede dividir entre 0");
                return val1 * val2;
            }
            else
            {
                return val1 / val2;
            }
            
        }

        public static (int, int) CapturarValores() 
        {
            try
            {
            Console.WriteLine("Introduzca Primer Valor: ");
            int val1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introzca Segundo Valor: ");
            int val2 = int.Parse(Console.ReadLine());
           
                return (val1, val2);
            }

            catch (Exception e)
            {
                int val1 = 0;
                int val2 = 0;

                Console.WriteLine("Valor Invalido... se finaliza el programa.... asignando 0");
                Console.WriteLine(e.Message);
                return (val1, val2);
            }
        }
       
        static int SumaNumeros(int val1, int val2) => val1 + val2;
        

    }
}
