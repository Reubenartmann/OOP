using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2Week8RPG
{
    class RangedWeapon : Weapon
    {
        public RangedWeapon(string Name, string Type, int Range, int Damage, int Crit) : base("Bow", "Ranged", 5, 10, Crit)
        {
            
        }
    }
}
