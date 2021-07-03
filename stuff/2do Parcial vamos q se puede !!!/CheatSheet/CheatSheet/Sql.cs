using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace CheatSheet
{
    public class DAO
    {
        #region Sql
        //should be static
        public void Guardar()
        {
            SqlConnection conexion = null;
            try
            {
                conexion = new SqlConnection("Server = .;Database = nombre de base de datos ; Trusted_Connection = true;");

                SqlCommand c = new SqlCommand();
                c.Connection = conexion;
                c.CommandType = System.Data.CommandType.Text;

                conexion.Open();

                c.CommandText = "INSERT INTO nombre de tabla (entrada, alumno) VALUES (@entrada,@alumno)";
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

        public static string Leer()
        {
            string connectionString = "Data Source=.;Initial Catalog = nombre de la base; Integrated Security = True";
            string ret = string.Empty;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = sqlConnection;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT * FROM Persona";

                    SqlDataReader dataReader = comando.ExecuteReader();

                    while (dataReader.Read() != false)
                    {
                        ret = dataReader[0].ToString() + dataReader[1].ToString();//y asi con las tablitas
                    }

                    dataReader.Close();

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

            return ret;
        }

        public static void Eliminar(object elementoAEliminar)
        {
            string connectionString = "Data Source=.;Initial Catalog = nombre de la base; Integrated Security = True";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = sqlConnection;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = String.Format("DELETE Elemento WHERE ID = {0}", elementoAEliminar/*elementoAEliminar.Id*/);

                    comando.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        public static void Modificar(object objetoAModificar)
        {
            string connectionString = "Data Source=.;Initial Catalog = nombre de la base; Integrated Security = True";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = sqlConnection;
                    comando.CommandType = CommandType.Text;

                    comando.CommandText = String.Format("UPDATE Persona SET [Nombre] = @newNombre, [Apellido] = @newApellido WHERE Id = {0} ", objetoAModificar/*obj.Id*/);
                    comando.Parameters.AddWithValue("@newNombre", objetoAModificar);/*Columna1*/
                    comando.Parameters.AddWithValue("@newApellido", objetoAModificar);/*Columna2*/

                    comando.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        #endregion
    }

}

