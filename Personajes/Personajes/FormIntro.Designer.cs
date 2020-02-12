namespace Create
{
    partial class frmIntro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cbxInspiracion = new System.Windows.Forms.CheckBox();
            this.cbxVista = new System.Windows.Forms.CheckBox();
            this.cbxIntroduccion = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plResumen = new System.Windows.Forms.Panel();
            this.txtResumen = new System.Windows.Forms.RichTextBox();
            this.plVista = new System.Windows.Forms.Panel();
            this.txtVista = new System.Windows.Forms.RichTextBox();
            this.plInspiracion = new System.Windows.Forms.Panel();
            this.txtInspire = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.plResumen.SuspendLayout();
            this.plVista.SuspendLayout();
            this.plInspiracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.cbxInspiracion);
            this.panel1.Controls.Add(this.cbxVista);
            this.panel1.Controls.Add(this.cbxIntroduccion);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 98);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Secciones";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(3, 59);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(320, 30);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxInspiracion
            // 
            this.cbxInspiracion.AutoSize = true;
            this.cbxInspiracion.Location = new System.Drawing.Point(233, 25);
            this.cbxInspiracion.Name = "cbxInspiracion";
            this.cbxInspiracion.Size = new System.Drawing.Size(93, 17);
            this.cbxInspiracion.TabIndex = 2;
            this.cbxInspiracion.Text = "Inspirado en...";
            this.cbxInspiracion.UseVisualStyleBackColor = true;
            // 
            // cbxVista
            // 
            this.cbxVista.AutoSize = true;
            this.cbxVista.Location = new System.Drawing.Point(114, 25);
            this.cbxVista.Name = "cbxVista";
            this.cbxVista.Size = new System.Drawing.Size(94, 17);
            this.cbxVista.TabIndex = 1;
            this.cbxVista.Text = "Punto de vista";
            this.cbxVista.UseVisualStyleBackColor = true;
            // 
            // cbxIntroduccion
            // 
            this.cbxIntroduccion.AutoSize = true;
            this.cbxIntroduccion.Location = new System.Drawing.Point(8, 25);
            this.cbxIntroduccion.Name = "cbxIntroduccion";
            this.cbxIntroduccion.Size = new System.Drawing.Size(85, 17);
            this.cbxIntroduccion.TabIndex = 0;
            this.cbxIntroduccion.Text = "Introducción";
            this.cbxIntroduccion.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resumen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Punto de vista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inspirado en...";
            // 
            // plResumen
            // 
            this.plResumen.Controls.Add(this.txtResumen);
            this.plResumen.Controls.Add(this.label2);
            this.plResumen.Location = new System.Drawing.Point(390, 12);
            this.plResumen.Name = "plResumen";
            this.plResumen.Size = new System.Drawing.Size(327, 100);
            this.plResumen.TabIndex = 5;
            this.plResumen.Visible = false;
            // 
            // txtResumen
            // 
            this.txtResumen.Location = new System.Drawing.Point(3, 16);
            this.txtResumen.Name = "txtResumen";
            this.txtResumen.Size = new System.Drawing.Size(320, 70);
            this.txtResumen.TabIndex = 6;
            this.txtResumen.Text = "";
            // 
            // plVista
            // 
            this.plVista.Controls.Add(this.txtVista);
            this.plVista.Controls.Add(this.label3);
            this.plVista.Location = new System.Drawing.Point(390, 118);
            this.plVista.Name = "plVista";
            this.plVista.Size = new System.Drawing.Size(327, 100);
            this.plVista.TabIndex = 6;
            this.plVista.Visible = false;
            // 
            // txtVista
            // 
            this.txtVista.Location = new System.Drawing.Point(4, 16);
            this.txtVista.Name = "txtVista";
            this.txtVista.Size = new System.Drawing.Size(320, 70);
            this.txtVista.TabIndex = 3;
            this.txtVista.Text = "";
            // 
            // plInspiracion
            // 
            this.plInspiracion.Controls.Add(this.txtInspire);
            this.plInspiracion.Controls.Add(this.label4);
            this.plInspiracion.Location = new System.Drawing.Point(390, 224);
            this.plInspiracion.Name = "plInspiracion";
            this.plInspiracion.Size = new System.Drawing.Size(327, 100);
            this.plInspiracion.TabIndex = 7;
            this.plInspiracion.Visible = false;
            // 
            // txtInspire
            // 
            this.txtInspire.Location = new System.Drawing.Point(4, 16);
            this.txtInspire.Name = "txtInspire";
            this.txtInspire.Size = new System.Drawing.Size(320, 70);
            this.txtInspire.TabIndex = 4;
            this.txtInspire.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(320, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(15, 305);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(320, 23);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // frmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(730, 340);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.plInspiracion);
            this.Controls.Add(this.plVista);
            this.Controls.Add(this.plResumen);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmIntro";
            this.Text = "Introducción";
            this.Load += new System.EventHandler(this.frmIntro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plResumen.ResumeLayout(false);
            this.plResumen.PerformLayout();
            this.plVista.ResumeLayout(false);
            this.plVista.PerformLayout();
            this.plInspiracion.ResumeLayout(false);
            this.plInspiracion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.CheckBox cbxInspiracion;
        private System.Windows.Forms.CheckBox cbxVista;
        private System.Windows.Forms.CheckBox cbxIntroduccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel plResumen;
        private System.Windows.Forms.RichTextBox txtResumen;
        private System.Windows.Forms.Panel plVista;
        private System.Windows.Forms.RichTextBox txtVista;
        private System.Windows.Forms.Panel plInspiracion;
        private System.Windows.Forms.RichTextBox txtInspire;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRegresar;
    }
}

