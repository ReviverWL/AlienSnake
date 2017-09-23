using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Line> _line = new List<Line>();
        protected int _headPoint;
        protected char _symbol;

        public void ShowFigure()
        {
            for (int i = 0; i < _line.Count; i++)
            {
                _line[i].ShowStartPointLine();
            }

        }

    }
}
