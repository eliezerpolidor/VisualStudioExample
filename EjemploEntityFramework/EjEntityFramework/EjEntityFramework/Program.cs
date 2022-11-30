using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjEntityFramework
{
    class Program
    {

        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            Console.TreatControlCAsInput = true;

            Console.WriteLine("Agregar(A) -  Editar(E) - Borrar(B):  ");
           
            do
            {
                cki = Console.ReadKey();
                Console.Write(" --- Debes Presionar A----> Agregar Registro    /   E----> Editar Registro    /   B---> Borrar Registro ");
                Console.WriteLine(cki.Key.ToString());
            } while (cki.Key != ConsoleKey.Escape && cki.Key != ConsoleKey.A && cki.Key != ConsoleKey.B && cki.Key != ConsoleKey.E);


            if (cki.Key == ConsoleKey.A) 
            {
                /*para agreegar un registro*/
                AgregarRegistrto AgregarRegidtro_ = new AgregarRegistrto();
                AgregarRegidtro_.AccionAgregar();
            }

            if (cki.Key == ConsoleKey.E) 
            {
                /*para cambiar un campo de un registro*/
                EditarRegistro EditarRegistro_ = new EditarRegistro();
                EditarRegistro_.AccionEditar();
            }

            if (cki.Key == ConsoleKey.B) 
            {
                /*para borrar un registro*/
                BorrarRegistro borrarRegistro_ = new BorrarRegistro();
                borrarRegistro_.AccionBorrar();
            }

            Console.ReadKey();

        }
    }


    class AgregarRegistrto
    {
        public void AccionAgregar()
        {
            using (CursoBDEntities db = new CursoBDEntities())
            {
                Estudiantes c_Estudiantes = new Estudiantes();
                c_Estudiantes.nombre = "Rafael";
                c_Estudiantes.idCarrera = 2;

                db.Estudiantes.Add(c_Estudiantes);
                db.SaveChanges();
                
                var lst = db.Estudiantes;
                foreach (var cEstudiantes in lst)
                {
                    Console.WriteLine(cEstudiantes.nombre);
                }
            }
        }
    }

    class EditarRegistro
    {
        public void AccionEditar() 
        {
          using (CursoBDEntities db = new CursoBDEntities()) 
          {      
               Estudiantes c_Estudiantes = db.Estudiantes.Where(e => e.nombre == "Rafael").First();
               c_Estudiantes.nombre = "Camacho";
               db.Entry(c_Estudiantes).State = System.Data.Entity.EntityState.Modified;
               db.SaveChanges();

                var lst = db.Estudiantes;
                foreach (var cEstudiantes in lst)
                {
                    Console.WriteLine(cEstudiantes.nombre);
                }
            }
        }
    }

    class BorrarRegistro 
    {
        
        public void AccionBorrar() 
        {
            using (CursoBDEntities db = new CursoBDEntities())
            {
                Estudiantes c_Estudiantes = db.Estudiantes.Find(12);

                db.Estudiantes.Remove(c_Estudiantes);
                db.SaveChanges();


                var lst = db.Estudiantes;
                foreach (var cEstudiantes in lst)
                {
                    Console.WriteLine(cEstudiantes.nombre);
                }
            }
        }
    }

}
