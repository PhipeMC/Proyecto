using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Personajes
{
    public class Introduccion
    {

        private String resume = "";
        private String vista = "";
        private String inspire = "";

        public Introduccion()
        {

        }

        public Introduccion(String resume, String vista, String inspire)
        {
            this.resume = resume;
            this.vista = vista;
            this.inspire = inspire;
        }
        
        public String getResume()
        {
            return resume;
        }
        public void setResume(String resume)
        {
            this.resume = resume;
        }
        public String getVista()
        {
            return vista;
        }
        public void setVista(String vista)
        {
            this.vista = vista;
        }
        public String getInspiracion()
        {
            return inspire;
        }
        public void setInspiracion(String inspire)
        {
            this.inspire = inspire;
        }

        public void show()
        {

            MessageBox.Show(String.Format("Se han creado los apartados señalados :)"));
        }
        
    }
}
