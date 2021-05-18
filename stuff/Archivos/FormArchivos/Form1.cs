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

namespace FormArchivos
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Prueba.txt";
                //string ruta = ".";
                Archivador a = new Archivador(ruta);
                a.Guardar(this.textBox1.Text);
            }catch(UnauthorizedAccessException)
            {
                MessageBox.Show("No tiene permisos");
            }catch(Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Prueba.txt";
                //string ruta = ".";
                Archivador a = new Archivador(ruta);
                //a.Guardar(this.textBox1.Text);
                this.textBox1.Text = a.Leer();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No tiene permisos");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Prueba.xml";
                Persona p = new Persona(this.richTextBox1.Text,this.textBox2.Text);
                SerializadorXML<Persona> a = new SerializadorXML<Persona>(ruta);
                a.Guardar(p);
                //this.textBox1.Text = a.Leer();

                MessageBox.Show("Guardado!!");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Prueba.xml";
                //Persona p = SerializadorXML<Persona>.
                SerializadorXML<Persona> a = new SerializadorXML<Persona>(ruta);
                Persona p = a.Leer();
                //this.textBox1.Text = a.Leer();
                this.richTextBox2.Text = p.ToString();

                //MessageBox.Show("Guardado!!");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void SerializarAXml()
        {
            if(radioButton1.Checked)
            {
                this.button1();
            }
        }

        private void DeserializarAXml()
        {

        }
    }
}
