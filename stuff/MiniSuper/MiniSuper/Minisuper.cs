using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper
{
    public static class Minisuper
    {
        private static Usuario[] usuarios;

        static Minisuper()
        {
            usuarios = new Usuario[0];
        }
        public static Usuario[] GetUsuarios()
        {
            return usuarios;
        }

        public static bool AgregarUsuario(Usuario user)
        {
            foreach (Usuario item in usuarios)
            {
                if(user == item)
                {
                    return false;//no se cargo pq ya essta cargado
                }
            }

            //usuarios += user;
            Array.Resize<Usuario>(ref usuarios, usuarios.Length + 1);
            usuarios[usuarios.Length - 1] = user;
            return true;
        }

    }
}
