using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;

            try 
            {
                string linea;

               // int contador = 0;

                string path = @"C:\Users\eliez\Desktop\EliezerP\VisualStudio\EjemploFinally\Fichero.txt";

                archivo = new System.IO.StreamReader(path);

                while ((linea = archivo.ReadLine()) != null) 
                {
                    Console.WriteLine(linea);
                    //contador++;
                    
                }
                //Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Falla al Leer el Archivo.....");
                //Console.ReadKey();
            }
            finally 
            {
                if (archivo != null) archivo.Close();

                Console.WriteLine("Conexión con el Archivo Cerrada.....");
                Console.ReadKey();
            }
        }
    }
}
