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

            Console.WriteLine(map.Height * map.Width);
            Console.Read();
        }
    }
}
