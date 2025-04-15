using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using NaiveRPG.Factories;
using NaiveRPG.Models.Items;
using NaiveRPG.Interfaces;
public class Character
{
    public string Name { get; }
    public int HealthPoints { get; set; }
    public int GoldOwned { get; set; }
    public Sword? SwordOwned { get; set; }
    public Shield? ShieldOwned { get; set; }
    public Boots? BootsOwned { get; set; }
    public IAttack Attack { get; set; }

    public Character(string name, string attackType)
    {
        Name = name;
        GoldOwned = 0;
        SwordOwned = null;
        ShieldOwned = null;
        BootsOwned = null;
        HealthPoints = 100;
        Attack = AttackFactory.GetAttack(attackType);
    }

    public void ReceiveDamage(int damagePoints)
    {
        HealthPoints = HealthPoints - damagePoints;
    }
}
