using System;

namespace EjemploRetornarArrayComoParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arrayElementos = LeerDatosArray();

            Console.WriteLine("Impresión desde el Main..............");
            foreach (int arrayEle in arrayElementos) 
            {
                Console.WriteLine($"Contenido del Arreglo: {arrayEle} ");
            }
            Console.ReadKey();
        }

        static int[] LeerDatosArray() 
        {
            Console.WriteLine("Cuantos Elementos Deseas que tenga el Array: ");
            int numEle = int.Parse(Console.ReadLine());

            int[] valDatArray = new int[numEle];

            for (int i=0;i<numEle;i++ ) 
            {
                Console.WriteLine($"Introducce un Entero para la Posición: {i}");
                valDatArray[i] = int.Parse(Console.ReadLine());
            }

            return valDatArray;
        }
    }
}
