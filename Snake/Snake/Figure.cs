using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> _line = new List<Point>();
        protected int _headPointFirstAxis;
        protected int _secondAxis;
        protected char _symbol;

        public void ShowPoint()
        {
            Console.SetCursorPosition(_headPointFirstAxis, _secondAxis);
            Console.Write(_symbol);
        }

        public void ShowFigure()
        {
            for (int i = 0; i < _line.Count(); i++)
            {
                _line[i].ShowPoint();
            }

        }

    }
}
