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
            vendedor = new Vendedor("Flor♥");
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            this.lstStock.Items.Add(p1.ToString());
            this.lstStock.Items.Add(p2.ToString());
            this.lstStock.Items.Add(p3.ToString());
            this.lstStock.Items.Add(p4.ToString());
            this.lstStock.Items.Add(p5.ToString());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
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
           if(this.lstStock.SelectedItem is null)
            {
                MessageBox.Show("Debe elegir una publicacion", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
               string nombre = this.lstStock.SelectedItem.ToString();
                Publicacion p = (Publicacion)lstStock.SelectedItem ;
                //primeros 3 son biografias
                if (this.lstStock.SelectedIndex == 0 || this.lstStock.SelectedIndex == 1 || this.lstStock.SelectedIndex == 2)
                {
                    p = new Biografia(nombre, 8, 153);
                }
                else
                {
                    p = new Comic(nombre, true, 15, 254);
                }

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
            this.rtbInforme.Text = Vendedor.InformeDeVentas(vendedor);
        }
    }
}
