using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personajes
{
    public partial class frmEscenas : Form
    {
        private int y = 0;
        private int contador = 0;
        public frmEscenas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnEscena_Click(object sender, EventArgs e)
        {
            
            if(isEmpty() == true)
            {
                MessageBox.Show("Llene todos los campos correspondientes","titulo",MessageBoxButtons.YesNo);
            }
            else
            {
                if(pboxImg.Image == null)
                {
                    MessageBox.Show("Desea continiar sin agregar imagen? ","continuar",MessageBoxButtons.YesNo);
                }else
                clear();
            }
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            String aux = openFileDialog1.ShowDialog().ToString();
            Bitmap img = new Bitmap(openFileDialog1.OpenFile());
            pboxImg.Image = img;
            
        }
        void clear()
        {
            txtDescripcion.Clear();
            txtNota.Clear();
            pboxImg.Image = null;
        }
        private bool isEmpty()
        {
            if (txtDescripcion.Text.Trim().Equals("")){
                return true;
            }else if (txtNota.Text.Trim().Equals(""))
            {
                return true;
            }
            return false;
        } 
    }
}
