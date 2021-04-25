using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace Form_Equipo
{
    public partial class frmDT : Form
    {
        private DirectorTecnico directorTecnino;

        public frmDT()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.directorTecnino = new DirectorTecnico(this.txtNombre.Text,
                                                  this.txtApellido.Text,
                                                  (int)this.nudEdad.Value,
                                                  (int)this.nudDNI.Value,
                                                  (int)this.nudExperiencia.Value);
            MessageBox.Show("Se agrego al director tecnico!!","EXITO",MessageBoxButtons.OK);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(directorTecnino is null)
            {
                MessageBox.Show("Aun no se creo un director técnico", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                if(directorTecnino.ValidarAptitud())
                {
                    MessageBox.Show("El DT es apto");
                }else
                {
                    MessageBox.Show("El DT no es apto");
                }
            }
        }
    }
}
