using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        private int _tail;

        public Snake()
        {
            _tail = 20;
            _headPointFirstAxis = 22;            
            _secondAxis = 20;
            _symbol = '*';
            for (int i = _tail; i <= _headPointFirstAxis; i++)
            {
                _line.Add(new Point(i, _secondAxis, _symbol));
                //if (i == _tail)
                //{
                //    _symbol = '#';
                //}
            }
        }
        public void Move()
        {
            Point head = _line[_line.Count - 2];
            //_line[0].Clear();
            _line.RemoveAt(0);
            //int i = 0;
            //while ( i < _line.Count-1)
            //{
            //    _line[i].MovePointAxisX();
            //    i++;
            //}
            //_line.Add(new Point(_tail + 1, _headPointFirstAxis, _symbol));
        }
    }
}
