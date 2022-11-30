using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGrafo
{
    public class Vertice
    {
        public int Valor { get; set; }
        public List<Vertice> Arista {get;set;}

        public Vertice(int Valor) 
        {
            this.Valor = Valor;
            Arista = new List<Vertice>();
        }
    }
}
