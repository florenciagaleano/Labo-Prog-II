using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaConversor;

namespace FrmConversor
{
    public partial class frmConversorNumero : Form
    {
        public frmConversorNumero()
        {
            InitializeComponent();
        }

        private void btn_binADec_Click(object sender, EventArgs e)//faltaria validar que se ingresen 0 y 1 ....
        {
            string aux = this.txt_binToDec.Text;
            this.txt_resBinToDec.Text = (Conversor.BinarioDecimal(aux)).ToString();
        }

        private void btn_resDecToBin_Click(object sender, EventArgs e)
        {
            int aux;
            int.TryParse(this.txt_decToBin.Text, out aux);
            this.txt_resDecToBin.Text = Conversor.DecimalBinario( (double) aux);//quedo medio croto revisar
        }
    }
}
