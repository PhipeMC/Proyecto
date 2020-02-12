using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    class Game
    {
        private Character character;
        private Scenes scene;
        private Introduccion intro;

        public Game() { 
            
        }

        public Character GetCharacter() {
            return this.character;
        }
        public void setCharacter(Character character) {
            this.character = character;
        }

        public Scenes GetScenes() {
            return this.scene;
        }
        public void setScene(Scenes scene) {
            this.scene = scene;
        }

        public Introduccion GetIntroduccion() {
            return this.intro;
        }
        public void setIntro(Introduccion intro) {
            this.intro = intro;
        }
    }
}
