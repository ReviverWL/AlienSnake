using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Fastfood
    {
        private int _x;
        private int _y;
        public Fastfood()
        {
            int x = -1;
            _x = x;
            int y = _y;
            Random random = new Random();
            x = random.Next(1, 148);
            y = random.Next(1, 48);
            Point food = new Point(x, y, '@');
        }
    }
}
