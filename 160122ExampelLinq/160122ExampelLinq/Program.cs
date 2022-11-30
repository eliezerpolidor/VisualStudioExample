using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _160122ExampelLinq
{
    class Program
    {
        //public static SqlConnection conexion = new SqlConnection("server=DESKTOP-K3Q2ANG; database=Universidad; integrated security=true");
        static void Main(string[] args)
        {
            
            try 
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
                {
                    DataSource = "DESKTOP-K3Q2ANG",
                    UserID = "sa",
                    Password = "123456",
                    InitialCatalog= "Universidad"
                };
                using (SqlConnection conexion = new SqlConnection(builder.ConnectionString)) 
                {
                    Console.WriteLine("........Conectado a Base de Datos...........");
                    Console.WriteLine("****************************************************************");
                    string query = "select * from DatosEstudiantes";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        conexion.Open();
                        using (SqlDataReader reader=cmd.ExecuteReader()) 
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} {1}", reader.GetString(1),reader.GetString(2));
                            }
                        }
                    }
                }
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("..............Falla de Conexión.......");
                Console.ReadKey();
            }
        }


    }
}
