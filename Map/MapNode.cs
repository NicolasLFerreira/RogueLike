using System;
using System.Collections.Generic;
using System.Text;

using RogueLike.Elements;

namespace RogueLike.Map
{
    class MapNode
    {
        public Element Bottom { get; set; }
        public Element Top { get; set; }
        public Element Content {
            get
            {
                if (Top.Name == "air") return Bottom;
                return Top;
            }
            set;
        }
        
        public MapNode()
        {
            Bottom = new Element("air", ' ');
            Top = new Element("air", ' ');
        }

        public MapNode(Element bottom)
        {
            Bottom = bottom;
            Top = new Element("air", ' ');
        }

        public MapNode(Element bottom, Element top)
        {
            Bottom = bottom;
            Top = top;
        }
    }
}
