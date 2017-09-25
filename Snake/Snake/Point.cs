using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point : Figure
    {
        public Point(int x, int y, char symbol)
        {
            _headPointFirstAxis = x;
            _secondAxis = y;
            _symbol = symbol;
        }
    }
}
