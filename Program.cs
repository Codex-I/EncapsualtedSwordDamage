using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwordDamage;
namespace EncapsualtedSwordDamage
{
    class Program
    {
        static void Main(string[] args)
        {
            CalSwordDamage swordDamage = new CalSwordDamage(RollDice());
            while (true)
            {
                Console.WriteLine("0 for no magic/flaming, 1 for magic, 2 for flaming," + " 3 for both, space to quit: ");
                char key = Console.ReadKey().KeyChar;
                if (key == ' ') return;
                swordDamage.Roll = RollDice();
                swordDamage.Magic = (key == '1' || key == '3');
                swordDamage.Flaming = (key == '2' || key == '3');
                Console.WriteLine($"\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP\n");

            }
        }

        private static int RollDice()
        {
            return new Random().Next(1, 7);
        }
    }
}
