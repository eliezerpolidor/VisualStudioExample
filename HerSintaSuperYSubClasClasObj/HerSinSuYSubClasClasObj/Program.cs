using System;

namespace EjemploHerenciaSintaxisSuperYSubClasesClaseObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballos caballos = new Caballos("toronto" /*nombre del caballo, ha pasar en el paramentro*/);

            Humano persona = new Humano("EliezerP");

            Gorila gorila = new Gorila("Cornelio");

            Console.WriteLine("Probando como se HEREDA: \n");
            persona.getNombre();
            persona.pensar();
            persona.respirar();
            persona.cuidarCrias();
        }
    }

    class Mamiferos 
    {
         public Mamiferos(string nombre) 
        {
            nombreSerVivo = nombre;
        }

        public void respirar() 
        {
            Console.WriteLine("Soy Capaz de Respirar");
        }

        public void cuidarCrias() 
        {
            Console.WriteLine("Cuido de mis crías hasta que se valgan por si solas");  
        }

        public void getNombre() 
        {
            Console.WriteLine("El nombre del Ser Vivo es:\n" + nombreSerVivo);
        }

        private string nombreSerVivo;
    }

    class Caballos : Mamiferos //esta es la sintaxis de la herencia, lo que quiere decir que todos
                               //los metodos y atributos que tenga las clase Mamiferos tambien los
                               //podra usar la clase Caballos
    {
        public Caballos(string nombreCaballo) : base(nombreCaballo) 
        {
        
        }
        
        public void galopar() 
        {
            Console.WriteLine("Soy capaz de Galopar");
        }
    }

    class Humano : Mamiferos
    {
        
        public Humano(string nombrePersona) : base(nombrePersona) 
        {
        
        }
        
        public void pensar()
        {
            Console.WriteLine("Soy Capaz de PENSAR....");
        }
    }

    class Gorila : Mamiferos 
    { 
        
        public Gorila(string nombreGorila) : base(nombreGorila) 
        { 
        
        }
        
        public void trepar() 
        {
            Console.WriteLine("Soy capaz de Trepar");
        }
    }
}
