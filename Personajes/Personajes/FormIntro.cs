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
    public partial class frmIntro : Form
    {
        public frmIntro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * 
         */

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxIntroduccion.Checked==true)
            {
                plResumen.Visible = true;
            }
            else
            {
                plResumen.Visible = false;
            }
            if (cbxVista.Checked == true)
            {
                plVista.Visible = true;
            }
            else
            {
                plVista.Visible = false;
            }
            if (cbxInspiracion.Checked == true)
            {
                plInspiracion.Visible = true;
            }
            else
            {
                plInspiracion.Visible = false;
            }

            btnGenerar.Enabled = false;

        }
        Introduccion caliz = new Introduccion();
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            caliz.setInspiracion(txtResumen.Text);
            caliz.setVista(txtVista.Text);
            caliz.setInspiracion(txtInspire.Text);
            caliz.show();


        }

        private void frmIntro_Load(object sender, EventArgs e)
        {

        }
    }
}
