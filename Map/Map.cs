using System;
using System.Collections.Generic;
using System.Text;

using RogueLike.Elements;

namespace RogueLike.Map
{
    class Map
    {
        public MapNode[,] Matrix { get; set; }
        public PlayerBody Player { get; set; }

        public int Size { get; set; }

        public Map(PlayerBody player, int size)
        {
            Player = player;
            Size = size;
        }

        public void CreateNewMap()
        {
            Matrix = new MapNode[Size, Size];
        }
    }
}
