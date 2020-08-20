using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kamp_Arena_Opgave
{
    class Ridder : IFighter
    {
        int defense = 30;
        public int DefenseLeft
        {
            get
            {
                return defense;
            }
            set
            {
                defense = value;
            }
        }
        //Random attackRange = new Random();

        public void Defend(int attack)
        {
            DefenseLeft -= attack;
        }

        public bool HasEscaped()
        {
            int number = new Random().Next(0, 100);

            if (number <= 15)
            {
                return true;
            }
            return false;
        }

        public int Attack()
        {
            Thread.Sleep(150);
            return new Random().Next(1,6);
        }
    }
}
