
namespace FormCantina
{
    partial class FrmCantina
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantina));
            this.barra1 = new ControlCantina.Barra();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.undContenido = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.optCerveza = new System.Windows.Forms.RadioButton();
            this.optAgua = new System.Windows.Forms.RadioButton();
            this.groupBoxBebidas = new System.Windows.Forms.GroupBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.undCapacidad = new System.Windows.Forms.NumericUpDown();
            this.lblBotellaTipo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.undContenido)).BeginInit();
            this.groupBoxBebidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.undCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(-1, -1);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(533, 360);
            this.barra1.TabIndex = 0;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(104, 367);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(107, 385);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // undContenido
            // 
            this.undContenido.Location = new System.Drawing.Point(246, 449);
            this.undContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.undContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.undContenido.Name = "undContenido";
            this.undContenido.Size = new System.Drawing.Size(120, 20);
            this.undContenido.TabIndex = 3;
            this.undContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(406, 428);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 28);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // optCerveza
            // 
            this.optCerveza.AutoSize = true;
            this.optCerveza.Checked = true;
            this.optCerveza.Location = new System.Drawing.Point(8, 1);
            this.optCerveza.Name = "optCerveza";
            this.optCerveza.Size = new System.Drawing.Size(64, 17);
            this.optCerveza.TabIndex = 6;
            this.optCerveza.TabStop = true;
            this.optCerveza.Text = "Cerveza";
            this.optCerveza.UseVisualStyleBackColor = true;
            // 
            // optAgua
            // 
            this.optAgua.AutoSize = true;
            this.optAgua.Location = new System.Drawing.Point(8, 26);
            this.optAgua.Name = "optAgua";
            this.optAgua.Size = new System.Drawing.Size(50, 17);
            this.optAgua.TabIndex = 7;
            this.optAgua.Text = "Agua";
            this.optAgua.UseVisualStyleBackColor = true;
            // 
            // groupBoxBebidas
            // 
            this.groupBoxBebidas.Controls.Add(this.optAgua);
            this.groupBoxBebidas.Controls.Add(this.optCerveza);
            this.groupBoxBebidas.Location = new System.Drawing.Point(4, 364);
            this.groupBoxBebidas.Name = "groupBoxBebidas";
            this.groupBoxBebidas.Size = new System.Drawing.Size(84, 67);
            this.groupBoxBebidas.TabIndex = 8;
            this.groupBoxBebidas.TabStop = false;
            this.groupBoxBebidas.Text = "groupBox1";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(104, 428);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 9;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(243, 428);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 10;
            this.lblContenido.Text = "Contenido";
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Items.AddRange(new object[] {
            "Vidrio",
            "Plastico"});
            this.cmbBotellaTipo.Location = new System.Drawing.Point(267, 386);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBotellaTipo.TabIndex = 11;
            // 
            // undCapacidad
            // 
            this.undCapacidad.Location = new System.Drawing.Point(107, 449);
            this.undCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.undCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.undCapacidad.Name = "undCapacidad";
            this.undCapacidad.Size = new System.Drawing.Size(120, 20);
            this.undCapacidad.TabIndex = 12;
            this.undCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblBotellaTipo
            // 
            this.lblBotellaTipo.AutoSize = true;
            this.lblBotellaTipo.Location = new System.Drawing.Point(264, 367);
            this.lblBotellaTipo.Name = "lblBotellaTipo";
            this.lblBotellaTipo.Size = new System.Drawing.Size(63, 13);
            this.lblBotellaTipo.TabIndex = 13;
            this.lblBotellaTipo.Text = "Botella Tipo";
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 498);
            this.Controls.Add(this.lblBotellaTipo);
            this.Controls.Add(this.undCapacidad);
            this.Controls.Add(this.cmbBotellaTipo);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.groupBoxBebidas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.undContenido);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.barra1);
            this.Name = "FrmCantina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCantina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.undContenido)).EndInit();
            this.groupBoxBebidas.ResumeLayout(false);
            this.groupBoxBebidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.undCapacidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlCantina.Barra barra1;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.NumericUpDown undContenido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton optCerveza;
        private System.Windows.Forms.RadioButton optAgua;
        private System.Windows.Forms.GroupBox groupBoxBebidas;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.NumericUpDown undCapacidad;
        private System.Windows.Forms.Label lblBotellaTipo;
    }
}

