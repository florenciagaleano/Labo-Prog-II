using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlesUsuario;
using Entidades;

namespace FormCantina
{
    public partial class FrmCantina : Form
    {
        public FrmCantina()
        {
            InitializeComponent();
        }

        private void FrmCantina_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out
           tipo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(this.optAgua.Checked == true)
            {
                barra1.AgregarBotella(new Agua((int)this.undCapacidad.Value, this.txtMarca.Text,(int) this.undContenido.Value));
            }else
            {
                barra1.AgregarBotella(new Cerveza((int)this.undCapacidad.Value, this.txtMarca.Text, (int)this.undContenido.Value));
            }
        }
    }
}
