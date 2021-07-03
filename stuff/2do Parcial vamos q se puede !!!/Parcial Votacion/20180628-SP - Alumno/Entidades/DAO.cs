using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Entidades
{
    public class DAO : IArchivos<Votacion>
    {
        public bool Guardar(string rutaArchivo, Votacion objeto)
        {
            bool ret = false;
            SqlConnection conexion = null;

            try
            {
                conexion = new SqlConnection(rutaArchivo);

                conexion.Open();
                //SqlCommand comando = new SqlCommand("INSERT INTO Votaciones(nombreLey,afirmativos,negativos,abstenciones,nombreAlumno) VALUES('{0}',{1},{2},{3},'florrrr')", conexion);

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;

                comando.CommandText = "INSERT INTO Votaciones (nombreLey,afirmativos,negativos,abstenciones,nombreAlumno) VALUES (@nombreLey,@afirmativos,@negativos,@abstenciones,@nombreAlumno)";
                comando.Parameters.AddWithValue("@nombreLey",objeto.NombreLey);
                comando.Parameters.AddWithValue("@afirmativos",objeto.ContadorAfirmativo.ToString());
                comando.Parameters.AddWithValue("@negativos", objeto.ContadorNegativo.ToString());
                comando.Parameters.AddWithValue("@abstenciones",objeto.ContadorAbstencion.ToString());
                comando.Parameters.AddWithValue("@nombreAlumno","flor");


                comando.ExecuteNonQuery();
                ret = true;
            }catch(Exception e)
            {
                throw new ErrorArchivoException(e);
            }
            finally
            {
                conexion.Close();
            }

            return ret;
        }

        public Votacion Leer(string rutaArchivo)
        {
            throw new NotImplementedException();
        }
    }
}
