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

        public int X { get => _x; }
        public int Y { get => _y; }
        public char Symbol { get => _symbol; }

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

        public void ShiftPoint(int shift, Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    _y -= shift;
                    break;
                case Direction.Down:
                    _y += shift;
                    break;
                case Direction.Left:
                    _x -= shift;
                    break;
                case Direction.Right:
                    _x += shift;
                    break;
            }            
        }

        public void Clear()
        {
            _symbol = ' ';
            ShowPoint();
        }
    }
}
