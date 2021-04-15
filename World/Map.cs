using System;
using System.Collections.Generic;
using System.Text;

using RogueLike.Elements;
using RogueLike.Utilities;

namespace RogueLike.World
{
    class Map
    {
        private MapTile[,] Matrix { get; set; }
        private PlayerBody Player { get; set; }
        private int[] PlayerPosition { get; set; }
        private int Size { get; set; }

        public Map(PlayerBody player, int size)
        {
            Player = player;
            Size = size;
            CreateNewMap();
        }

        public void CreateNewMap()
        {
            Matrix = new MapTile[Size, Size];
            PlayerPosition = new int[] { 1, 1 };   
        }
    }
}
