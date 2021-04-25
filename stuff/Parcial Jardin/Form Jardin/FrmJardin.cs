using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Biblioteca_de_claess;

namespace Form_Jardin
{
    public partial class FrmJardin : Form
    {
        private Jardin jardin;
        public FrmJardin()
        {
            InitializeComponent();
        }

        private void FrmJardin_Load(object sender, EventArgs e)
        {
   //         Reemplazar el Console.WriteLine
   //por un Message Box con ícono de error y sólo el botón OK
            this.jardin = new Jardin(100);
            bool pudo = this.jardin + new Arbusto("Arbusto 1", 10);
            pudo = this.jardin + new Arbusto("Arbusto 2", 15);
            pudo = this.jardin + new Rosal("Rosa 1", 20, Rosal.Color.Amarilla);
            pudo = this.jardin + new Rosal("Rosa clásica", 25);
            pudo = this.jardin + new Banano("Banano ecuador", 30, "ECU001");
            if (!(this.jardin + new Banano("No carga", 1, "ARG028")))
            {
                MessageBox.Show("Una planta no se pudo agregar :(","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            this.rtbSalidaDeTest.Text = jardin.ToString();
        }
    }
}
