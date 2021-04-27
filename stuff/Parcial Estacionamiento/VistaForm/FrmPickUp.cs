using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Vehiculos;

namespace VistaForm
{
    public partial class FormPickUp : Form
    {
        public FormPickUp()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            PickUp pu = new PickUp(this.txtPatente.Text, this.txtModelo.Text);
            MessageBox.Show(pu.ImprimirTicket(), "PickUp", MessageBoxButtons.OK);
        }
    }
}
