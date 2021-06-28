using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_68
{
    public partial class FormPersona : Form
    {
        private Persona persona;
        public FormPersona()
        {
            InitializeComponent();
        }

        public static void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(this.persona is null)
            {
                //this.persona = new Persona();
                //persona.EventoString += NotificarCambio;
                ////persona.Nombre = this.txtNombre.Text;
                ////persona.Apellido = this.txtApellido.Text;
                this.persona = new Persona();
                this.btnCrear.Text = "Actualizar";
            }
            persona.EventoString += NotificarCambio;
            this.persona.Nombre = this.txtNombre.Text;
            this.persona.Apellido = this.txtApellido.Text;
            
        }

        
    }
}
