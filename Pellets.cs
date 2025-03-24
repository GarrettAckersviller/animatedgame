using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animatedgame
{
    internal class Pellets
    {
        public int x, y;
        public int size = 5;

        public Pellets(int _x, int _y) //Spawning pellets
        {
            x = _x;
            y = _y;
        }
    }
}
