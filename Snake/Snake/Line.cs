using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Line : Figure
    {
      
        private int _lastPointFirstAxis;
        
        public Line(int headPointFirstAxis, int lastPointFirstAxis, int secondAxis, char symbol, bool direction)
        {
            _headPointFirstAxis = headPointFirstAxis;
            _lastPointFirstAxis = lastPointFirstAxis;
            _secondAxis = secondAxis;
            _symbol = symbol;
            if (direction)
            {                
                for (int i = headPointFirstAxis; i <= lastPointFirstAxis; i++)
                {
                    _line.Add(new Point(i, secondAxis, symbol));
                }
            }
            else
            {
                for (int i = headPointFirstAxis; i <= lastPointFirstAxis; i++)
                {
                    _line.Add(new Point(secondAxis, i, symbol));
                }
            }
        }
        
    }
     
}
