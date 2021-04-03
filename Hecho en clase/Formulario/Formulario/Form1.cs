using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola mundo!","Prueba",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Hand);
            /*if(MessageBox.Show("Desea cerrar el Form?", "Cierre", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }*/

            MessageBox.Show("El texto que ingreso es: " + txtBox.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta re seguro de cerrar?", "Seguro ????", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
