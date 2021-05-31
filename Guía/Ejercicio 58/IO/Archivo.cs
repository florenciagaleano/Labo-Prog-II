using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public abstract class Archivo
    {
        public virtual bool ValidarArchivo(string ruta, bool validaExistencica)
        {
            if(File.Exists(ruta) && validaExistencica)
            {
                return true;
            }else
            {
                throw new FileNotFoundException();
            }
            
        }
    }
}
