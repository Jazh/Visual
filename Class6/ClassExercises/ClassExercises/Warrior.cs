using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    class Warrior : Character
    {
        public Warrior(string name) : base(name)
        {
        }

        public Warrior(string name,int hp) : base(name,hp)
        {
        }

        public Warrior(string name,int hp,Stats stats) : base(name,hp,stats)
        {
        }
    }
}
