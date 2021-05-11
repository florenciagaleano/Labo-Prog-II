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
    public partial class FrmTest : Form
    {
        private Vendedor vendedor;
        public FrmTest()
        {
            InitializeComponent();
            this.vendedor = new Vendedor("Flor ♥");
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            this.lstStock.Items.Add(p1);//p1.ToString()
            this.lstStock.Items.Add(p2);
            this.lstStock.Items.Add(p3);
            this.lstStock.Items.Add(p4);
            this.lstStock.Items.Add(p5);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //this.close();
            if(MessageBox.Show("Esta seguro de que desea salir?","WARNING", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void FrmTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro de que desea salir?", "SALIR", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Publicacion p = (Publicacion)this.lstStock.SelectedItem;

            if (p is null)
            {
                MessageBox.Show("Debe elegir una publicacion", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                //this.lstStock.SelectedItem;

                if (vendedor + p)
                {
                    MessageBox.Show("Se realizo la venta con exito!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la venta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          
        }

        private void btnVerInform_Click(object sender, EventArgs e)
        {
            this.rtbInforme.Text = Vendedor.InformeDeVentas(this.vendedor);
        }
    }
}
