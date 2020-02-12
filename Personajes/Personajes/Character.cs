using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Personajes
{
    public class Character
    {
        public Character()
        {
        }
        public Character(String name, int age, List<String> strong, List<String> weak, String fear, String job, String sexuality, String spirituality, Bitmap img)
        {
            setName(name);
            setAge(age);
            setStrong(strong);
            setWeak(weak);
            setFear(fear);
            setJob(job);
            setSexuality(sexuality);
            setSpirituality(spirituality);
            setImage(img);
        }
        private String name;
        private int age;
        private List<String> strong_points;
        private List<String> weak_points;
        private String fear;
        private String jobs;
        private String sexuality;
        private String spirituality;
        private Bitmap charac;

        public String getName()
        {
            return this.name;
        }
        public void setName(String name)
        {
            this.name = name;
        }

        public int getAge()
        {
            return this.age;
        }
        public void setAge(int age)
        {
            this.age = age;
        }

        public List<String> getStrong()
        {
            return this.strong_points;
        }
        public void setStrong(List<String> strong)
        {
            this.strong_points = strong;
        }

        public List<String> getWeak()
        {
            return this.weak_points;
        }
        public void setWeak(List<String> weak)
        {
            this.weak_points = weak;
        }

        public String getFear()
        {
            return this.fear;
        }
        public void setFear(String fear)
        {
            this.fear = fear;
        }

        public String getJob()
        {
            return this.jobs;
        }
        public void setJob(String job)
        {
            this.jobs = job;
        }

        public String getSexuality()
        {
            return this.sexuality;
        }
        public void setSexuality(String sexuality)
        {
            this.sexuality = sexuality;
        }

        public String getSpirituality()
        {
            return this.spirituality;
        }
        public void setSpirituality(String spiritual)
        {
            this.spirituality = spiritual;
        }

        public Bitmap getImage()
        {
            return this.charac;
        }
        public void setImage(Bitmap img)
        {
            this.charac = img;
        }

        public void view()
        {
            MessageBox.Show(String.Format("Se ha creado el personaje:\nNombre: {0}\nEdad: {1}\n" +
                "Sexualidad: {2}\nPuntos fuertes: {3}...\nPuntos debiles: {4}...\nEspiritualidad: {5}\n" +
                "Miedos: {6}\nTrabajos: {7}", getName(), getAge(), getSexuality(), getStrong()[0], getWeak()[0], getSpirituality()
                , getFear(), getJob()));
            //Comentario
        }
    }
}
