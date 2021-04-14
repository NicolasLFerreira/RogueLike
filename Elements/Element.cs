using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLike.Elements
{
    class Element
    {
        public string Name { get; set; }
        public char Icon { get; set; }

        public Element(string name, char icon)
        {
            Name = name;
            Icon = icon;
        }
    }
}
