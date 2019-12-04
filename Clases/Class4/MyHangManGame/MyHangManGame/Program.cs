using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHangManGame.Clases;

namespace MyHangManGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager("zapato");            

            Board board = new Board();

            Player player = new Player(3,"","");

            player.setWord(board.writeInitial(gameManager.getSecretWord()));

            while(player.getLife() > 0)
            {
                board.Clear();
                board.Draw(player.getWord());
                board.Draw("Ingrese una letra;");
                board.Draw("Vidas: " + player.getLife());
                if(gameManager.getSecretWord().Equals("" + player.getWord()))
                {
                    break;
                }
                player.setLetter(Console.ReadLine());
                if(gameManager.check(player.getLetter()))
                {
                    player.setWord(Evaluate.complete(player.getLetter()[0],gameManager.getSecretWord(),player.getWord()));

                    board.Draw(player.getWord());
                }
                else
                {
                    player.setLife(player.getLife() - 1);
                }

            }

            gameManager.finalGame(player.getWord());

            Console.ReadLine();
        }
    }
}
