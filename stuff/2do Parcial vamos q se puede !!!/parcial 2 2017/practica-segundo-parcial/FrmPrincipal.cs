using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using System.Threading;

namespace practica_segundo_parcial
{
    public partial class FrmPrincipal : Form
    {
        private LosHilos hilos;
        public FrmPrincipal()
        {
            InitializeComponent();
            this.hilos = new LosHilos();
            hilos.AvisoFin += MostrarMensajeFin;
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                hilos += 1;
            }
            catch(CantidadInvalidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MostrarMensajeFin(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hilos.Bitacora);
        }
    }
}
