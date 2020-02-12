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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap saveImage;

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
            saveImage = img;
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
                String name = txt_name.Text;
                int age = Convert.ToInt32(txt_age.Text);
                String sex = txt_sexuality.Text;
                String data_strong = txt_strong.Text;
                String data_weak = txt_weak.Text;
                String spirit = txt_spirituality.Text;
                String fear = txt_fears.Text;
                String job = txt_jobs.Text;
                Character template = new Character(name,age,makeList(data_strong),makeList(data_weak),fear,job,sex,spirit,saveImage);
                template.view();
                clear();
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

        private List<String> makeList(String s) {
            List<String> list = new List<string>();
            String[] tmp = new String[1000];
            tmp = s.Split(',');
            for (int i=0; i<tmp.Length; i++) {
                if (!tmp[i].Equals(""))
                {
                    list.Add(tmp[i]);
                }
                else {
                    break;
                }
            }
            return list;
        }

        public void clear() {
            txt_name.Text = "";
            txt_age.Text = "";
            txt_sexuality.Text = "";
            txt_strong.Text = "";
            txt_weak.Text = "";
            txt_spirituality.Text = "";
            txt_fears.Text = "";
            txt_jobs.Text = "";
            pic_Img.Image = null;
        }
    }
}
