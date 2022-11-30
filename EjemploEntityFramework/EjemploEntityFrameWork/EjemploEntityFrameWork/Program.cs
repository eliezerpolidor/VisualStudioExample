using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEntityFrameWork
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EjemploEntityFrameworkEntities db = new EjemploEntityFrameworkEntities())
            {
                
                Gente oGente = new Gente();
                oGente.nombre = "Mariño";
                oGente.edad = 36;
                oGente.idSexo = 2;

                
                db.Gente.Add(oGente);
                db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Gente ON;");
                db.SaveChanges();

                var lst = db.Gente;
                foreach (var oGente_ in lst) 
                {
                    Console.WriteLine(oGente_.nombre + " " + oGente_.edad);
                }
            }

                Console.Read();
        }
    }
}
