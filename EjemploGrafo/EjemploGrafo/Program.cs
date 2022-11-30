using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGrafo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertice oVertice6 = new Vertice(6);
            Vertice oVertice5 = new Vertice(5);
            Vertice oVertice4 = new Vertice(4);
            Vertice oVertice3 = new Vertice(3);
            Vertice oVertice2 = new Vertice(2);
            Vertice oVertice1 = new Vertice(1);

            oVertice6.Arista.Add(oVertice4);
            oVertice4.Arista.Add(oVertice5);
            oVertice4.Arista.Add(oVertice3);
            oVertice3.Arista.Add(oVertice2);
            oVertice5.Arista.Add(oVertice2);
            oVertice5.Arista.Add(oVertice1);
            oVertice2.Arista.Add(oVertice1);

            Camino(oVertice6);
            Console.ReadKey();
        }

        public static void Camino(Vertice oVertices,string sangria="") 
        {
            if (oVertices !=null) 
            { 
                Console.WriteLine(sangria+oVertices.Valor);
                Console.ReadKey();
                foreach (var oV in oVertices.Arista) 
                {
                    Camino(oV,sangria+"\t");
                }
            }
        }
    }
}
