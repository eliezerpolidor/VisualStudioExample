using System;
using System.Linq;
using System.Collections.Generic;
    

namespace EjemploLinqObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlEmpresaEmpleados CE = new ControlEmpresaEmpleados();
            Console.WriteLine("Introducce Valor 1 o 2:");
            string entrada = Console.ReadLine();
            try
            {
                 //CE.getCEO();
                //CE.getEmpleadosSoluciones();
                int entradaId = Convert.ToInt32(entrada);

                CE.getEmpresa(entradaId);
                
            }
            catch (Exception) 
            {
                Console.WriteLine("No Debe Introduccir Texto...............");
            }
            Console.ReadKey();
        }
    }

    class Empresa 
    { 
         public int Id { get; set; }
        public string Nombre { get; set; }

        public void getDatosEmpresa() 
        {
            Console.WriteLine("Empresa {0} con id {1}", Nombre, Id);
        }
    }

    class ControlEmpresaEmpleados 
    {
        public ControlEmpresaEmpleados() 
        {
            listaEmpresa = new List<Empresa>();

            listaEmpleados = new List<Empleado>();

            listaEmpresa.Add(new Empresa { Id = 1, Nombre = "Google" });

            listaEmpresa.Add(new Empresa { Id = 2, Nombre = "Soluciones Informáticas" });

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Sergio Brin", Cargo = "CEO", Sueldo = 150, EmpresaId = 1 });

            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Albeerto Perez", Cargo = "CEO", Sueldo = 250, EmpresaId = 2 });

            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Juan Escarbajo", Cargo = "CO-CEO", Sueldo = 125, EmpresaId = 1 });

            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Perla Castro", Cargo = "CO-CEO", Sueldo = 110, EmpresaId = 2 });
        }

        public void getCEO()
        {
            IEnumerable<Empleado> ceos = from Empleado in listaEmpleados where Empleado.Cargo == "CEO" select Empleado;

            foreach(Empleado empleado1 in ceos) 
            {
                empleado1.getDatosEmpleado();
            }

        }    

        public void getEmpleadosOrdenados () 
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Nombre descending select empleado;

            foreach(Empleado empleado1 in empleados)
            {
                empleado1.getDatosEmpleado();
            }
        }

        //para hacer un join con linq
        public void getEmpleadosSoluciones() 
        {
            IEnumerable<Empleado> empleadosSol = from empleado in listaEmpleados join Empresa in listaEmpresa
                                              on empleado.EmpresaId equals Empresa.Id
                                              where Empresa.Nombre == "Soluciones Informáticas" select empleado;
            foreach (Empleado empleado1 in empleadosSol)
            {
                empleado1.getDatosEmpleado();
            }

        }

        public void getEmpresa(int Id)
        {
            IEnumerable<Empleado> empleadosSol = from empleado in listaEmpleados join Empresa in listaEmpresa
                                                on empleado.EmpresaId equals Empresa.Id
                                                where Empresa.Id == Id select empleado;
            foreach (Empleado empleado1 in empleadosSol)
            {
                empleado1.getDatosEmpleado();
            }

        }

        public List<Empresa> listaEmpresa;
        public List<Empleado> listaEmpleados;
          
    }
    
    
    class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double Sueldo { get; set; }
         
        //clave foránea

        public int EmpresaId { get; set; }
        public void getDatosEmpleado() 
        {
            Console.WriteLine("Empleado {0} con Id {1}, Cargo {2} con salario {3} y" +
                " pertenece a la empresa {4}", Nombre, Id, Cargo, Sueldo, EmpresaId); 
        }

    }
}
