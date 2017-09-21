using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        private int _x;
        private int _y;
        private char _symbol;

        public Point(int x, int y, char symbol)
        {
            _x = x;
            _y = y;
            _symbol = symbol;
        }
        public void ShowPoint()
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(_symbol);
        }
    }
}
