using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    class Snake : Figure
    {
        private Direction _direction;

        public Direction Direct { get => _direction; }

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

        public bool CollizionFood(Point food)
        {
            Point head = _line.Last();
            if (head.Collizion(food))
            {
                food.Symbol = head.Symbol;
                _line.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void ChangeDirect()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.Key == ConsoleKey.LeftArrow && _direction != Direction.Right && _direction != Direction.Left)
                {
                    _direction = Direction.Left;
                }
                if (key.Key == ConsoleKey.RightArrow && _direction != Direction.Left && _direction != Direction.Right)
                {
                    _direction = Direction.Right;
                }
                if (key.Key == ConsoleKey.UpArrow && _direction != Direction.Down && _direction != Direction.Up)
                {
                    _direction = Direction.Up;
                }
                if (key.Key == ConsoleKey.DownArrow && _direction != Direction.Up && _direction != Direction.Down)
                {
                    _direction = Direction.Down;
                }
            }
        }
    }
}
