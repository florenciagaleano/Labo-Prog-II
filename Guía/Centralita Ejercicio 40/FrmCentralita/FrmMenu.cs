using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CentralitaHerencia;

namespace FrmCentralita
{
    public partial class FrmMenu : Form
    {
        private FrmLlamador llamador;
        private FrmMostrar frmMostrar;
        //protected Centralita centralita;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btn_generarLlamada_Click(object sender, EventArgs e)
        {
            this.llamador= new FrmLlamador(new Centralita("Mi centralita"));
            this.llamador.ShowDialog();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_facturacionLocal_Click(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar(Llamada.TipoLlamada.Todas);
            frmMostrar.Centralita = llamador.Centralita;
            frmMostrar.ShowDialog();
        }

        private void btn_facturacionTotal_Click(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar(Llamada.TipoLlamada.Local);
            frmMostrar.Centralita = llamador.Centralita;
            frmMostrar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar(Llamada.TipoLlamada.Provincial);
            frmMostrar.Centralita = llamador.Centralita;
            frmMostrar.ShowDialog();
        }
    }
}
