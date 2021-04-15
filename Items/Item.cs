using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Items
{
    class Item
    {
        public string Name { get; protected set; }
        public sbyte Type { get; protected set; }
        public string Icon { get; protected set; }
        
        public Item(string name)
        {
            Name = name;
        }
    }
}