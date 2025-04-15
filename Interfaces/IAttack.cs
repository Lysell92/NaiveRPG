using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveRPG.Interfaces
{
    public interface IAttack
    {
        string AttackName { get; }
        int Damage { get; }
    }
}
