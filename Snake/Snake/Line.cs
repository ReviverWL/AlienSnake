using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Line : Figure
    {
        public Line(int x1, int x2, char symbol, int y)
        {
            _line = new List<Point>();

            for (int i = x1; i <= x2; i++)
            {
                _line.Add(new Point(i, y, symbol));
            }
        }
        public Line(int x, char symbol, int y1, int y2)
        {
            _line = new List<Point>();

            for (int i = y1; i <= y2; i++)
            {
                _line.Add(new Point(x, i, symbol));
            }
        }         
    }
     
}
