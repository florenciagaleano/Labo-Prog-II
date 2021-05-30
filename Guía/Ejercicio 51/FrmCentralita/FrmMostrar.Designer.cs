
namespace FrmCentralita
{
    partial class FrmMostrar
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
            this.richTxt_mostrar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTxt_mostrar
            // 
            this.richTxt_mostrar.Location = new System.Drawing.Point(11, 12);
            this.richTxt_mostrar.Name = "richTxt_mostrar";
            this.richTxt_mostrar.Size = new System.Drawing.Size(279, 243);
            this.richTxt_mostrar.TabIndex = 0;
            this.richTxt_mostrar.Text = "";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 267);
            this.Controls.Add(this.richTxt_mostrar);
            this.Name = "FrmMostrar";
            this.Text = "Llamadas";
            this.Load += new System.EventHandler(this.FrmMostrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxt_mostrar;
    }
}