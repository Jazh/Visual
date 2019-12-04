using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHangManGame.Clases
{
    class Board
    {

        public void Clear() {
            Console.Clear();
        }

        public void Draw(string line) {
            Console.WriteLine(line);
        }

        public void Close() {
            Console.WriteLine("Press Enter to close");
            Console.ReadLine();
        }

        public string writeInitial(string secretWord) {

            StringBuilder total = new StringBuilder();

            for(int i = 0; i < secretWord.Length; i++)
            {
                total.Append("*");
                Console.Write("*");
            }

            return total.ToString();
        }

    }
}
