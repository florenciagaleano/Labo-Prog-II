﻿
namespace Formulario
{
    partial class Form2
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
            this.btn_abrirForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_abrirForm
            // 
            this.btn_abrirForm.Location = new System.Drawing.Point(286, 22);
            this.btn_abrirForm.Name = "btn_abrirForm";
            this.btn_abrirForm.Size = new System.Drawing.Size(222, 93);
            this.btn_abrirForm.TabIndex = 0;
            this.btn_abrirForm.Text = "Abrir formulario";
            this.btn_abrirForm.UseVisualStyleBackColor = true;
            this.btn_abrirForm.Click += new System.EventHandler(this.btn_abrirForm_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_abrirForm);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_abrirForm;
    }
}