using System;
using System.Collections.Generic;
namespace Point
{
    class Figure //public eest kustuta!
    {
        protected List<MyPoint> pointList = new List<MyPoint>();
        public void DrawFigure()
        {
            foreach (MyPoint point in pointList)
            {
                point.Draw();
            }
        }
    }
}
