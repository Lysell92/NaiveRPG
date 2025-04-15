using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveRPG.Models.Attributes
{
    public class ManaPool
    {
        public int Current { get; private set; }
        public int Max { get; }
    }
    public ManaPool (int max)
        {
            Max = max;
            Current = max;
        }

    public bool ManaUse(int amount)
        {
            if (Current < amount) return false;
            Current -= amount;
            return true;
        }
    public void Recover (int amount)
        {
            Current = Math.Min(Current + amount, Max);
        }
}
