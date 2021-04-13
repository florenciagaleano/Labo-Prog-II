
namespace Ejercicio_28
{
    partial class FrmContador
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
            this.richTxt_texto = new System.Windows.Forms.RichTextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTxt_texto
            // 
            this.richTxt_texto.Location = new System.Drawing.Point(0, 0);
            this.richTxt_texto.Name = "richTxt_texto";
            this.richTxt_texto.Size = new System.Drawing.Size(493, 412);
            this.richTxt_texto.TabIndex = 0;
            this.richTxt_texto.Text = "";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(402, 376);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 1;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // FrmContador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 411);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.richTxt_texto);
            this.Name = "FrmContador";
            this.Text = "Contador de Palabras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxt_texto;
        private System.Windows.Forms.Button btn_calcular;
    }
}

