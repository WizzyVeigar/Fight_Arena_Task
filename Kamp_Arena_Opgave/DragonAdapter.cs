using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamp_Arena_Opgave
{
    class DragonAdapter : IFighter
    {
        Dragon Piff = new Dragon();
        bool switchAttack = false;

        public int DefenseLeft => Piff.Defense();

        public int Attack()
        {
            if (!switchAttack)
            {
               switchAttack = true;
               return Piff.TailSlash();
            }
            switchAttack = false;
            return Piff.BreatheFire();
        }

        public void Defend(int attack)
        {
            Piff.Defend(attack);
        }

        public bool HasEscaped()
        {
            return Piff.IsFlyingAway();
        }
    }
}
