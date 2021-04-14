using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLike.Elements
{
    class Player : Element
    {
        public Player(string name, char icon) : base(name, icon)
        {
        }

        public int Level { get; set; }
        public int Strength { get; set; }
    }
}
