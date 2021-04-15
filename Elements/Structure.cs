using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLike.Elements.Structures
{
    class Structure : Element
    {
        public bool Solid { get; set; }
        public int Hardness { get; set; }

        public Structure(string name, char icon, bool solid, int hardness) : base(name, icon)
        {
            Solid = solid;
            Hardness = hardness;
        }
    }
}
