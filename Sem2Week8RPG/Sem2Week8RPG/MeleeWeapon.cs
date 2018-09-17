using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2Week8RPG
{
    class MeleeWeapon : Weapon
    {
        public MeleeWeapon(string Name, string Type, int Range, int Damage, int Crit) : base("Sword", "Melee", 1, 20, Crit)
        {
                
        }
    }
}
