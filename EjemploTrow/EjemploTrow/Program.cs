﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploTrow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el Número del Mes: ");
            int nummes = int.Parse(Console.ReadLine());
            try 
            {
                Console.WriteLine("El mes es: " + NombreDelMes(nummes));
            }
            catch (Exception e)
            {
                Console.WriteLine("El mensaje de la excepción:  " + (e.Message));
            }

            Console.WriteLine("Aquie continua el programa............");
            Console.ReadLine();

        }

        public static string NombreDelMes(int mes) 
        {
            switch (mes) 
            {
                case 1:
                    return "Enero;";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";

                default:
                    //return "Mes Erróneo";

                    throw new ArgumentOutOfRangeException();
                        
            }
        }

    }
}
