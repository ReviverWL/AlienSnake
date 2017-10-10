using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Program
    {
        private static void GameOver()
        {
            Console.SetCursorPosition(70, 24);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("GAME OVER");

        }
        static void Main()
        {
            Console.WindowWidth = 100;
            Console.WindowHeight = 40;
            Console.SetBufferSize(100, 40);
            Snake snake = new Snake(20, 3, Direction.Right);

            Line leftline = new Line(0, '+', 1 , 38);
            Line rightline = new Line(99, '+', 1, 38);
            Line upline = new Line(1, 98, '+', 0);
            Line downline = new Line(1, 98, '+',  39);

            leftline.ShowFigure();
            rightline.ShowFigure();
            upline.ShowFigure();
            downline.ShowFigure();

            Point food = new Point();
            food = Point.Fastfood();
            food.ShowPoint();
            while (true)
            {
                snake.ShowFigure();
                Thread.Sleep(250);
                snake.ChangeDirect();
                snake.Move();
                if (snake.CollizionFood(food))
                {
                    food = Point.Fastfood();
                    food.ShowPoint();
                }
                if (snake.Direct == Direction.Up)
                {
                    if (snake.CollizionFigure(upline))
                    {
                        
                        GameOver();
                        break;
                    }
                }
                else if (snake.Direct == Direction.Down)
                {
                    if (snake.CollizionFigure(downline))
                    {
                        GameOver();
                        break;
                    }
                }
                else if (snake.Direct == Direction.Left)
                {
                    if (snake.CollizionFigure(leftline))
                    {
                        GameOver();
                        break;
                    }
                }
                else if (snake.Direct == Direction.Right)
                {
                    if (snake.CollizionFigure(rightline))
                    {
                        GameOver();
                        break;
                    }
                }
                
            }

            Console.ReadKey();
        }        
    }
}
