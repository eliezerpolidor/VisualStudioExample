using System;

namespace EjemploDeclaracionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //METODO 1 PARA DECLARAR/INICIAR UN ARRAY
            //se puede realizar la Declaración y despues se Inicia como sigue:
            //Declaración:
            int[] mi_matriz;
            //Iniciación:
            mi_matriz = new int[3];
            //Asignación de Valores
            mi_matriz[0] = 15;
            mi_matriz[1] = 20;
            mi_matriz[2] = 16;

            //METODO 2 PARA DECLARAR/INICIAR EN LA MISMA LINEA UN ARRAY
            //Declaración / Iniciio en la misma linea del Array
            int[] mi_matriz_ = new int[5];
            //Asignación de Valores
            mi_matriz_[0] = 15;
            mi_matriz_[1] = 20;
            mi_matriz_[2] = 16;
            mi_matriz_[3] = 85;
            mi_matriz_[4] = 30;

            //METODO 3 PARA DECLARAR/INICIAR/ASIGNAR  EN LA MISMA LINEA UN ARRAY
            int[] mi_matriz1 = { 15, 20, 16, 85,30 };
            //OTRA FORMA DE HACERLO ES ASI COMO SE INDICA A CONTINUACIÓN:
            int[] edad = new int[5] { 15, 20, 16, 85, 30 };

            //array de tipo IMPLICITO
            var nombre = new[] { "EliezerP", "Diana", "Jose" };
            var edad_ = new[] { 53, 21, 27 };

            // array de objetos
            //para este tipo de array es obligado crear una clase y un constructor 
            //para asignarle los valores a los objetos
                        
            Empleados Ana = new Empleados("Ana", 27); //creo o instancio el objeto que se va a asignar
                                                      //al arreglo, y paso paramentros para asignar valors a campos
            Empleados[] arrayEmpleados = new Empleados[2]; //creo el arreglo 
            arrayEmpleados[0] = new Empleados("EliezerP", 53); //asigno los campos usando el contructor, forma directa de asignar valores 
            arrayEmpleados[1] = Ana; //asigno el objeto ya instanciado el cual uso el constructor
                                     //para asignar el contenido de los camos, esta es la otra forma de asignar valors al arreglo
//[041653370655]
            //array de tipos o clases anónimas
            var personal = new[]
            {
                new{nombre="EliezerP", edad=53},

                new{nombre="Diana", edad=22},

                new{nombre="Joana", edad=27}
            };

            Console.WriteLine("Printed Array o class Anonymous............");
            Console.WriteLine(personal[2]);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Prints Array Properties...................");
            Console.WriteLine("Using the loop FOR........");
            Console.WriteLine("...........DATA EMPLOYEE..........");
            for (int i = 0; i < arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getInf());
            }
            Console.WriteLine("..............USING THE LOOP FOREACH..........");
            foreach (Empleados item in arrayEmpleados)
            {
                Console.WriteLine(item.getInf());
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

        private  string nombre;
        private int edad;

        public string getInf() 
        {
            return  nombre + " " + edad + " Años";
        }
    }
}
