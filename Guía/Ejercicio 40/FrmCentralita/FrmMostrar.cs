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
    public partial class FrmMostrar : Form
    {
        private Centralita centralita;
        private Llamada.TipoLlamada tipoLlamada;
        public FrmMostrar(Llamada.TipoLlamada l)
        {
            InitializeComponent();
            this.tipoLlamada = l;
        }

        public Centralita Centralita
        {
            set
            {
                this.centralita = value;
            }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            foreach (Llamada item in this.centralita.Llamadas)
            {
                if(item is Local && this.tipoLlamada == Llamada.TipoLlamada.Local)
                {
                    this.richTxt_mostrar.Text += item.ToString();
                }else if(item is Provincial && this.tipoLlamada == Llamada.TipoLlamada.Provincial)
                {
                    this.richTxt_mostrar.Text += item.ToString();
                }else if(this.tipoLlamada == Llamada.TipoLlamada.Todas)
                {
                    this.richTxt_mostrar.Text += item.ToString();
                }
            }

            if (this.tipoLlamada == Llamada.TipoLlamada.Todas)
            {
                this.richTxt_mostrar.Text += $"Ganancia por todas las llamadas {this.centralita.GananciaPorTotal}";
            }
            else if (this.tipoLlamada == Llamada.TipoLlamada.Local)
            {
                this.richTxt_mostrar.Text += $"Ganancia por llamadas Locales {this.centralita.GananciaPorLocal}";
            }
            else
            {
                this.richTxt_mostrar.Text += $"Ganancia por llamadas Provinciales {this.centralita.GananciaPorProvincial}";
            }
        }
    }
}
