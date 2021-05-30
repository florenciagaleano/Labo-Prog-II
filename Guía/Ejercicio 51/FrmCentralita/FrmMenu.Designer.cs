
namespace FrmCentralita
{
    partial class FrmMenu
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
            this.btn_generarLlamada = new System.Windows.Forms.Button();
            this.btn_facturacionTotal = new System.Windows.Forms.Button();
            this.btn_facturacionLocal = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_generarLlamada
            // 
            this.btn_generarLlamada.Location = new System.Drawing.Point(12, 12);
            this.btn_generarLlamada.Name = "btn_generarLlamada";
            this.btn_generarLlamada.Size = new System.Drawing.Size(164, 23);
            this.btn_generarLlamada.TabIndex = 0;
            this.btn_generarLlamada.Text = "Generar llamada";
            this.btn_generarLlamada.UseVisualStyleBackColor = true;
            this.btn_generarLlamada.Click += new System.EventHandler(this.btn_generarLlamada_Click);
            // 
            // btn_facturacionTotal
            // 
            this.btn_facturacionTotal.Location = new System.Drawing.Point(12, 70);
            this.btn_facturacionTotal.Name = "btn_facturacionTotal";
            this.btn_facturacionTotal.Size = new System.Drawing.Size(164, 23);
            this.btn_facturacionTotal.TabIndex = 7;
            this.btn_facturacionTotal.Text = "Facturación Local";
            this.btn_facturacionTotal.Click += new System.EventHandler(this.btn_facturacionTotal_Click);
            // 
            // btn_facturacionLocal
            // 
            this.btn_facturacionLocal.Location = new System.Drawing.Point(12, 41);
            this.btn_facturacionLocal.Name = "btn_facturacionLocal";
            this.btn_facturacionLocal.Size = new System.Drawing.Size(164, 23);
            this.btn_facturacionLocal.TabIndex = 6;
            this.btn_facturacionLocal.Text = "Facturación Total";
            this.btn_facturacionLocal.Click += new System.EventHandler(this.btn_facturacionLocal_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(12, 128);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(164, 23);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Facturación Provincial";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 167);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_facturacionLocal);
            this.Controls.Add(this.btn_facturacionTotal);
            this.Controls.Add(this.btn_generarLlamada);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centralita";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_generarLlamada;
        private System.Windows.Forms.Button btn_facturacionTotal;
        private System.Windows.Forms.Button btn_facturacionLocal;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button button1;
    }
}

