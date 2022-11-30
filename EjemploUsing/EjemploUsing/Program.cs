using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejemplo1 Uso = new Ejemplo1();
            Uso.Use();
            Console.Read();
        }
    }

    class Ejemplo1
    {
            public string manyLines = @"Esta es la Linea Uno
            This is line two
            Here is line three
            The penultimate line is line four
            This is the final, fifth line.";

            public void Use()
            { 
                using (var reader = new StringReader(manyLines))
                {
                    string item;
                    do
                    {
                        item = reader.ReadLine();
                        Console.WriteLine(item);
                        Console.ReadKey();
                    } while (item != null) ;
                }
            }
    }
}
