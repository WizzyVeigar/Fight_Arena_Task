using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamp_Arena_Opgave
{
    class RenéAdapter : IFighter
    {
        SKPInstructor René = new SKPInstructor();
        bool switchAttack = false;


        public int DefenseLeft => René.Defense();

        public int Attack()
        {
            if (!switchAttack)
            {
                switchAttack = true;
                return René.AngryRoar();
            }
            switchAttack = false;
            return René.BreatheFire();
        }

        public void Defend(int attack)
        {
            René.Defend(attack);
        }

        public bool HasEscaped()
        {
            return René.GrabbingCoffee();
        }
    }
}
