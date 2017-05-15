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

            try
            {
                MapLocation mapLoc = new MapLocation(8, 5, map);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            Console.Read();
        }
    }
}
