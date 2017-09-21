using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class GorizontalLine
    {
        private List<Point> _line = new List<Point>();
        private int _xLeft;
        private int _xRight;
        private int _y;
        private char _symbol;

        public GorizontalLine(int xLeft, int xRight, int y, char symbol)
        {            
            _xLeft = xLeft;
            _xRight = xRight;
            _y = y;
            _symbol = symbol;
            for (int i = xLeft; i<=xRight; i++)
            {
                _line.Add(new Point(i, y, symbol));
            }
        }
    }
}
