using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveRPG.Services
{
    public class GameCombat
    {
    // Kill Troll
    while (!aTroll.Dead)
    {
        // Character always deals 7 in damage...
        aChar.ReceiveDamage(Random.Shared.Next(5, 10));
        aTroll.ReceiveDamage(7);
    }

    // Loot Troll
    aChar.GoldOwned = aChar.GoldOwned + aTroll.GoldOwned;
    if (aTroll.SwordToLoot != null)
    {
        aChar.SwordOwned = aTroll.SwordToLoot;
    }
    if (aTroll.ShieldToLoot != null)
    {
        aChar.ShieldOwned = aTroll.ShieldToLoot;
    }
        }
    }
