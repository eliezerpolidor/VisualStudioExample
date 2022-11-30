using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Arreglo
{
    class Program
    {
        private float[] heightPers = new float[5];
        private float height=0 ;
        private float average=0;
        static void Main(string[] args)
        {
            Program heigh = new Program();
            Console.WriteLine(".............Whait is Height Person.............");
            heigh.askHeightPerson();
            Console.WriteLine("**************************************************");
            heigh.printHeightPerson();
        }

        float askHeightPerson() 
        {
            //float average = 0;
            Console.WriteLine(".................Ask For Height Person.............");
            for (int i = 0; i < heightPers.Length; i++)
            {
                Console.WriteLine($"Enter Person Height No {++i} ? ",i--);
                string line = Console.ReadLine();
                heightPers[i] = float.Parse(line);
                average = float.Parse(line) + average;
            }
            average = average / heightPers.Length;
            return average;
        } 

        void printHeightPerson() 
        {
            for (int i = 0; i < heightPers.Length; i++)
            {
                if (heightPers[i] >= average)
                {
                    height++;
                }
            }

            Console.WriteLine("............Display on screen Height Person............");
            Console.WriteLine($"Average Person Height: {average}");
            Console.WriteLine($"Person Height: {height} ");
            Console.WriteLine($"Person Short: {heightPers.Length-height} ");
            Console.ReadKey();
            
        }
    }
}
