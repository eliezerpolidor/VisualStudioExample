using System;

namespace EjemploArreglo
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            /*
            int[] mi_matriz = new int[4];
            mi_matriz[0] = 25;
            mi_matriz[1] = 60;
            mi_matriz[2] = 80;
            mi_matriz[3] = 75;
            */
            int[] mi_matriz = { 25, 60, 80, 75,100 };

            for (int i=0; i<4; i++)
            {
                Console.WriteLine($"Contenido del arreglo: {mi_matriz[i]}");
            }
            Console.ReadKey();
            


        }
    }
}
