using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void open_file_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            string file = openFileDialog1.ShowDialog().ToString();
            //MessageBox.Show(file);
            Bitmap img = new Bitmap(openFileDialog1.OpenFile());
            pic_Img.Image = img;
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void pic_Img_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (isEmply())
            {
                MessageBox.Show("Llena todos los campos correspondientes");
            }
            else {

            }
        }

        public Boolean isEmply() {
            if (txt_name.Text.Equals(""))
            {
                return true;
            }
            else if (txt_age.Text.Equals(""))
            {
                return true;
            }
            else if (txt_sexuality.Text.Equals(""))
            {
                return true;
            }
            else if (txt_strong.Text.Equals(""))
            {
                return true;
            }
            else if (txt_weak.Text.Equals(""))
            {
                return true;
            }
            else if (txt_spirituality.Text.Equals(""))
            {
                return true;
            }
            else if (txt_fears.Text.Equals(""))
            {
                return true;
            }
            else if(txt_jobs.Text.Equals("")){
                return true;
            }
            return false;
        }
    }
}
