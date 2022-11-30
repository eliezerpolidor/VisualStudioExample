using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEntiryMejorado
{
    class Program
    {
        static void Main(string[] args)
        {
            CargarListaEstudiantes CLE = new CargarListaEstudiantes();
            CLE.AccionCLE();
        }
    }

    public partial class CargarListaEstudiantes
    {
        public void AccionCLE() 
        {
            using (CursoBDEntities db = new CursoBDEntities()) 
            {
                var lst = db.Estudiantes;
                foreach(var cEstudiantes in lst) 
                {
                    Console.WriteLine(cEstudiantes.nombre);
                    Console.ReadKey();
                }
            }
        }
    }

}
