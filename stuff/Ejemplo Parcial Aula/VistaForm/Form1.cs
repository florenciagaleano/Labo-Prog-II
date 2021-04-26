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

namespace VistaForm
{
    public partial class frmCurso : Form
    {
        private Curso c;

        public frmCurso()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(c is null)//se creo un curso
            {
                MessageBox.Show("Primero debes cargar un curso!", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Alumno a = new Alumno(this.txtNombre.Text, this.txtApellido.Text, this.txtDNI.Text, (short)this.nudAnioCurso.Value, (Division)this.cmbDvisionCurso.SelectedItem);
                c = c + a;
                MessageBox.Show("Alumno cargado");
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Profesor p = new Profesor(this.txtNombreProfe.Text, this.txtApellidoProfe.Text, this.txtDNIProfe.Text);
            this.c = new Curso((short)this.nudAnio.Value, (Division)this.cmbDivision.SelectedItem, p);

            MessageBox.Show("Curso creado","EXITO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void frmCurso_Load(object sender, EventArgs e)
        {
            this.cmbDvisionCurso.DataSource = Enum.GetValues(typeof(Division));
            this.cmbDivision.DataSource = Enum.GetValues(typeof(Division));
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (c is null)
            {
                MessageBox.Show("Primero debes cargar un curso!", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.rtbDatos.Text = (string)this.c;
            }
        }
    }
}
