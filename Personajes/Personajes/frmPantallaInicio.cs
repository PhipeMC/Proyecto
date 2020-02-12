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
    public partial class frmPantallaInicio : Form
    {
        

        public frmPantallaInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1();
            this.Close();
            //f.Show();
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void frmPantallaInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
