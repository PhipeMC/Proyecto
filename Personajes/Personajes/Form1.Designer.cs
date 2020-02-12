namespace Personajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sexuality = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_strong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_weak = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_spirituality = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fears = new System.Windows.Forms.TextBox();
            this.txt_jobs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pic_Img = new System.Windows.Forms.PictureBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del personaje";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(63, 42);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Edad";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(63, 68);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 20);
            this.txt_age.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sexualidad";
            // 
            // txt_sexuality
            // 
            this.txt_sexuality.Location = new System.Drawing.Point(78, 94);
            this.txt_sexuality.Name = "txt_sexuality";
            this.txt_sexuality.Size = new System.Drawing.Size(100, 20);
            this.txt_sexuality.TabIndex = 6;
            this.txt_sexuality.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Puntos fuertes";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_strong
            // 
            this.txt_strong.Location = new System.Drawing.Point(95, 120);
            this.txt_strong.Name = "txt_strong";
            this.txt_strong.Size = new System.Drawing.Size(216, 20);
            this.txt_strong.TabIndex = 8;
            this.txt_strong.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Puntos debiles";
            // 
            // txt_weak
            // 
            this.txt_weak.Location = new System.Drawing.Point(95, 146);
            this.txt_weak.Name = "txt_weak";
            this.txt_weak.Size = new System.Drawing.Size(218, 20);
            this.txt_weak.TabIndex = 10;
            this.txt_weak.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Espiritualidad";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_spirituality
            // 
            this.txt_spirituality.Location = new System.Drawing.Point(88, 172);
            this.txt_spirituality.Name = "txt_spirituality";
            this.txt_spirituality.Size = new System.Drawing.Size(100, 20);
            this.txt_spirituality.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Miedos";
            // 
            // txt_fears
            // 
            this.txt_fears.Location = new System.Drawing.Point(60, 198);
            this.txt_fears.Name = "txt_fears";
            this.txt_fears.Size = new System.Drawing.Size(100, 20);
            this.txt_fears.TabIndex = 14;
            // 
            // txt_jobs
            // 
            this.txt_jobs.Location = new System.Drawing.Point(67, 224);
            this.txt_jobs.Name = "txt_jobs";
            this.txt_jobs.Size = new System.Drawing.Size(100, 20);
            this.txt_jobs.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Trabajos";
            // 
            // pic_Img
            // 
            this.pic_Img.Location = new System.Drawing.Point(404, 27);
            this.pic_Img.Name = "pic_Img";
            this.pic_Img.Size = new System.Drawing.Size(207, 187);
            this.pic_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img.TabIndex = 17;
            this.pic_Img.TabStop = false;
            this.pic_Img.Click += new System.EventHandler(this.pic_Img_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(16, 267);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 18;
            this.btn_create.Text = "Crear";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(440, 222);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(139, 23);
            this.btn_open.TabIndex = 19;
            this.btn_open.Text = "Seleccionar Archivo";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(632, 302);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.pic_Img);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_jobs);
            this.Controls.Add(this.txt_fears);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_spirituality);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_weak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_strong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_sexuality);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Creación de personajes";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sexuality;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_strong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_weak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_spirituality;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fears;
        private System.Windows.Forms.TextBox txt_jobs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pic_Img;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

