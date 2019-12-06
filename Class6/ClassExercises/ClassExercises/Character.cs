using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    class Character
    {

         String name;
         int hp;
         Stats stats;

        public Character(string name) {
            this.name = name;
            this.hp = 20;
            this.stats = new Stats();
        }

        public Character(string name,int hp)
        {
            this.name = name;
            this.hp = hp;
            this.stats = new Stats();
        }

        public Character(string name,int hp,Stats stats)
        {
            this.name = name;
            this.hp = hp;
            this.stats = stats;
        }

        public void Attack() {
            Console.WriteLine("el "+ this.GetType().Name + "te ataca.");
        }

        public void Jump()
        {
            Console.WriteLine("Jump");
        }

        public void Walk() {
            Console.WriteLine("Walk");
        }
        public virtual void ShowActionMenu()
        {
            Console.WriteLine();
            Console.WriteLine("ACTIONS");
            Console.WriteLine("=======");
            Console.WriteLine("1 - walk");
            Console.WriteLine("2 - jump");
            Console.WriteLine("3 - attack");


        }

    }
}
