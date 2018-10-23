using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2Week8RPG
{
    public abstract class Weapon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Range { get; set; }
        public int Damage { get; set; }
        public int Crit { get; set; }

        public Weapon (string pName, string pType, int pRange, int pDamage, int pCrit)
        {
            Name = pName;
            Type = pType;
            Range = pRange;
            Damage = pDamage;
            Crit = pCrit;
        }

        public int Attack()
        {
            return Damage;
        }

        public int CriticalHit()
        {
            Damage = Crit;
            return Crit * 3;
        }

        public string getName()
        {
            return Name;
        }
    }
}
