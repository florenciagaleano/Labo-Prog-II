using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSuper
{
    public partial class FrmAltaUsuario : Form
    {
        private Usuario usuario;
        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //checkbox
            string[] formasPago = new string[0];

            foreach (Control miControl in this.panel_formasPago.Controls)
            {
                if(miControl is CheckBox && ((CheckBox)miControl).Checked )//checkbox esta tildado
                {
                    Array.Resize<string>(ref formasPago, formasPago.Length + 1);
                    formasPago[formasPago.Length - 1] = ((CheckBox)miControl).Text;
                }
            }

            //Radiobutton
            string formaDePago = String.Empty;
            foreach (Control item in this.groupBox_medioDePago.Controls)
            {
                if(item.Controls is RadioButton && ((RadioButton)item).Checked)
                {
                    formaDePago = item.Text;
                }
            }

            //Combobox (pcia)
            /*IMP: combobox te deja elegir una opcion de la lista desplegable o escribir vos lo que quieras
             asi que Selected item puede no ser nada porque el usuario escribio algo (creo)*/
            string pcia = String.Empty;
            if (this.cmb_provincia.SelectedIndex == -1)//significa que no eligieron ninguna de las opciones de la list
            {
                if (this.cmb_provincia.Text != String.Empty)//el usuario escribio algo
                {
                    pcia = this.cmb_provincia.Text;
                }
            }
            else
                pcia = this.cmb_provincia.SelectedItem.ToString();
            //si eligiera dropdown list(mismo control != Dropdown style) solo podria elegir una opcion pero no escribir


            this.usuario = new Usuario(this.txt_nombre.Text,this.txt_apellido.Text, (long)this.nro_dni.Value,formasPago,formaDePago,pcia);//el . value trae un decimal para que sea double

            //this.Close();
            this.DialogResult = DialogResult.OK;//aprete el boton y no cerre
        }

        private void chk_efectivo_CheckStateChanged(object sender, EventArgs e)
        {
            if(((CheckBox)sender).Checked)
            {
                this.groupBox_medioDePago.Visible = true;//muestro los radio buttons
            }else
            {
                this.groupBox_medioDePago.Visible = false;
                //sin este else con que tilde efectivo na sola vez ya no me desaparecen los rb
            }
        }

        private void cmb_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //habilito el aceptar
            this.btn_aceptar.Enabled = true;
            //la cosa es que si escribo algo yo no se habilita pero despues lo cambio
            //CHEQUEAR
        }

        public Usuario GetUsuario()
        {
            return this.usuario;
        }
    }
}
