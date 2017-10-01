using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            Console.WindowWidth = 150;
            Console.WindowHeight = 50;
            Console.SetBufferSize(150, 50);
            Snake snake = new Snake(20, 6, Direction.Right);
            snake.ShowFigure();
            while (true)
            {
                Thread.Sleep(500);
                snake.ChangeDirect();
                snake.Move();
                snake.ShowFigure();
            }

        }
    }
}
