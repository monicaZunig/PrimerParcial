﻿namespace Ejercicios
{
    partial class Form1
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
            this.numerolabel1 = new System.Windows.Forms.Label();
            this.numerotextBox1 = new System.Windows.Forms.TextBox();
            this.Calculobutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numerolabel1
            // 
            this.numerolabel1.AutoSize = true;
            this.numerolabel1.Location = new System.Drawing.Point(66, 40);
            this.numerolabel1.Name = "numerolabel1";
            this.numerolabel1.Size = new System.Drawing.Size(95, 13);
            this.numerolabel1.TabIndex = 0;
            this.numerolabel1.Text = "Ingrese un numero";
            // 
            // numerotextBox1
            // 
            this.numerotextBox1.Location = new System.Drawing.Point(167, 37);
            this.numerotextBox1.Name = "numerotextBox1";
            this.numerotextBox1.Size = new System.Drawing.Size(100, 20);
            this.numerotextBox1.TabIndex = 1;
            // 
            // Calculobutton1
            // 
            this.Calculobutton1.BackColor = System.Drawing.Color.RosyBrown;
            this.Calculobutton1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculobutton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Calculobutton1.Location = new System.Drawing.Point(106, 74);
            this.Calculobutton1.Name = "Calculobutton1";
            this.Calculobutton1.Size = new System.Drawing.Size(132, 53);
            this.Calculobutton1.TabIndex = 2;
            this.Calculobutton1.Text = "Calculo";
            this.Calculobutton1.UseVisualStyleBackColor = false;
            this.Calculobutton1.Click += new System.EventHandler(this.Calculobutton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(344, 173);
            this.Controls.Add(this.Calculobutton1);
            this.Controls.Add(this.numerotextBox1);
            this.Controls.Add(this.numerolabel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numerolabel1;
        private System.Windows.Forms.TextBox numerotextBox1;
        private System.Windows.Forms.Button Calculobutton1;
    }
}

