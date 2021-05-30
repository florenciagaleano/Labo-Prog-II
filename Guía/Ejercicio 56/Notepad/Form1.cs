using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Notepad : Form
    {
        private string ultimaRuta;
        public Notepad()
        {
            InitializeComponent();
            this.ultimaRuta = string.Empty;
            this.toolStripStatusLabel1.Text = string.Empty;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using(OpenFileDialog aux = new OpenFileDialog())
            {
                if(aux.ShowDialog() == DialogResult.OK)
                {
                    string ruta = aux.FileName;
                    using (StreamReader sr = new StreamReader(ruta))
                    {
                        this.richTextBox1.Text = sr.ReadToEnd();
                        this.ultimaRuta = ruta;
                    }
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.ultimaRuta != String.Empty && File.Exists(ultimaRuta))
            {
                using (StreamWriter sw = new StreamWriter(this.ultimaRuta))
                {
                    sw.Write(this.richTextBox1.Text);
                    //this.ultimaRuta = ruta;
                }
            }
            else
            {
                this.guardarComoCtrlMayusSToolStripMenuItem_Click(sender, e);
            }
        }

        private void guardarComoCtrlMayusSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog aux = new SaveFileDialog())
            {
                if(aux.ShowDialog() == DialogResult.OK)
                {
                    string ruta = aux.FileName;
                    using (StreamWriter sw = new StreamWriter(ruta))
                    {
                        sw.Write(this.richTextBox1.Text);
                        this.ultimaRuta = ruta;
                    }
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = this.richTextBox1.Text.Length.ToString() + " caracteres";
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
