namespace Personajes
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
            this.btnIntroduccion = new System.Windows.Forms.Button();
            this.btnPersonaje = new System.Windows.Forms.Button();
            this.btnEscena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIntroduccion
            // 
            this.btnIntroduccion.Location = new System.Drawing.Point(37, 143);
            this.btnIntroduccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIntroduccion.Name = "btnIntroduccion";
            this.btnIntroduccion.Size = new System.Drawing.Size(130, 80);
            this.btnIntroduccion.TabIndex = 0;
            this.btnIntroduccion.Text = "Introducción";
            this.btnIntroduccion.UseVisualStyleBackColor = true;
            this.btnIntroduccion.Click += new System.EventHandler(this.btnIntroduccion_Click);
            // 
            // btnPersonaje
            // 
            this.btnPersonaje.Location = new System.Drawing.Point(235, 143);
            this.btnPersonaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPersonaje.Name = "btnPersonaje";
            this.btnPersonaje.Size = new System.Drawing.Size(130, 80);
            this.btnPersonaje.TabIndex = 1;
            this.btnPersonaje.Text = "Personaje";
            this.btnPersonaje.UseVisualStyleBackColor = true;
            this.btnPersonaje.Click += new System.EventHandler(this.btnPersonaje_Click);
            // 
            // btnEscena
            // 
            this.btnEscena.Location = new System.Drawing.Point(435, 143);
            this.btnEscena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEscena.Name = "btnEscena";
            this.btnEscena.Size = new System.Drawing.Size(130, 80);
            this.btnEscena.TabIndex = 2;
            this.btnEscena.Text = "Escena";
            this.btnEscena.UseVisualStyleBackColor = true;
            this.btnEscena.Click += new System.EventHandler(this.btnEscena_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnEscena);
            this.Controls.Add(this.btnPersonaje);
            this.Controls.Add(this.btnIntroduccion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIntroduccion;
        private System.Windows.Forms.Button btnPersonaje;
        private System.Windows.Forms.Button btnEscena;
    }
}