using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Character type");
            Console.WriteLine("\t1-Wizard");
            Console.WriteLine("\t1-Warrior");
            Console.WriteLine("\t1-Rogue");

            string type = Console.ReadLine();
            Console.WriteLine("Escribe un nombre");
            string name = Console.ReadLine();

            Character character = null;

            switch(type) {

                case "1":
                    character = new Wizard(name);
                    break;

                case "2":
                    character = new Warrior(name);
                    break;

                case "3":
                    character = new Rogue(name);
                    break;

                default:
                    break;
            }

            if(character != null) {
                character.Atack();
            }

            

        }
    }
}
