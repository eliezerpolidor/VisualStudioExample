/*Conversión de texto a número usando el metod "parse()"
 ************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploVideo7ConvertirValoresString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducce el Primer `Número: ");
            //permite obtener un valor por pantalla
            //todo valor que se introducce por pantalla es string entonces hay que convertirlo 
            //a númerico
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introducce el Segundo Número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La Suma es: " + (num1 + num2));
            Console.ReadKey();
        }
    }
}
