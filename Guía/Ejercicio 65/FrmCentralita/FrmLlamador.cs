using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CentralitaHerencia;

namespace FrmCentralita
{
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;
        public FrmLlamador(Centralita c)
        {
            InitializeComponent();
            this.centralita = c;
        }

        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }

        private void CargarNumero(string digito)
        {
            if(this.txt_nroDestino.Text == "Nro Destino")
            {
                this.txt_nroDestino.Text = string.Empty;
            }

            this.txt_nroDestino.Text += digito;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CargarNumero("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CargarNumero("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.CargarNumero("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.CargarNumero("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.CargarNumero("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.CargarNumero("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.CargarNumero("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.CargarNumero("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.CargarNumero("9");
        }

        private void buttonAsterisco_Click(object sender, EventArgs e)
        {
            this.CargarNumero("*");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.CargarNumero("0");
        }

        private void buttonNumeral_Click(object sender, EventArgs e)
        {
            this.CargarNumero("#");
        }

        private void btn_llamar_Click(object sender, EventArgs e)
        {
            Random duracion = new Random();
            Random costo = new Random();
            int d = duracion.Next(1, 50);
            Llamada llamada;
            //float c = (float)costo.NextDouble() * 10;

            if (this.txt_nroDestino.Text[0] == '#')
            {
                llamada = new Provincial(this.txt_nroOrigen.Text, (Provincial.Franja)this.cmb_franja.SelectedItem, (float)d, this.txt_nroDestino.Text);
            }
            else
            {
                Thread.Sleep(2000);
                float c = (float)costo.Next(1, 100);
                llamada = new Local(this.txt_nroOrigen.Text, (float)d, this.txt_nroDestino.Text, (float)c);
            }
            
            try
            {
                this.centralita += llamada;
            }catch(CentralitaException ex)
            {
                MessageBox.Show(ex.Message,"Llamada repetida",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }catch(FalloLogException ex)
            {
                MessageBox.Show(ex.Message, "No se pudo guardar la lamada en archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*if (this.cmb_franja.Enabled = true)
            {
                // Carga
                cmb_franja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
                // Lectura
                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(cmb_franja.SelectedValue.ToString(), out franjas);
            }*/
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.txt_nroDestino.Text = "Nro Destino";
            this.txt_nroOrigen.Text = "Nro Origen";
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.cmb_franja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.cmb_franja.Enabled = false;
        }

        private void txt_nroDestino_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_nroDestino.Text.IndexOf('#') == 0)
            {
                this.cmb_franja.Enabled = true;
            }
            else
            {
                this.cmb_franja.Enabled = false;
            }
        }

        private void txt_nroOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
           // this.txt_nroDestino = string.Empty;
            if(Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }else if(Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;//no se escribieron numeros
                MessageBox.Show("Solo numeros","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
        }
    }
}
