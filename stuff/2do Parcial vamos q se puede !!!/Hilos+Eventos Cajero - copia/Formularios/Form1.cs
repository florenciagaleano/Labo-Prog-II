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

namespace Formularios
{
    public partial class Form1 : Form
    {
        Cajero cajero;
        public Form1()
        {
            InitializeComponent();
            this.cajero = new Cajero();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cajero.personas.Enqueue(Persona.HardcodearPersonas());
            Cajero.personas.Enqueue(Persona.HardcodearPersonas());
            Cajero.personas.Enqueue(Persona.HardcodearPersonas());
            Cajero.personas.Enqueue(Persona.HardcodearPersonas());
            Cajero.personas.Enqueue(Persona.HardcodearPersonas());

            foreach (Persona item in Cajero.personas)
            {
                this.listBox1.Items.Add(item);
            }

        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {

            Persona.InformaCajero -= Archivos.Guardar;//desasocio el evento
            Persona.InformaCajero -= Serializadora.Guardar;

            if (listBox1.SelectedItem != null)
            {
                Persona nuevaP = (Persona)this.listBox1.SelectedItem;
                nuevaP.InformaEstaddo += this.per_InformaEstado;
                Persona.InformaCajero += Archivos.Guardar;
                Persona.InformaCajero += Serializadora.Guardar;

                cajero.Cobrar(nuevaP, cajero);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cajero.CerarCajero();
        }

        private void per_InformaEstado(object sender, EventArgs e)
        {
            if(this.InvokeRequired)//si estamos en un hilo distinto al que se creo el control no lo vamos a poder utilizr entonces nos permite que si pasa eso y estamos en un hilo secundario se reinvoca al evento asocandolo a un delegado
            {
                Persona.DelegadoEstado d = new Persona.DelegadoEstado(per_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados(sender,e);
            }

            //invokerequired le pregunta al formulario si necesita ser invocado el hilo donde esta corriendo
            //validamos si estamos en hilo primario y secundario
        }

        private void ActualizarEstados(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            this.listBox3.Items.Clear();

            foreach (Persona item in Cajero.personas)
            {
                switch(item.Estado)
                {
                    case Persona.EEstado.Ingresado:
                        //item.Estado = Persona.EEstado.Cobrado;
                        this.listBox1.Items.Add(item);
                        break;
                    case Persona.EEstado.Cobrado:
                       // item.Estado = Persona.EEstado.Atendido;
                        this.listBox2.Items.Add(item);
                        break;
                    case Persona.EEstado.Atendido:
                       this.listBox3.Items.Add(item);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
