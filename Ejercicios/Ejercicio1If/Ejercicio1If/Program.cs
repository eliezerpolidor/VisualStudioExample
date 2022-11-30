using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1If
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cold = false;
            int[] arranInteger = { 2, 1, 3, 600, 10, 5, 56 };
            travel(arranInteger);

            Console.WriteLine($"it´s cold: {!cold}");
            Console.WriteLine("************************************************");
            Console.WriteLine("..................Show Arrangement.....................");
            travel(arranInteger);
            Console.ReadKey();
        }



        private static void travel(int[] arran, int p=0)
        {
            if (p==arran.Length)
            {
                return;
            }

            Console.WriteLine(arran[p++]);
            travel(arran, p);

        }


    }
}
