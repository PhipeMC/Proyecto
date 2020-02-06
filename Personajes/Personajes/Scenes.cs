using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Create
{
    public class Scenes
    {
        private String description;
        private String notes;
        private Bitmap background;

        public String getDescription()
        {
            return this.description;
        }
        public void setDescription(String description)
        {
            this.description = description;
        }

        public String getNotes()
        {
            return this.notes;
        }
        public void setNotes(String note)
        {
            this.notes = note;
        }

        public Bitmap getImage()
        {
            return this.background;
        }
        public void setImage(Bitmap img)
        {
            this.background = img;
        }
    }
}
