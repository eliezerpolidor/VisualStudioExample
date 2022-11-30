using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Usoif();



        }

        public static void Usoif() 
        {
            Console.WriteLine("Escribe tù nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Cúal es Tú edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("No de Ref.: ");
            int dep = int.Parse(Console.ReadLine());

            Console.WriteLine("Su Nombre es: " + nombre + "  " + edad + " Años");
            if (edad >= 18  &&  dep > 0) Console.WriteLine("Autorizado a Entrar........");
            
            else Console.WriteLine("Usted No TIENE PERMISO DE INGRESO..... FAVOR RETIRESE....");
            
            Console.ReadKey();
        }


    }
}
