
namespace MiniSuper
{
    partial class FrmAltaUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.nro_dni = new System.Windows.Forms.NumericUpDown();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lbl_formaDePago = new System.Windows.Forms.Label();
            this.chk_efectivo = new System.Windows.Forms.CheckBox();
            this.chk_tarjeta = new System.Windows.Forms.CheckBox();
            this.chk_app = new System.Windows.Forms.CheckBox();
            this.panel_formasPago = new System.Windows.Forms.Panel();
            this.groupBox_medioDePago = new System.Windows.Forms.GroupBox();
            this.opt_aplicacion = new System.Windows.Forms.RadioButton();
            this.opt_tarjeta = new System.Windows.Forms.RadioButton();
            this.opt_efectivo = new System.Windows.Forms.RadioButton();
            this.lbl_provincia = new System.Windows.Forms.Label();
            this.cmb_provincia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nro_dni)).BeginInit();
            this.panel_formasPago.SuspendLayout();
            this.groupBox_medioDePago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(22, 17);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(22, 40);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 1;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(22, 63);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(26, 13);
            this.lbl_dni.TabIndex = 2;
            this.lbl_dni.Text = "DNI";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(83, 13);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(134, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // txt_apellido
            // 
            this.txt_apellido.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.txt_apellido.Location = new System.Drawing.Point(83, 36);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(134, 20);
            this.txt_apellido.TabIndex = 4;
            // 
            // nro_dni
            // 
            this.nro_dni.Location = new System.Drawing.Point(83, 63);
            this.nro_dni.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nro_dni.Name = "nro_dni";
            this.nro_dni.Size = new System.Drawing.Size(134, 20);
            this.nro_dni.TabIndex = 5;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Enabled = false;
            this.btn_aceptar.Location = new System.Drawing.Point(119, 324);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(134, 23);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.Text = "&Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lbl_formaDePago
            // 
            this.lbl_formaDePago.AutoSize = true;
            this.lbl_formaDePago.Location = new System.Drawing.Point(22, 102);
            this.lbl_formaDePago.Name = "lbl_formaDePago";
            this.lbl_formaDePago.Size = new System.Drawing.Size(81, 13);
            this.lbl_formaDePago.TabIndex = 7;
            this.lbl_formaDePago.Text = "Forma de pago:";
            // 
            // chk_efectivo
            // 
            this.chk_efectivo.AutoSize = true;
            this.chk_efectivo.Location = new System.Drawing.Point(30, 4);
            this.chk_efectivo.Name = "chk_efectivo";
            this.chk_efectivo.Size = new System.Drawing.Size(65, 17);
            this.chk_efectivo.TabIndex = 8;
            this.chk_efectivo.Text = "Efectivo";
            this.chk_efectivo.UseVisualStyleBackColor = true;
            this.chk_efectivo.CheckStateChanged += new System.EventHandler(this.chk_efectivo_CheckStateChanged);
            // 
            // chk_tarjeta
            // 
            this.chk_tarjeta.AutoSize = true;
            this.chk_tarjeta.Location = new System.Drawing.Point(130, 4);
            this.chk_tarjeta.Name = "chk_tarjeta";
            this.chk_tarjeta.Size = new System.Drawing.Size(59, 17);
            this.chk_tarjeta.TabIndex = 9;
            this.chk_tarjeta.Text = "Tarjeta";
            this.chk_tarjeta.UseVisualStyleBackColor = true;
            // 
            // chk_app
            // 
            this.chk_app.AutoSize = true;
            this.chk_app.Location = new System.Drawing.Point(225, 4);
            this.chk_app.Name = "chk_app";
            this.chk_app.Size = new System.Drawing.Size(75, 17);
            this.chk_app.TabIndex = 10;
            this.chk_app.Text = "Aplicación";
            this.chk_app.UseVisualStyleBackColor = true;
            // 
            // panel_formasPago
            // 
            this.panel_formasPago.Controls.Add(this.chk_app);
            this.panel_formasPago.Controls.Add(this.chk_tarjeta);
            this.panel_formasPago.Controls.Add(this.chk_efectivo);
            this.panel_formasPago.Location = new System.Drawing.Point(28, 128);
            this.panel_formasPago.Name = "panel_formasPago";
            this.panel_formasPago.Size = new System.Drawing.Size(315, 52);
            this.panel_formasPago.TabIndex = 11;
            // 
            // groupBox_medioDePago
            // 
            this.groupBox_medioDePago.Controls.Add(this.opt_aplicacion);
            this.groupBox_medioDePago.Controls.Add(this.opt_tarjeta);
            this.groupBox_medioDePago.Controls.Add(this.opt_efectivo);
            this.groupBox_medioDePago.Location = new System.Drawing.Point(28, 210);
            this.groupBox_medioDePago.Name = "groupBox_medioDePago";
            this.groupBox_medioDePago.Size = new System.Drawing.Size(315, 52);
            this.groupBox_medioDePago.TabIndex = 12;
            this.groupBox_medioDePago.TabStop = false;
            this.groupBox_medioDePago.Text = "Medio de pago:";
            this.groupBox_medioDePago.Visible = false;
            // 
            // opt_aplicacion
            // 
            this.opt_aplicacion.AutoSize = true;
            this.opt_aplicacion.Location = new System.Drawing.Point(225, 20);
            this.opt_aplicacion.Name = "opt_aplicacion";
            this.opt_aplicacion.Size = new System.Drawing.Size(74, 17);
            this.opt_aplicacion.TabIndex = 2;
            this.opt_aplicacion.TabStop = true;
            this.opt_aplicacion.Text = "Aplicacion";
            this.opt_aplicacion.UseVisualStyleBackColor = true;
            // 
            // opt_tarjeta
            // 
            this.opt_tarjeta.AutoSize = true;
            this.opt_tarjeta.Location = new System.Drawing.Point(130, 19);
            this.opt_tarjeta.Name = "opt_tarjeta";
            this.opt_tarjeta.Size = new System.Drawing.Size(58, 17);
            this.opt_tarjeta.TabIndex = 1;
            this.opt_tarjeta.TabStop = true;
            this.opt_tarjeta.Text = "Tarjeta";
            this.opt_tarjeta.UseVisualStyleBackColor = true;
            // 
            // opt_efectivo
            // 
            this.opt_efectivo.AutoSize = true;
            this.opt_efectivo.Location = new System.Drawing.Point(30, 20);
            this.opt_efectivo.Name = "opt_efectivo";
            this.opt_efectivo.Size = new System.Drawing.Size(64, 17);
            this.opt_efectivo.TabIndex = 0;
            this.opt_efectivo.TabStop = true;
            this.opt_efectivo.Text = "Efectivo";
            this.opt_efectivo.UseVisualStyleBackColor = true;
            // 
            // lbl_provincia
            // 
            this.lbl_provincia.AutoSize = true;
            this.lbl_provincia.Location = new System.Drawing.Point(26, 282);
            this.lbl_provincia.Name = "lbl_provincia";
            this.lbl_provincia.Size = new System.Drawing.Size(51, 13);
            this.lbl_provincia.TabIndex = 13;
            this.lbl_provincia.Text = "Provincia";
            // 
            // cmb_provincia
            // 
            this.cmb_provincia.FormattingEnabled = true;
            this.cmb_provincia.Items.AddRange(new object[] {
            "CABA",
            "Buenos Aires",
            "Tierra del Fuego",
            "Catamarca",
            "Tucuman"});
            this.cmb_provincia.Location = new System.Drawing.Point(83, 279);
            this.cmb_provincia.Name = "cmb_provincia";
            this.cmb_provincia.Size = new System.Drawing.Size(121, 21);
            this.cmb_provincia.TabIndex = 14;
            this.cmb_provincia.SelectedIndexChanged += new System.EventHandler(this.cmb_provincia_SelectedIndexChanged);
            // 
            // FrmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 379);
            this.Controls.Add(this.cmb_provincia);
            this.Controls.Add(this.lbl_provincia);
            this.Controls.Add(this.groupBox_medioDePago);
            this.Controls.Add(this.panel_formasPago);
            this.Controls.Add(this.lbl_formaDePago);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.nro_dni);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "FrmAltaUsuario";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.nro_dni)).EndInit();
            this.panel_formasPago.ResumeLayout(false);
            this.panel_formasPago.PerformLayout();
            this.groupBox_medioDePago.ResumeLayout(false);
            this.groupBox_medioDePago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.NumericUpDown nro_dni;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label lbl_formaDePago;
        private System.Windows.Forms.CheckBox chk_efectivo;
        private System.Windows.Forms.CheckBox chk_tarjeta;
        private System.Windows.Forms.CheckBox chk_app;
        private System.Windows.Forms.Panel panel_formasPago;
        private System.Windows.Forms.GroupBox groupBox_medioDePago;
        private System.Windows.Forms.RadioButton opt_aplicacion;
        private System.Windows.Forms.RadioButton opt_tarjeta;
        private System.Windows.Forms.RadioButton opt_efectivo;
        private System.Windows.Forms.Label lbl_provincia;
        private System.Windows.Forms.ComboBox cmb_provincia;
    }
}