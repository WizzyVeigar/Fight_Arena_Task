using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamp_Arena_Opgave
{
    class WizardAdapter : IFighter
    {
        Wizard wizard = new Wizard();


        public int DefenseLeft => wizard.DefenseLeft();

        public int Attack()
        {
            return wizard.CastFireballSpell();
        }

        public void Defend(int attack)
        {
            wizard.Shield(attack);
        }

        public bool HasEscaped()
        {
            return wizard.IsPortalOpened();
        }
    }
}
