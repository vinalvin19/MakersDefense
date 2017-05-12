using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class Game
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);

            Point p = new Point(4, 2);
            bool isOnMap = map.onMap(p);
            Console.WriteLine(isOnMap);

            p = new Point(8, 5);
            isOnMap = map.onMap(p);
            Console.WriteLine(isOnMap);

            Console.WriteLine(p.distanceTo(5, 2));
            Console.Read();
        }
    }
}
