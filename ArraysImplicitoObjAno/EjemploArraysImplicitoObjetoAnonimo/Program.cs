using System;

namespace EjemploArraysImplicitoObjetoAnonimo
{
    class Program
    {
        static void Main(string[] args)
        {
            // array implicito
            var datos = new[] { "EliezerP", "Juan", "Pedro" };

            // array de objetos

            Empleados Ana = new Empleados("Ana", 27);
            
            Empleados[] arrayEmpleados = new Empleados[3];

            arrayEmpleados[0] = new Empleados("EliezerP", 53);

            arrayEmpleados[1] = Ana;

            arrayEmpleados[2] = new Empleados("Diana", 27);

            //cree este arreglo para probar un forech que esta ababjo
            int[] val = new[] { 5, 6, 8 };
            

            for (int i=0;i<arrayEmpleados.Length;i++)
            {
                //comento esto y los campos declarados public en las clases xq lo voy hacer por el get
                //Console.WriteLine($"Información del Registro: Nombre:  {arrayEmpleados[i].nombre} edad: {arrayEmpleados[i].edad}");
                //Console.WriteLine("Información del Registro: Nombre:  " + arrayEmpleados[i].nombre + " Edad: " + arrayEmpleados[i].edad);
                //cree un metodo public string getInfo y con este pude mostrar en pantalla
                Console.WriteLine(arrayEmpleados[i].getInfo());
            }
            Console.ReadKey();

            //voy hacer los mismo del for pero con forech
            Console.WriteLine("con el forech..............");
            foreach (Empleados Dat in arrayEmpleados) 
            {
                Console.WriteLine(Dat.getInfo());            
            }
            Console.ReadKey();
            // array de tipo o clases anonimas

            var persona = new[]
            {
                new{nombre = "EliezerP", edad=53},
                new{nombre = "Ana", edad = 27},
                new{nombre = "Diana", edad=27},
            };

            
            for (int i=0; i<persona.Length;i++) 
            {
                Console.WriteLine(persona[i]);
                //Console.WriteLine($"El registro es: {persona[0]}");
                //Console.WriteLine($"El registro es: {persona[1]}");
                //Console.WriteLine($"El registro es: {persona[2]}");
            }
            Console.ReadKey();

            //para mostrar el arreglo persona con foreach
            Console.WriteLine("para mostrar el arreglo peronsa con el foreach..................");
            foreach (var datper in persona) 
            {
                Console.WriteLine(datper);
                
            }
            Console.ReadKey();

            Console.WriteLine("con el forech..............para mostrar el arreglo val");
            foreach (int dat1 in val) 
            {
                Console.WriteLine(dat1);
            }
            Console.ReadKey();
        }
    }

    class Empleados 
    {
        public Empleados(string nombre, int edad) 
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string getInfo() 
        {
            return "Nombre del Empleado: " + nombre + " Edad:  " + edad;
        }
        
        private string nombre;
        private int edad;

        //estos campos que declare public los comento porque voy hacer con el get

        //public string nombre;
        //public int edad;
    }

}
