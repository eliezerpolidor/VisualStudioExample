using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
            Console.ReadKey();
        }

        static void realizarTarea() 
        {
            Punto origen = new Punto();
            
            Punto destino = new Punto(128,80);

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La Distancia entre los Puntos es de : {distancia}");

            Console.WriteLine($"Números de Objetos Creados: {Punto.ContadorDeObjetos()}");
           
        }
    }
}
