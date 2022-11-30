using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();
            Coche coche2 = new Coche();
            Coche coche3 = new Coche(4500.3, 1200.6);

            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());
            Console.WriteLine(coche3.getInfoCoche());
            coche3.setExtras(true, "cuero");
            Console.WriteLine(coche3.getExtras());
            Console.ReadKey();
            
        }
    }

    partial class Coche
    {
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "tela";

        }

        public Coche(double largocoche, double anchocoche)
        {
            ruedas = 4;
            largo = largocoche;
            ancho = anchocoche;
            tapiceria = "tela";
        }
    }

    partial class Coche
    { 
        public string getInfoCoche() 
        {
            return "Información del Coche: Ruedas: Ruedas: " + ruedas + " Largo" + largo + " Ancho: " + ancho;
        }
        
        public void setExtras(bool climatizador, string tapiceria) 
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

        public string getExtras() 
        {
            return "Extras del coche: \n " + " Tapiceria: " + tapiceria + " Climatizador: " + climatizador;
        }

        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;

             
    }
}
