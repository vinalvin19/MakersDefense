﻿using System;
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

    }
}
