using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHangManGame.Clases
{
    class GameManager
    {
        private string secretWord = "";

        public GameManager(string secretWord) {
            this.secretWord = secretWord.ToLower();
        }

        public string getSecretWord() {
            return this.secretWord;
        }

        public void setSecretWord(string secretWord) {
            this.secretWord = secretWord;
        }

        public bool check(string letter) {

            if(this.secretWord.Contains(letter))
            {
                return true;
            }
            else {
                return false;
            }

        }

        public void finalGame(string total) {

            Board board = new Board();

            if(secretWord.Equals("" + total))
            {
                board.Clear();
                board.Draw("Ganaste!!!!");
            }
            else
            {
                board.Clear();
                board.Draw("Perdiste!!!!");
            }


        }
        
    }
}
