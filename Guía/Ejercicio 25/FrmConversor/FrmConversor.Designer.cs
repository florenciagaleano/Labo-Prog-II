
namespace FrmConversor
{
    partial class frmConversorNumero
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
            this.lbl_binADec = new System.Windows.Forms.Label();
            this.lbl_decABin = new System.Windows.Forms.Label();
            this.btn_binADec = new System.Windows.Forms.Button();
            this.btn_resDecToBin = new System.Windows.Forms.Button();
            this.txt_binToDec = new System.Windows.Forms.TextBox();
            this.txt_decToBin = new System.Windows.Forms.TextBox();
            this.txt_resBinToDec = new System.Windows.Forms.TextBox();
            this.txt_resDecToBin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_binADec
            // 
            this.lbl_binADec.AutoSize = true;
            this.lbl_binADec.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_binADec.Location = new System.Drawing.Point(15, 19);
            this.lbl_binADec.Name = "lbl_binADec";
            this.lbl_binADec.Size = new System.Drawing.Size(121, 16);
            this.lbl_binADec.TabIndex = 0;
            this.lbl_binADec.Text = "Binario a Decimal";
            // 
            // lbl_decABin
            // 
            this.lbl_decABin.AutoSize = true;
            this.lbl_decABin.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_decABin.Location = new System.Drawing.Point(15, 44);
            this.lbl_decABin.Name = "lbl_decABin";
            this.lbl_decABin.Size = new System.Drawing.Size(121, 16);
            this.lbl_decABin.TabIndex = 1;
            this.lbl_decABin.Text = "Decimal a Binario";
            // 
            // btn_binADec
            // 
            this.btn_binADec.Location = new System.Drawing.Point(277, 12);
            this.btn_binADec.Name = "btn_binADec";
            this.btn_binADec.Size = new System.Drawing.Size(75, 23);
            this.btn_binADec.TabIndex = 4;
            this.btn_binADec.Text = "->";
            this.btn_binADec.UseVisualStyleBackColor = true;
            this.btn_binADec.Click += new System.EventHandler(this.btn_binADec_Click);
            // 
            // btn_resDecToBin
            // 
            this.btn_resDecToBin.Location = new System.Drawing.Point(277, 44);
            this.btn_resDecToBin.Name = "btn_resDecToBin";
            this.btn_resDecToBin.Size = new System.Drawing.Size(75, 23);
            this.btn_resDecToBin.TabIndex = 5;
            this.btn_resDecToBin.Text = "->";
            this.btn_resDecToBin.UseVisualStyleBackColor = true;
            this.btn_resDecToBin.Click += new System.EventHandler(this.btn_resDecToBin_Click);
            // 
            // txt_binToDec
            // 
            this.txt_binToDec.Location = new System.Drawing.Point(143, 14);
            this.txt_binToDec.Name = "txt_binToDec";
            this.txt_binToDec.Size = new System.Drawing.Size(128, 20);
            this.txt_binToDec.TabIndex = 6;
            // 
            // txt_decToBin
            // 
            this.txt_decToBin.Location = new System.Drawing.Point(143, 46);
            this.txt_decToBin.Name = "txt_decToBin";
            this.txt_decToBin.Size = new System.Drawing.Size(128, 20);
            this.txt_decToBin.TabIndex = 7;
            // 
            // txt_resBinToDec
            // 
            this.txt_resBinToDec.Location = new System.Drawing.Point(368, 15);
            this.txt_resBinToDec.Name = "txt_resBinToDec";
            this.txt_resBinToDec.Size = new System.Drawing.Size(118, 20);
            this.txt_resBinToDec.TabIndex = 8;
            // 
            // txt_resDecToBin
            // 
            this.txt_resDecToBin.Location = new System.Drawing.Point(368, 47);
            this.txt_resDecToBin.Name = "txt_resDecToBin";
            this.txt_resDecToBin.Size = new System.Drawing.Size(118, 20);
            this.txt_resDecToBin.TabIndex = 9;
            // 
            // frmConversorNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 77);
            this.Controls.Add(this.txt_resDecToBin);
            this.Controls.Add(this.txt_resBinToDec);
            this.Controls.Add(this.txt_decToBin);
            this.Controls.Add(this.txt_binToDec);
            this.Controls.Add(this.btn_resDecToBin);
            this.Controls.Add(this.btn_binADec);
            this.Controls.Add(this.lbl_decABin);
            this.Controls.Add(this.lbl_binADec);
            this.Name = "frmConversorNumero";
            this.Text = "Conversor Numérico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_binADec;
        private System.Windows.Forms.Label lbl_decABin;
        private System.Windows.Forms.Button btn_binADec;
        private System.Windows.Forms.Button btn_resDecToBin;
        private System.Windows.Forms.TextBox txt_binToDec;
        private System.Windows.Forms.TextBox txt_decToBin;
        private System.Windows.Forms.TextBox txt_resBinToDec;
        private System.Windows.Forms.TextBox txt_resDecToBin;
    }
}

