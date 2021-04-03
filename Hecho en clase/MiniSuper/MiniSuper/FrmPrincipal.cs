using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSuper
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmUsuario = new FrmAltaUsuario();
            //frmUsuario.Location = Location;
            //frmUsuario.ShowDialog();//showdialog en ez de show para que el usuario se agregue y vuelva al otro form despues de haber agregado al nuevo user
            //frmUsuario.GetUsuario();//lo estoy creando en el Aceptar

            if (frmUsuario.ShowDialog() == DialogResult.OK)
            {
                Minisuper.AgregarUsuario(frmUsuario.GetUsuario());
            }

            //cmb_usuarios = null; si lo ejecuto con esto me tira una excepcion PREGUNTAR
            cmb_usuarios.DataSource = Minisuper.GetUsuarios();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //onda alert
            if (MessageBox.Show("Esta seguro de que desea salir sin calificarnos?","cerrando...",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }
    }
}
