using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHangManGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "zapato";
            int life = 3;

            string response = "";
            String letter = "";

            StringBuilder total = new StringBuilder();

            bool validate = false;

            for(int i = 0; i < secretWord.Length; i++) {
                total.Append("*");
            }
            response = total.ToString();

            while(life > 0) {
                Console.Clear();
                Console.WriteLine(total);
                Console.WriteLine("Ingrese una letra;");
                Console.WriteLine("Vidas: " +life);
                if(secretWord.Equals("" + total))
                {
                    break;
                }
                letter = Console.ReadLine();
                validate = secretWord.Contains(letter);


            if(validate)
            {
                    
                   response = complete(letter[0],secretWord,response);
                    total.Clear();
                    total.Append(response);

                    Console.WriteLine(total);

                }
            else
            {
                life --;
                    

                }

        }

            if(secretWord.Equals("" + total))
            {
                Console.Clear();
                Console.Write("Ganaste!!!!");

            }
            else {
                Console.Clear();
                Console.Write("Perdiste!!!");
            }


            Console.ReadLine();
        }

        public static string complete(char letter, string word, string response) {

            char[] arrayWord = word.ToCharArray();
            String final = "";
            for(int i = 0; i < arrayWord.Length; i++) {
                if(arrayWord[i].Equals(letter) && new string(response[i],1).Equals("*"))
                {

                    final = final + letter;
                }
                else if(!new string(response[i],1).Equals("*")) {
                    final = final + new string(response[i],1);
                }
                else
                {

                    final = final + "*";
                }

            }

            return final;


        }


    }
}
