using System;

namespace EjemploPasarArrayComoParametro
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new[] { 4, 5, 8 };

            ProcesarDatos(num);
            foreach (int valdat in num)
            {
                Console.WriteLine($"Datos del Arreglo: {valdat}");
            }
            Console.ReadKey();
        }

        static void ProcesarDatos(int [] datos) 
        {
            for (int i=0;i<datos.Length;i++) 
            {
                datos[i] += 10;
            }

        }
    }
}
