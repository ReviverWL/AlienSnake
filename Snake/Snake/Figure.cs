﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> _line;
        
        public void ShowFigure()
        {
            for (int i = 0; i < _line.Count(); i++)
            {
                _line[i].ShowPoint();
            }

        }
        public bool CollizionFigure(Figure figure)
        {
            Point head = _line.Last();
            bool collizion = false;
            foreach (var point in figure._line)
            {
                if (point.Collizion(head))
                {
                    collizion = true;
                }
            }
            return collizion;
        }
    }
}
