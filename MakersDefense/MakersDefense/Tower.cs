using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class Tower
    {
        private readonly MapLocation _location;
        private const int _range = 1;
        private const int _power = 1;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    invader.decreaseHealth(_power);
                    break;
                }
            }
        }
    }
}
