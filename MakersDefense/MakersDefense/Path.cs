using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class Path
    {
        private readonly MapLocation[] _path;

        public Path(MapLocation[] path)
        {
            //this.path = path;
            _path = path;
        }

        public MapLocation getLocationAt(int pathStep)
        {
            if (pathStep < _path.Length)
                return _path[pathStep];
            else
                return null;
        }
    }
}
