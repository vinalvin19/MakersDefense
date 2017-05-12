using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class Map
    {
        public readonly int Height;
        public readonly int Width;

        public Map(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public bool onMap(Point point)
        {
            var inBounds = point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;

            return inBounds;
        }
    }
}
