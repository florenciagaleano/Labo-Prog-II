using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades;
using System.Windows.Forms;
using Archivos;

namespace Views
{
    public partial class FrmLlamador : Form
    {
        private List<Paciente> lista = new List<Paciente>();
        private SimuladorDeAtencion<Paciente> simulador;
        public FrmLlamador(List<Paciente> pacientes)
        {
            InitializeComponent();
            this.lista = pacientes;
            this.simulador = new SimuladorDeAtencion<Paciente>();
            this.simulador.AvisoDeUso += InfoPaciente;
            this.simulador.FinDeUso += this.FinAtencion;

            Thread hilo = new Thread(this.simulador.SimularVacunacion);
            hilo.Start(pacientes);
        }

        private void FrmLlamador_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public void InfoPaciente(object paciente)
        {
            if (this.InvokeRequired)
            {
                SimuladoDelegate<Paciente> d = new SimuladoDelegate<Paciente>(InfoPaciente);
                this.Invoke(d, new object[] { paciente });
            }
            else
            {
                Paciente p = (Paciente)paciente;
                this.lblTurno.Text = p.Turno.ToString();
                this.lblInfoAdjunta.Text = p.ToString();
            }
        }

        private void FinAtencion(string str)
        {
            MessageBox.Show("Fin :)");
        }
    }
}
