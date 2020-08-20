using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamp_Arena_Opgave
{
    class SKPInstructor
    {
        private Random r = new Random();
        private float defend = 17.4f;
        private bool flyAway = false;


        public int BreatheFire()
        {
            return 10;
        }


        public int AngryRoar()
        {
            return new Random().Next(3,6);
        }


        public void Defend(int attack)
        {
            defend -= attack;
            if (r.Next(100) <= 20)
            {
                flyAway = true;
            }
        }

        public bool GrabbingCoffee()
        {
            return false;
        }

        public int Defense()
        {
            return (int)Math.Round(defend);
        }

    }
}
