using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Line
    {
        private List<Point> _line = new List<Point>();
        private int _firstPoint;
        private int _lastPoint;
        private int _numberLineOnMap;
        private char _symbol;
        

        public Line(int firstPoint, int lastPoint, int numberOfDirection, char symbol, bool direction)
        {
            _firstPoint = firstPoint;
            _lastPoint = lastPoint;
            _numberLineOnMap = numberOfDirection;
            _symbol = symbol;
            if (direction)
            {                
                for (int i = firstPoint; i <= lastPoint; i++)
                {
                    _line.Add(new Point(i, numberOfDirection, symbol));
                }
            }
            else
            {
                for (int i = firstPoint; i <= lastPoint; i++)
                {
                    _line.Add(new Point(numberOfDirection, i, symbol));
                }
            }
        }
        public void ShowLine()
        {
            for (int i =0; i< _line.Count; i++)
            {
                _line[i].ShowPoint();
            }
            
        }
    }
     
}
