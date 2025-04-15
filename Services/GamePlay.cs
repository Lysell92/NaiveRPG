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
        private Character aChar;

        public GamePlay(Character character)
        {
            aChar = character;
        }
        public void Intro()
        {
            Console.Clear();
            Console.WriteLine("Welcome. The Fortress awaits you.\n You will face different creatures to combat and collect items from them.\n" +
            "If you make it to the end, the mythological Hydra awaits... ");
            GameLogic.Continue();
            
            Console.WriteLine("You have walked for days in the fog. A Fortress suddenly appears, seemingly out of nowhere.");
            GameLogic.Continue();
            Art FortressArt = new Art(Art.Fortress);
            FortressArt.DisplayArt(20, 25);
            GameLogic.Continue();
            FortressArt.ClearArt(20, 25);

            Console.WriteLine("Guarding the gate is a 'Gnoll. It seems aggressive and is facing towards you.\n" +
            "It seems like there's no way around, but to engage in combat.");
            GameLogic.Continue();
            Art GnollArt = new Art(Art.Gnoll);
            GnollArt.DisplayArt(20, 25);
            GameLogic.Continue();
            GnollArt.ClearArt(20, 25);
        }
        public void BossEncounter()
        {
            Console.WriteLine("You've succeded and ventured further into the Fortress.\n Suddenly a giant Hydra reveals itself. Apparently it was invisible.\n" +
            "There's no escape. You must fight.");
            GameLogic.Continue();
            Art HydraArt = new Art(Art.Hydra);
            HydraArt.DisplayArt(20, 25);
            GameLogic.Continue();
            HydraArt.ClearArt(20, 25);
        }

        public void Ending()
        {
            Console.WriteLine("You've defeated the legendary Hydra and collected awesome loot. Congratulations :=)");
            Art SantaArt = new Art(Art.RandomSanta);
            GameLogic.Continue();
            SantaArt.DisplayArt(20, 25);
            GameLogic.Continue();
            SantaArt.ClearArt(20, 25);
        }
    }
}
