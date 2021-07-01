using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Entidades
{
    public class JugadaDAO : IDatos
    {
        private SqlConnection conexion;

        public void Guardar()
        {
            try
            {
                conexion = new SqlConnection("Server = .;Database = 20201203-sp ; Trusted_Connection = true;");

                SqlCommand c = new SqlCommand();
                c.Connection = conexion;
                c.CommandType = System.Data.CommandType.Text;

                conexion.Open();

                c.CommandText = "INSERT INTO log (entrada, alumno) VALUES (@entrada,@alumno)";
                c.Parameters.AddWithValue("@alumno", "Flor");
                c.Parameters.AddWithValue("@entrada", $"Se disfrutó el gol del siglo a las {DateTime.Now} hs");
                c.ExecuteNonQuery();
            }catch(Exception)
            {

            }
            finally
            {
                conexion.Close();
            }

        }


        public string Leer()
        {
            throw new NotImplementedException();
        }
    }
}
