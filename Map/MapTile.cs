using System;
using System.Collections.Generic;
using System.Text;

using RogueLike.Elements;

namespace RogueLike.Map
{
    class MapTile
    {
        // The floor of the map
        public Element Bottom { get; set; }
        // Content on top of the floor
        public Element Top { get; set; }
        // Returns the top-most element that is not air or
        // sets the bottom-most element that is air.
        public Element Content {
            get
            {
                if (Top.Name == "air") return Bottom;
                return Top;
            }
            set
            {
                if (Bottom.Name == "air") Bottom = value;
                else Top = value;
            }
        }
        
        // Constructor for empty tile
        public MapTile()
        {
            Bottom = new Element("air", ' ');
            Top = new Element("air", ' ');
        }

        // Constructor for floor-only tile
        public MapTile(Element bottom)
        {
            Bottom = bottom;
            Top = new Element("air", ' ');
        }

        // Constructor for full tile
        public MapTile(Element bottom, Element top)
        {
            Bottom = bottom;
            Top = top;
        }
    }
}
