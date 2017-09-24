using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Line : Figure
    {
        //private List<Line> _line = new List<Line>();
        //private int _headPoint;
        private int _lastPoint;
        private int _secondAxis;
        //private char _symbol;

        public Line(int firstPoint, int lastPoint, int numberOfDirection, char symbol, bool direction)
        {
            _headPointFirstAxis = firstPoint;
            _lastPoint = lastPoint;
            _secondAxis = numberOfDirection;
            _symbol = symbol;
            if (direction)
            {                
                for (int i = firstPoint; i <= lastPoint; i++)
                {
                    _line.Add(new Line(i, numberOfDirection, symbol));
                }
            }
            else
            {
                for (int i = firstPoint; i <= lastPoint; i++)
                {
                    _line.Add(new Line(numberOfDirection, i, symbol));
                }
            }
        }
        public Line(int x, int y, char symbol)
        {
            _headPointFirstAxis = x;
            _secondAxis = y;
            _symbol = symbol;
        }

        public void ShowStartPointLine()
        {
            Console.SetCursorPosition(_headPointFirstAxis, _secondAxis);
            Console.Write(_symbol);
        }        
    }
     
}
