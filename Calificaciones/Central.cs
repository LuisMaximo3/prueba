using Calificaciones.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    class Central
    {
        static string Constrg = "Data Source=LAPTOP-4KONVT6V\\PRACTICA;Initial Catalog=Calificaciones;User ID=sa;Password=1234;TrustServerCertificate=True";
        public static Response RegistrarAlumno(Alumno alumno) 
        {
            Response response = new Response();
            //por determinar  
            SqlConnection conn = new SqlConnection(Constrg);
            SqlCommand comm=new SqlCommand("insert into alumno (nombre,apellido,matricula)values(@Nombre,@Apellido,@Matricula)", conn);
            comm.Parameters.AddWithValue("@Nombre", alumno.Nombre);
            comm.Parameters.AddWithValue("@Apellido", alumno.Apellido);
            comm.Parameters.AddWithValue("@Matricula", alumno.Matricula);
            try 
            {
                conn.Open();
                comm.ExecuteReader();
                response.Codigo = 1;
                response.Mensaje = "Alumno registrado correctamente";
            }
            catch(Exception ex) 
            {
                response.Codigo= 2;
                response.Mensaje= "Ocurrio un error, el alumno no pudo ser registrado";
                Logger.Log(ex.Message, "RegistrarAlumno", "Centrar");
            }
            finally 
            {
                conn.Close(); 
            }
            return response;
        }

        public static DataTable CargarAlumnos() 
        { //por determinar
            DataTable dtalumnos= new DataTable();
            SqlConnection conn = new SqlConnection(Constrg);
            SqlCommand comm = new SqlCommand("select * from alumno", conn);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(dtalumnos);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, "CaragarAlumnos", "Central");
            }
            finally
            {
                conn.Close();
            }

            return dtalumnos;
         
        }
        public static DataTable CargarMateria()
        { //por determinar
            DataTable dtmateria = new DataTable();
            return dtmateria;

        }

        public static Response RegistrarMaterias(Materia materia) 
        {
            Response response = new Response();
            //por determinar  
            SqlConnection conn = new SqlConnection(Constrg);
            SqlCommand comm = new SqlCommand("insert into materia (nombre,codigo)values(@Nombre,@Codigo)", conn);
            comm.Parameters.AddWithValue("@Nombre", materia.Nombre);
            comm.Parameters.AddWithValue("@Codigo", materia.Codigo);

            try
            {
                conn.Open();
                comm.ExecuteReader();
                response.Codigo = 1;
                response.Mensaje = "Materia registrado correctamente";
            }
            catch (Exception ex)
            {
                response.Codigo = 2;
                response.Mensaje = "Ocurrio un error, la materia no pudo ser registrada";
                Logger.Log(ex.Message, "RegistrarMat", "Centrar");
            }
            finally
            {
                conn.Close();
            }
            return response;
        }   

    }
}
