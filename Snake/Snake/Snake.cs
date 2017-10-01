using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction _direction;
        public Snake(int tail, int lenght, Direction direction)
        {
            _direction = direction;
            _line = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point head = new Point(tail, 20, '#');
                head.ShiftPoint(i, direction);
                _line.Add(head);
            }
        }
        public void Move()
        {
            Point head = new Point(_line.Last().X, _line.Last().Y, _line.Last().Symbol);
            _line.Add(head);            
            _line.Last().ShiftPoint(1, _direction);
            _line[0].Clear();
            _line.RemoveAt(0);
        }
    }
}
