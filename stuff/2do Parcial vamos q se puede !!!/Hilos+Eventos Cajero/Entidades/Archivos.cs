using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class Archivos
    {
        public static bool Guardar(Persona p)
        {
            string texto = $"Se cobro a {p.Codigo} ${p.MontoTotal}";

            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Personas.txt";
                using (StreamWriter xw = new StreamWriter(path, true))
                {
                    xw.WriteLine(texto);
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
