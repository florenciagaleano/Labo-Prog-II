using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class FrmContador : Form
    {
        public FrmContador()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            /*string texto = richTxt_texto.Text;
            Contador contador = new Contador();

            MessageBox.Show(contador.Mostrar());
            fijarme pq esto no me anda ¿?¿?¿*/
            string texto = richTxt_texto.Text;
            Contador c1 = new Contador();
            c1.ContarPalabras(texto);

            string mensaje = c1.Mostrar();
            MessageBox.Show(mensaje);
        }
    }
}
