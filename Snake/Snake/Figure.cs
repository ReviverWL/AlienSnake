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

    }
}
