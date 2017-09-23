using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Line
    {
        private List<Line> _line = new List<Line>();
        private int _firstPoint;
        private int _lastPoint;
        private int _numberLineOnMap;
        private char _symbol;

        public Line()
        {
        }   

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
                    _line.Add(new Line(i, numberOfDirection, symbol));
                }
            }
            else
            {
                for (int i = firstPoint; i <= lastPoint; i++)
                {
                    _line.Add(new Line(numberOfDirection, i, symbol));
                }
            }
        }
        public Line(int x, int y, char symbol)
        {
            _firstPoint = x;
            _numberLineOnMap = y;
            _symbol = symbol;
        }

        public void ShowStartPointLine()
        {
            Console.SetCursorPosition(_firstPoint, _numberLineOnMap);
            Console.Write(_symbol);
        }


        public void ShowLine()
        {
            for (int i =0; i< _line.Count; i++)
            {
                _line[i].ShowStartPointLine();
            }
            
        }
    }
     
}
