using System;
using System.Collections.Generic;

namespace Point
{
    class VerticalLine : Figure//public eest kustutada,, muidu ei toimi!!!
    {
        //public List<MyPoint> pointList = new List<MyPoint>(); 

        public VerticalLine(int yTop, int yBottom, int x, char symbol)
        {
            for (int i = yTop; i <= yBottom; i++)
            {
                MyPoint newPoint = new MyPoint(x, i, symbol);
                pointList.Add(newPoint);
            }

        }
        /*public void DrawVerticallLine()
        {
            foreach (MyPoint point in pointList)
            {
                point.Draw();
            }
        }*/
    }
}
