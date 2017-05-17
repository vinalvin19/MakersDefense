using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.onMap(this))
            {
                throw new OutOfBoundsException(x +","+y+" outside the range");
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return distanceTo(location) <= range;
        }
    }
}
