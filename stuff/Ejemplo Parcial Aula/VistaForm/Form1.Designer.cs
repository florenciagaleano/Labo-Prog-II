
namespace VistaForm
{
    partial class frmCurso
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gpbDatosCurso = new System.Windows.Forms.GroupBox();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblDNIProfe = new System.Windows.Forms.Label();
            this.lblApellidoProfe = new System.Windows.Forms.Label();
            this.lblNombreProfe = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.txtDNIProfe = new System.Windows.Forms.TextBox();
            this.txtApellidoProfe = new System.Windows.Forms.TextBox();
            this.txtNombreProfe = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.gpbAlumno = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDivisionCurso = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblAnioCurso = new System.Windows.Forms.Label();
            this.nudAnioCurso = new System.Windows.Forms.NumericUpDown();
            this.cmbDvisionCurso = new System.Windows.Forms.ComboBox();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.gpbDatosCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.gpbAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(152, 240);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 29);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(16, 240);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(79, 29);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear curso";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(208, 240);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(85, 29);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // gpbDatosCurso
            // 
            this.gpbDatosCurso.Controls.Add(this.lblIngreso);
            this.gpbDatosCurso.Controls.Add(this.lblDNIProfe);
            this.gpbDatosCurso.Controls.Add(this.lblApellidoProfe);
            this.gpbDatosCurso.Controls.Add(this.lblNombreProfe);
            this.gpbDatosCurso.Controls.Add(this.lblDivision);
            this.gpbDatosCurso.Controls.Add(this.txtDNIProfe);
            this.gpbDatosCurso.Controls.Add(this.txtApellidoProfe);
            this.gpbDatosCurso.Controls.Add(this.txtNombreProfe);
            this.gpbDatosCurso.Controls.Add(this.lblAño);
            this.gpbDatosCurso.Controls.Add(this.nudAnio);
            this.gpbDatosCurso.Controls.Add(this.dtpFechaIngreso);
            this.gpbDatosCurso.Controls.Add(this.btnMostrar);
            this.gpbDatosCurso.Controls.Add(this.cmbDivision);
            this.gpbDatosCurso.Controls.Add(this.btnCrear);
            this.gpbDatosCurso.Location = new System.Drawing.Point(12, 12);
            this.gpbDatosCurso.Name = "gpbDatosCurso";
            this.gpbDatosCurso.Size = new System.Drawing.Size(312, 286);
            this.gpbDatosCurso.TabIndex = 25;
            this.gpbDatosCurso.TabStop = false;
            this.gpbDatosCurso.Text = "Datos Curso";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(13, 207);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblIngreso.TabIndex = 35;
            this.lblIngreso.Text = "Ingreso";
            // 
            // lblDNIProfe
            // 
            this.lblDNIProfe.AutoSize = true;
            this.lblDNIProfe.Location = new System.Drawing.Point(11, 172);
            this.lblDNIProfe.Name = "lblDNIProfe";
            this.lblDNIProfe.Size = new System.Drawing.Size(62, 13);
            this.lblDNIProfe.TabIndex = 34;
            this.lblDNIProfe.Text = "Documento";
            // 
            // lblApellidoProfe
            // 
            this.lblApellidoProfe.AutoSize = true;
            this.lblApellidoProfe.Location = new System.Drawing.Point(11, 138);
            this.lblApellidoProfe.Name = "lblApellidoProfe";
            this.lblApellidoProfe.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoProfe.TabIndex = 33;
            this.lblApellidoProfe.Text = "Apellido";
            // 
            // lblNombreProfe
            // 
            this.lblNombreProfe.AutoSize = true;
            this.lblNombreProfe.Location = new System.Drawing.Point(11, 100);
            this.lblNombreProfe.Name = "lblNombreProfe";
            this.lblNombreProfe.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProfe.TabIndex = 32;
            this.lblNombreProfe.Text = "Nombre";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(11, 65);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 31;
            this.lblDivision.Text = "Division";
            // 
            // txtDNIProfe
            // 
            this.txtDNIProfe.Location = new System.Drawing.Point(75, 169);
            this.txtDNIProfe.Name = "txtDNIProfe";
            this.txtDNIProfe.Size = new System.Drawing.Size(121, 20);
            this.txtDNIProfe.TabIndex = 30;
            // 
            // txtApellidoProfe
            // 
            this.txtApellidoProfe.Location = new System.Drawing.Point(75, 137);
            this.txtApellidoProfe.Name = "txtApellidoProfe";
            this.txtApellidoProfe.Size = new System.Drawing.Size(120, 20);
            this.txtApellidoProfe.TabIndex = 29;
            // 
            // txtNombreProfe
            // 
            this.txtNombreProfe.Location = new System.Drawing.Point(75, 102);
            this.txtNombreProfe.Name = "txtNombreProfe";
            this.txtNombreProfe.Size = new System.Drawing.Size(121, 20);
            this.txtNombreProfe.TabIndex = 28;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(11, 31);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 27;
            this.lblAño.Text = "Año";
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(76, 29);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(120, 20);
            this.nudAnio.TabIndex = 26;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(75, 201);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(218, 20);
            this.dtpFechaIngreso.TabIndex = 25;
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(75, 64);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(121, 21);
            this.cmbDivision.TabIndex = 24;
            // 
            // gpbAlumno
            // 
            this.gpbAlumno.Controls.Add(this.lblNombre);
            this.gpbAlumno.Controls.Add(this.lblDNI);
            this.gpbAlumno.Controls.Add(this.btnAgregar);
            this.gpbAlumno.Controls.Add(this.lblApellido);
            this.gpbAlumno.Controls.Add(this.lblDivisionCurso);
            this.gpbAlumno.Controls.Add(this.txtDNI);
            this.gpbAlumno.Controls.Add(this.txtApellido);
            this.gpbAlumno.Controls.Add(this.txtNombre);
            this.gpbAlumno.Controls.Add(this.lblAnioCurso);
            this.gpbAlumno.Controls.Add(this.nudAnioCurso);
            this.gpbAlumno.Controls.Add(this.cmbDvisionCurso);
            this.gpbAlumno.Location = new System.Drawing.Point(330, 12);
            this.gpbAlumno.Name = "gpbAlumno";
            this.gpbAlumno.Size = new System.Drawing.Size(247, 286);
            this.gpbAlumno.TabIndex = 26;
            this.gpbAlumno.TabStop = false;
            this.gpbAlumno.Text = "DatosAlumno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 34;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(11, 101);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(62, 13);
            this.lblDNI.TabIndex = 33;
            this.lblDNI.Text = "Documento";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(11, 65);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 32;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDivisionCurso
            // 
            this.lblDivisionCurso.AutoSize = true;
            this.lblDivisionCurso.Location = new System.Drawing.Point(11, 173);
            this.lblDivisionCurso.Name = "lblDivisionCurso";
            this.lblDivisionCurso.Size = new System.Drawing.Size(44, 13);
            this.lblDivisionCurso.TabIndex = 31;
            this.lblDivisionCurso.Text = "Division";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(87, 98);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(150, 20);
            this.txtDNI.TabIndex = 30;
            // 
            // txtApellido
            // 
            this.txtApellido.AcceptsReturn = true;
            this.txtApellido.Location = new System.Drawing.Point(87, 66);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(150, 20);
            this.txtApellido.TabIndex = 29;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 28;
            // 
            // lblAnioCurso
            // 
            this.lblAnioCurso.AutoSize = true;
            this.lblAnioCurso.Location = new System.Drawing.Point(11, 141);
            this.lblAnioCurso.Name = "lblAnioCurso";
            this.lblAnioCurso.Size = new System.Drawing.Size(26, 13);
            this.lblAnioCurso.TabIndex = 27;
            this.lblAnioCurso.Text = "Año";
            // 
            // nudAnioCurso
            // 
            this.nudAnioCurso.Location = new System.Drawing.Point(87, 139);
            this.nudAnioCurso.Name = "nudAnioCurso";
            this.nudAnioCurso.Size = new System.Drawing.Size(150, 20);
            this.nudAnioCurso.TabIndex = 26;
            // 
            // cmbDvisionCurso
            // 
            this.cmbDvisionCurso.FormattingEnabled = true;
            this.cmbDvisionCurso.Location = new System.Drawing.Point(87, 170);
            this.cmbDvisionCurso.Name = "cmbDvisionCurso";
            this.cmbDvisionCurso.Size = new System.Drawing.Size(150, 21);
            this.cmbDvisionCurso.TabIndex = 25;
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(12, 305);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(565, 132);
            this.rtbDatos.TabIndex = 27;
            this.rtbDatos.Text = "";
            //this.rtbDatos.TextChanged += new System.EventHandler(this.rtbDatos_TextChanged);
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 439);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.gpbAlumno);
            this.Controls.Add(this.gpbDatosCurso);
            this.Name = "frmCurso";
            this.Text = "Vista curso";
            this.Load += new System.EventHandler(this.frmCurso_Load);
            this.gpbDatosCurso.ResumeLayout(false);
            this.gpbDatosCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.gpbAlumno.ResumeLayout(false);
            this.gpbAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox gpbDatosCurso;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblDNIProfe;
        private System.Windows.Forms.Label lblApellidoProfe;
        private System.Windows.Forms.Label lblNombreProfe;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.TextBox txtDNIProfe;
        private System.Windows.Forms.TextBox txtApellidoProfe;
        private System.Windows.Forms.TextBox txtNombreProfe;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.GroupBox gpbAlumno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDivisionCurso;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblAnioCurso;
        private System.Windows.Forms.NumericUpDown nudAnioCurso;
        private System.Windows.Forms.ComboBox cmbDvisionCurso;
        private System.Windows.Forms.RichTextBox rtbDatos;
    }
}

