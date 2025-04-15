using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NaiveRPG.Models.Visuals;

namespace NaiveRPG.Services
{
    public class GamePlay
    {
        public void intro()
        {
            Console.Clear();
            Console.WriteLine("Welcome. The Fortress awaits you.\n You will face different creatures to combat and collect items from them.\n" +
            "If you make it to the end, the mythological Hydra awaits... ");
            GameLogic.Continue();
            
            Console.WriteLine("You have walked for days in the fog. A Fortress suddenly appears, seemingly out of nowhere.");
            Art fortressArt = new Art(Art.Fortress);
            fortressArt.DisplayArt(4, 6);
            GameLogic.Continue();
            fortressArt.ClearArt(4, 6);

            Console.WriteLine("Guarding the gate is a 'Gnoll. It seems aggressive and is facing towards you.\n" +
            "It seems like there's no way around, but to engage in combat.");
            Art GnollArt = new Art(Art.Gnoll);
            GnollArt.DisplayArt(4, 6);
            GameLogic.Continue();
        }
        public void MainFight()
        {
            Console.WriteLine("You've succeded and ventured further into the Fortress.\n Suddenly a giant Hydra reveals itself. Apparently it was invisible.\n" +
            "There's no escape. You must fight.");
            Art HydraArt = new Art(Art.Hydra);
            HydraArt.DisplayArt(4, 6);
            GameLogic.Continue();
        }

        public void Ending()
        {
            Console.WriteLine("You've defeated the legendary Hydra and collected awesome loot. Congratulations :=)");
            Art SantaArt = new Art(Art.RandomSanta);
            SantaArt.DisplayArt(4, 6);
            GameLogic.Continue();
            SantaArt.ClearArt(4, 6);
        }
    }
}
