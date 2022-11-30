using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConstantes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int VALOR1 = 5;

            const int VALOR2 = 7;

            //nueva manera de usar el writeline() sin usar + sino usando la ,
            Console.WriteLine("El valor de la constante es: {0} {1}", VALOR1, VALOR2);
            Console.ReadKey();

            //calcular el radio de una circunferencia

            const double pi = 3.1416;
           

            Console.WriteLine("Introduzca el Radio de la Circunferencia: ");

            var r = double.Parse(Console.ReadLine());

            double ac = (pi * r * r);
            Console.WriteLine($"La Circunferencia es: {(pi * r * r)}");
            //otra forma de mostrarlo
            Console.WriteLine($"La Circunferencia es: {ac}");
            Console.WriteLine("La Circunferencia es: {0}",ac);
            Console.WriteLine("La Circunferencia es: {0}", (pi * r * r));

            //OTRO FORMA DE CALCULAR EL ÁREA DE UNA CIRCUNFERENCIA
            Console.WriteLine("ESTE ES USANDO EL METODO MATH............");
            double area = Math.Pow(r, 2) * pi;
            Console.WriteLine($"La Circunferencia es: {area}");

            Console.ReadKey();
        }
    }
}
