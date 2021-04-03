using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSuper
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
            //Application.Run(new FrmAltaUsuario());

            /*MEDIO DE PAGO RADIOBUTTON SOLO APARECEN SI CLICKEO EFECTIVO
             DE CHECKLSIST solo para probar*/

            /*el Aceptar lo habilito despues de q el user eligio pcia
             solo para probar tmbn*/
        }
    }
}
