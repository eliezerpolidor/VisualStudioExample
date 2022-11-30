using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca Valor1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca Valor2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(sumaNumeros(num1, num2));
            Console.ReadKey();
        }

        static int sumaNumeros(int num1, int num2) 
        {
            return num1 + num2;
        }

        //OTRA FORMA DE HACER EL METODO ANTERIOR ES CON =>
        //DEMOSTRACIÒN DIVIDIENDO DOS NUMERO 

        static int divieNumeros(int num1, int num2) => num1 / num2;


    }
}
