using System;

namespace Snake
{
    class Fastfood
    {
        private int _x;
        private int _y;

        public Fastfood()
        {
            Random random = new Random();
            _x = random.Next(1, 148);
            _y = random.Next(1, 48);
            Point food = new Point(_x, _y, '@');
            food.ShowPoint();
        }
    }
}
