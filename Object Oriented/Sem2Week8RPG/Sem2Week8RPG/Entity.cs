using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2Week8RPG
{
    public abstract class Entity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }

        public Entity(string pName, string pType, int pLevel, int pHealth)
        {
            Name = pName;
            Type = pType;
            Level = pLevel;
            Health = pHealth;
        }

    }
}
