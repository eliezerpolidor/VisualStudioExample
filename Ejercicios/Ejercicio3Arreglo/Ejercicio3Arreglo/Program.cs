using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Arreglo
{
    class Program
    {
        private float[] salaryM = new float[4];
        private float[] salaryA = new float[4];
        private int addSalaryEmployeeM = 0;
        private int addSalaryEmployeeA = 0;
        static void Main(string[] args)
        {
            Program expensesSalary = new Program();
            //Program expensesSalaryAfternoon = new Program();
            expensesSalary.enterEmployeeM();
            Console.WriteLine("***************************************************");
            expensesSalary.enterEmployeeA();
            Console.WriteLine("****************************************************");
            expensesSalary.showSalaryEmployee();
        }

        int enterEmployeeM ()
        {
            Console.WriteLine("...........Enter Salary Employee Morning........ ");
            for (int i = 0; i < salaryM.Length; i++)
            {
                Console.WriteLine($"Employee No {++i}",i--);
                string line = Console.ReadLine();
                salaryM[i] = int.Parse(line);
                addSalaryEmployeeM = int.Parse(line) + addSalaryEmployeeM;
            }

            return addSalaryEmployeeM;
        }

        int enterEmployeeA() 
        {
            Console.WriteLine("...........Salary in the Afternoon shift........ ");
            for (int i = 0; i < salaryA.Length; i++)
            {
                Console.WriteLine($"Employee No {++i}",i--);
                string line = Console.ReadLine();
                salaryA[i] = int.Parse(line);
                addSalaryEmployeeA = int.Parse(line) + addSalaryEmployeeA;
            }
            return addSalaryEmployeeA;
        }
        void showSalaryEmployee() 
        {
            Console.WriteLine($"Morning Shift Expenses: {addSalaryEmployeeM}");
            Console.WriteLine($"Late Shift Salary Expenses: {addSalaryEmployeeA}");
            Console.ReadKey();
        }
    }
}
