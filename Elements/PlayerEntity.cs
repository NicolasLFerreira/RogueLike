using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLike.Elements
{
    class PlayerBody : Element
    {
        public int Level { get; set; }
        public int Strength { get; set; }

        public PlayerBody(string name, char icon, int level, int strength) : base(name, icon)
        {
            Level = level;
            Strength = strength;
        }

        public int Movement(char key)
        {
            return key switch
            {
                'w' => 0,
                's' => 1,
                'a' => 2,
                'd' => 3,
                _ => -1,
            };
        }
    }
}
