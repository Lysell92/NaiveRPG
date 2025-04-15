using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using NaiveRPG.Models.Items;
public class Character
{
    public string Name { get; }
    public int HealthPoints { get; set; }
    public int GoldOwned { get; set; }
    public Sword? SwordOwned { get; set; }
    public Shield? ShieldOwned { get; set; }
    public Boots? BootsOwned { get; set; }

    public Character(string name)
    {
        Name = name;
        GoldOwned = 0;
        SwordOwned = null;
        ShieldOwned = null;
        BootsOwned = null;
    }
    
    public void ReceiveDamage(int damagePoints)
    {
        HealthPoints = HealthPoints - damagePoints;
    }
}
