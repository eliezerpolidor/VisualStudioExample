/******************************Sintaxis Básica 4:***************************
 * 1) Operador "=" este es el operador ASIGNACIÓN 
 * 2) Declaración implicita de variables
 * 3) Conversiones implicitas y explicitas
 *************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSintaxisBasica4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            //Para asignar el mismo valor a los 4 variables al mismo tiempo

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;

            //Para mostrar por pantalla el valor de las variables

            Console.WriteLine("1) Edad Persona1: " + edadPersona1 + " 2) Edad Persona2: " + edadPersona2 +
                              " 3) Edad Persona3: " + edadPersona3 + " 4) Edad Persona4: " + edadPersona4);
            Console.Read();

            //**********************************************************************************************

            //Se puede declarar mejor asi en una sola linea

            int agePerson1, agePerson2, agePerson3, agePerson4;

            agePerson1 = agePerson2 = agePerson3 = agePerson4 = 27;

            //****************************************NOTA*************************************
            //ESTO NO SE PUEDE HACER YA QUE SOLO LA ÚLTIMA VARIABLE TOMA EL VALOR LAS OTRAS NO
            // inte  agePerson1 = agePerson2 = agePerson3 = agePerson4 = 27;

            Console.WriteLine("Age Person1: " + agePerson1);
            Console.WriteLine("Age Person2: " + agePerson2);
            Console.WriteLine("Age Person3: " + agePerson3);
            Console.WriteLine("Age Person4: " + agePerson4);

            //Para detener momentaneamente la pantalla: se puede usar Read() ó Readkey()
            //cualquiera de los dos sirve
            Console.ReadKey();

            //Declaración implicita de variable consiste en lugar de usar el tipo de datos se 
            //usa de una ves la palabra reservada "VAR"
            var edadPersona = 27;
            Console.WriteLine(edadPersona);

            //cuando se usa una declaración implicita de variables es despues que se le da un valor
            // este no se puede cambiar, es decir tiene que usar el  mismo valor en todo el programa
            //*******************************************************************************************

            //Conversiones explicitas e implicitas

            double temperatura = 34.5;

            int temperaturaCaracas;

            //SE PLANTEA EL PROBLEMA DE PASAR EL VALOR DE UNA VARIABLA A OTRA SIENDO AMBAS DE DIFERENTES TIPOS
            // para esto realizamos una conversión explicita  y un casting
            temperaturaCaracas = (int)temperatura;
            Console.WriteLine("Temparatura en Caracas: " + temperaturaCaracas);
            Console.ReadKey();

            //Conversión implicita: pasar el valor de una variable a otra siendo ambas del mismo tipo pero
            //diferente longitud
            int habitantesCiudad = 1000000;
            long habitantesCaracas = habitantesCiudad;
            Console.WriteLine("Habitantes Caracas: " + habitantesCaracas);

            // OTRO EJEMPLO DE CONVERSION IMPLICITA

            float pesoMaterial = 5.74F;
            double pesoMaterialM = pesoMaterial;
            Console.WriteLine("peso: " + pesoMaterialM);

            //para buscar información sobre conversiones numéricas nos ubicamos
            //en google y escribirmos "la tabla de conversiones numéricas implicitas"
             
            




        }
    }
}
