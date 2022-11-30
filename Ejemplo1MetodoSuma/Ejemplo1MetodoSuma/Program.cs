using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1MetodoSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            //para llamar al metodo SumaNumeros cree un objeto es decir instancie un objeto y 
            //posteriormente llame al metodo
            //Program suma = new Program();
            //suma.SumaNumeros();

            //entonces para poder llamar al metodo sin crear un objeto es
            //colocando la palabra  "static" al metodo 
            SumaNumeros();
            SumaNumeros();
            Console.WriteLine("..............MENSAJE DESDE EL MAIN...............");
            SumaNumeros();
            SumaNumeros();
            

        }
        static int SumaNumeros()
        {
            Console.WriteLine("Introducce Valor1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introducce Valor2: ");
            int num2 = int.Parse(Console.ReadLine());

            int suma1 = num1 + num2;
            Console.WriteLine($"La suma es: {suma1}");
            Console.ReadKey();
            return suma1;
        }
    }

    class Prueba1 
    {
    
    }
}
