using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        public int Health { get; set; } = 2;

        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public MapLocation Location
        {
            get
            {
                return _path.getLocationAt(_pathStep);
            }
        }

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move()
        {
            _pathStep += 1;
        }

        public void decreaseHealth(int factor)
        {
            Health -= factor;
        }

    }
}
