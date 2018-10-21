using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces001
{
    public abstract class Weapon
    {
        public string Name { get; set; }
        public int Range { get; set; }
        public int Poke { get; set; }


        public Weapon(string _Name, int _Range, int _Poke)
        {
            Name = _Name;
            Range = _Range;
            Poke = _Poke;
        }


    }
}
