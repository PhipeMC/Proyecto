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
    public partial class SplahForm : Form
    {
        public SplahForm()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Timer tmr;
        private void SplahForm_Load(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Interval = 5000;
            tmr.Start();
            tmr.Tick += tmr_Tick;
            //pictureBox2.Load("giphy.gif");
        }

        void tmr_Tick(object sender, EventArgs e)

        {
            tmr.Stop();
            this.Hide();
            frmPantallaInicio f = new frmPantallaInicio();
            f.Show();
        }


    }
}
