using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHangManGame.Clases
{
    class Evaluate
    {


        public static string complete(char letter,string word,string response)
        {

            char[] arrayWord = word.ToCharArray();
            String final = "";
            for(int i = 0; i < arrayWord.Length; i++)
            {
                if(arrayWord[i].Equals(letter) && new string(response[i],1).Equals("*"))
                {

                    final = final + letter;
                }
                else if(!new string(response[i],1).Equals("*"))
                {
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
