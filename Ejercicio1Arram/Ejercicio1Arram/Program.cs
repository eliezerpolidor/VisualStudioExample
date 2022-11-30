using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Arram
{
    class Program
    {
        static void Main(string[] args)
        {

            employees.showArrayEmployee();
            
        }

        
    }

    class employees
    {
        string name;
        int age;

        public employees(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }
        public static void showArrayEmployee()
        {
            employees[] arrayEmployees = new employees[3];
            arrayEmployees[0] = new employees("EliezerP", 53);
            arrayEmployees[1] = new employees("DianaR", 27);
            arrayEmployees[2] = new employees("Carolina", 35);

            Console.WriteLine("Printed with a For  loop..................");
            for (int i = 0; i < arrayEmployees.Length; i++)
            {
                Console.WriteLine($"Employee: {arrayEmployees[i].name} Age: {arrayEmployees[i].age}");
            }
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Printed with a Foreach     loop................................");
            foreach (employees arrayEmp in arrayEmployees)
            {
                Console.WriteLine($"Name: {arrayEmp.name} Age: {arrayEmp.age}");
            }
            Console.ReadKey();
        }
    }
}
