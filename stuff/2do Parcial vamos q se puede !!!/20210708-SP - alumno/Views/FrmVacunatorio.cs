using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Archivos;
using Entidades;

namespace Views
{
    public partial class FrmVacunatorio : Form
    {
        private CentroDeVacunacion centro;
        public FrmVacunatorio()
        {
            InitializeComponent();
            this.centro = new CentroDeVacunacion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de que desea salir?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        //no anda
        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog aux = new OpenFileDialog();
                if (aux.ShowDialog() == DialogResult.OK)
                {
                    string path = aux.FileName;
                    this.centro = new Xml<CentroDeVacunacion>().Leer(path);
                    FrmLlamador frm = new FrmLlamador(this.centro.Personas);
                    frm.Show();
                }
            }
            catch (ArchivoInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBaseDeDatos_Click(object sender, EventArgs e)
        {
            this.centro.Personas = DAO.Leer();//lee ok no lo puedo creer
            FrmLlamador frm = new FrmLlamador(this.centro.Personas);
            frm.Show();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            OpenFileDialog aux = new OpenFileDialog();
            if (aux.ShowDialog() == DialogResult.OK)
            {
                string path = aux.FileName;
                this.centro = new Binario<CentroDeVacunacion>().Leer(path);
                FrmLlamador frm = new FrmLlamador(this.centro.Personas);
                frm.Show();
            }
        }

        private void FrmVacunatorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Texto txt = new Texto();
            StringBuilder sb = new StringBuilder();
            foreach (Paciente item in this.centro.Personas)
            {
                sb.AppendLine(item.ToString());
            }

            txt.Guardar("Pacientes", sb.ToString());//los guardo en un txt

            if (MessageBox.Show("Esta seguro de que desea salir?", "SALIR", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
