using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamp_Arena_Opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                IFighter R1 = new Ridder();
                IFighter R2 = new WizardAdapter();
                IFighter R3 = new DragonAdapter();
                IFighter R4 = new RenéAdapter();

                Console.WriteLine(Fight(R4, R3));
                //Console.WriteLine("The winner is" + winnerAnnounce);
                Console.ReadKey();
            }
        }

        public static string Fight(IFighter f1, IFighter f2)
        {

            while (!f1.HasEscaped() && !f2.HasEscaped() && (f1.DefenseLeft > 0) && (f2.DefenseLeft > 0))
            {
                // Første fighter henter attack
                int attack = f1.Attack();
                // Anden fighter skal forsvare sig
                f2.Defend(attack);
                Console.WriteLine("Player 2 is hit for " + attack + ": " + f2.DefenseLeft + "HP left");
                // Anden fighter henter attack
                attack = f2.Attack();
                // Første fighter skal forsvare sig
                f1.Defend(attack);
                Console.WriteLine("Player 1 is hit for " + attack + ": " + f1.DefenseLeft + "HP left");
            }

            string winner = "Draw";

            // kampen er afsluttet
            if ((f1.DefenseLeft > 0) && (!f1.HasEscaped()))
            {
                winner = "f1 vandt";
            }

            if ((f2.DefenseLeft > 0) && (!f2.HasEscaped()))
                winner = "f2 vandt";

            // Hvis der returneres null, så har kampen været jævnbyrdig
            return winner;

        }
    }
}
