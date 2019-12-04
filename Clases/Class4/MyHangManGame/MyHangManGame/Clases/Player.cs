using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHangManGame.Clases
{
    class Player
    {

        private int life;
        private String letter;
        private string word;

        public Player(int life,string letter, string word) {

            this.life = life;
            this.letter = letter;

        }

        public int getLife() {
            return this.life;
        }

        public void setLife(int life) {
            this.life = life;
        }


        public string getLetter()
        {
            return this.letter;
        }

        public void setLetter(string letter)
        {
            this.letter = letter;
        }

        public string getWord()
        {
            return this.word;
        }

        public void setWord(string Word)
        {
            this.word = Word;
        }

    }
}
