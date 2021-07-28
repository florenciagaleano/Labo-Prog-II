using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class DAO
    {
        private static string cadenaConexion = "Server = .;Database = 20210708-SP; Trusted_Connection = true;";

        public void Guardar(Paciente paciente)
        {
            SqlConnection conexion = null;
            try
            {
                conexion = new SqlConnection(cadenaConexion);

                SqlCommand c = new SqlCommand();
                c.Connection = conexion;
                c.CommandType = System.Data.CommandType.Text;

                conexion.Open();

                c.CommandText = "INSERT INTO Pacientes (turno,nombre,apellido) VALUES (@turno,@nombre,@apellido)";
                c.Parameters.AddWithValue("@turno",paciente.Turno);
                c.Parameters.AddWithValue("@nombre", paciente.Nombre);
                c.Parameters.AddWithValue("@apellido", paciente.Apellido);

                c.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<Paciente> Leer()
        {
            List<Paciente> pacientes = new List<Paciente>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
                {
                    sqlConnection.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = sqlConnection;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT turno,nombre,apellido FROM dbo.Pacientes";

                    SqlDataReader dataReader = comando.ExecuteReader();

                    while (dataReader.Read() != false)
                    {
                        Paciente ret = new Paciente();
                        ret.Turno = (int)dataReader[0];
                        ret.Nombre = dataReader[1].ToString();
                        ret.Apellido = dataReader[2].ToString();

                        pacientes.Add(ret);
                    }

                    dataReader.Close();

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

            return pacientes;
        }

    }
}
