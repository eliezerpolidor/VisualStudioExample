using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace A
{
    class Program
    {
        private static int sum = 0;
        static void Main(string[] args)
        {
            
            B.b1.menja();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("La Suma es : {0} {1}", (B.b1.sumaEnteros(18, 7)), (B.b1.sumaEnteros(6, 4)));
            sum = B.b1.v1 + 2;
            Console.WriteLine(sum);
            Console.WriteLine("---------------------------------------------------------------------");
            //Salud.clinicaCentral.inventarioInsumo();
            //Salud.clinicaCentral.inventarioInsumo();
            //Salud.c1.cc();
            Console.ReadKey();
        }
    }
}

namespace B
{
    class b1
    {
        public static int v1=93;
        public static void menja()
        {
            Console.WriteLine("Estoy en namespace B en la clase b1.........");
        }  
        
        public static double sumaEnteros(double n1, int n2) 
        {

            return (n1 + n2);
        }


    }
}

namespace Salud
{
    class c1
    {
        static int numero1 = 5;
        
        public static void cc(string[] args)
        {

        }
        public  static void primerMetodo() 
        {
            //int numero1 = 5;
            //return numero1;
        }

        public static void segundoMetodo() 
        {
            Console.WriteLine(numero1);
        }
    }

    class clinicaCentral
    {
        internal static void inventarioInsumo()
        {
            throw new NotImplementedException();
        }
    }
}