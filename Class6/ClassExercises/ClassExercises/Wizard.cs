using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    class Wizard : Character
    {
        public Wizard(string name) : base(name)
        {
        }

        public Wizard(string name,int hp) : base(name,hp)
        {
        }

        public Wizard(string name,int hp,Stats stats) : base(name,hp,stats)
        {
        }

        public void Cast()
        {
            Console.WriteLine("Cast");
        }


        public override void ShowActionMenu() {

            base.ShowActionMenu();
            Console.WriteLine("Cast");

            string action = Console.ReadLine();

            switch(action)
            {

                case "1":
                    Walk();
                    break;

                case "2":
                    Jump();
                    break;

                case "3":
                    Attack();
                    break;
            }

            ShowActionMenu();

        }


    }
}
