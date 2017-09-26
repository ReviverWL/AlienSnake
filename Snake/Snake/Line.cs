using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Line : Figure
    {

        private int _lastPointFirstAxis;

        public Line(int x1, int x2, char symbol, int y)
        {
            _headPointFirstAxis = x1;
            _lastPointFirstAxis = x2;
            _secondAxis = y;
            _symbol = symbol;

            for (int i = x1; i <= x2; i++)
            {
                _line.Add(new Point(i, y, symbol));
            }
        }
        public Line(int x, char symbol, int y1, int y2)
        {
            _headPointFirstAxis = y1;
            _lastPointFirstAxis = y2;
            _secondAxis = x;
            _symbol = symbol;

            for (int i = y1; i <= y2; i++)
            {
                _line.Add(new Point(x, i, symbol));
            }
        }         
    }
     
}
