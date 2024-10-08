using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
     class Resgistrarmateria
    {
        static string Constrg = "Data Source=LAPTOP-4KONVT6V\\PRACTICA;Initial Catalog=Calificaciones;User ID=sa;Password=1234;TrustServerCertificate=True";

        public static void registrarmat(string nombre, string codigo)
        {
            SqlConnection conn = new SqlConnection(Constrg);
            SqlCommand comm = new SqlCommand("insert into materia (nombre,codigo)values(@Nombre,@Codigo)", conn);
            comm.Parameters.AddWithValue("@Nombre", nombre);
            comm.Parameters.AddWithValue("@Codigo", codigo);

            try
            {
                conn.Open();
                comm.ExecuteReader();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
