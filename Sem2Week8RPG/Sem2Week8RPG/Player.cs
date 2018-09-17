using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2Week8RPG
{
    public class Player : Entity
    {
        public Player (string Name, string Type, int Level, int Health) : base("Player", "Human", 1, 100)
        {
            this.Name = Name;
        }

    }
}
