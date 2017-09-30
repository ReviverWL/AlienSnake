using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            Console.WindowWidth = 150;
            Console.WindowHeight = 50;
            Console.SetBufferSize(150, 50);
            Snake snake = new Snake(20, 5, Direction.Up);
            snake.ShowFigure();
            Console.Read();
        }
    }
}
