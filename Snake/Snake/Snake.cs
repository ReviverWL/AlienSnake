using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {        
        public Snake(int tail, int lenght, Direction direction)
        {
            _line = new List<Point>();
            for (int i =0; i < lenght; i++)
            {
                Point head = new Point(tail, 20, '#');
                head.ShiftPoint(i, direction);
                _line.Add(head);
            }
        }
        public void Move()
        {
            _line.Last().ShiftPoint(1, direction);
        }
    }
}
