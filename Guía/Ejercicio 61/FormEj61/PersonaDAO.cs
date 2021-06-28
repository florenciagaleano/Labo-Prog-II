using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FormEj61
{
    public class PersonaDAO
    {
        private static string connectionString = "Data Source=.;Initial Catalog =Guía; Integrated Security = True";

        public static void Guardar(Persona persona)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;

                    comando.CommandText = "INSERT INTO [Persona] ([Nombre],[Apellido])" + "VALUES (@nombre, @apellido) ";
                    comando.Parameters.AddWithValue("@nombre", persona.Nombre);
                    comando.Parameters.AddWithValue("@apellido", persona.Apellido);

                    comando.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

            public static Persona LeerPorId(int id)
            {
                Persona persona = null;
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        SqlCommand comando = new SqlCommand();
                        comando.Connection = sqlConnection;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = String.Format("SELECT * FROM Persona WHERE Id = {0}", id);
                        SqlDataReader dataReader = comando.ExecuteReader();

                        if (dataReader.Read() != false)
                        {
                            persona = new Persona(Convert.ToInt32(dataReader["Id"]), dataReader["Nombre"].ToString(), dataReader["Apellido"].ToString());
                        }

                        dataReader.Close();

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.ToString());
                }

                return persona;
            }


            public static List<Persona> Leer()
            {
                List<Persona> personas = new List<Persona>();
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
                            personas.Add(new Persona(Convert.ToInt32(dataReader["Id"]), dataReader["Nombre"].ToString(), dataReader["Apellido"].ToString()));
                        }

                        dataReader.Close();

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.ToString());
                }

                return personas;
            }


            public static void Eliminar(Persona persona)
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        SqlCommand comando = new SqlCommand();
                        comando.Connection = sqlConnection;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = String.Format("DELETE Persona WHERE ID = {0}", persona.Id);

                        comando.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.ToString());
                }
            }

            public static void Modificar(Persona persona)
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        SqlCommand comando = new SqlCommand();
                        comando.Connection = sqlConnection;
                        comando.CommandType = CommandType.Text;

                        comando.CommandText = String.Format("UPDATE Persona SET [Nombre] = @newNombre, [Apellido] = @newApellido WHERE Id = {0} ", persona.Id);
                        comando.Parameters.AddWithValue("@newNombre", persona.Nombre);
                        comando.Parameters.AddWithValue("@newApellido", persona.Apellido);

                        comando.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.ToString());
                }
            }
    }
}
