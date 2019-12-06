using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    class Rogue : Character
    {
        public Rogue(string name) : base(name)
        {
        }

        public Rogue(string name,int hp) : base(name,hp)
        {
        }

        public Rogue(string name,int hp,Stats stats) : base(name,hp,stats)
        {
        }

        public void Stell()
        {
            base.ShowActionMenu();
            Console.WriteLine("Steal");

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
