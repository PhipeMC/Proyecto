namespace Create
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
            this.btnIntroduccion.Location = new System.Drawing.Point(49, 176);
            this.btnIntroduccion.Name = "btnIntroduccion";
            this.btnIntroduccion.Size = new System.Drawing.Size(173, 99);
            this.btnIntroduccion.TabIndex = 0;
            this.btnIntroduccion.Text = "Introducción";
            this.btnIntroduccion.UseVisualStyleBackColor = true;
            this.btnIntroduccion.Click += new System.EventHandler(this.btnIntroduccion_Click);
            // 
            // btnPersonaje
            // 
            this.btnPersonaje.Location = new System.Drawing.Point(313, 176);
            this.btnPersonaje.Name = "btnPersonaje";
            this.btnPersonaje.Size = new System.Drawing.Size(173, 99);
            this.btnPersonaje.TabIndex = 1;
            this.btnPersonaje.Text = "Personaje";
            this.btnPersonaje.UseVisualStyleBackColor = true;
            this.btnPersonaje.Click += new System.EventHandler(this.btnPersonaje_Click);
            // 
            // btnEscena
            // 
            this.btnEscena.Location = new System.Drawing.Point(580, 176);
            this.btnEscena.Name = "btnEscena";
            this.btnEscena.Size = new System.Drawing.Size(173, 99);
            this.btnEscena.TabIndex = 2;
            this.btnEscena.Text = "Escena";
            this.btnEscena.UseVisualStyleBackColor = true;
            this.btnEscena.Click += new System.EventHandler(this.btnEscena_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEscena);
            this.Controls.Add(this.btnPersonaje);
            this.Controls.Add(this.btnIntroduccion);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIntroduccion;
        private System.Windows.Forms.Button btnPersonaje;
        private System.Windows.Forms.Button btnEscena;
    }
}