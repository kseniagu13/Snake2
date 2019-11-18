using System;
using System.Collections.Generic;
namespace Point
{
    class HorizontalLines
    {
        public List<MyPoint> pointList = new List<MyPoint>();

        public HorizontalLines(int xLeft, int xRight, int y, char symbol)
        {
            for(int i= xLeft; i<=xRight; i++)
            {
                MyPoint newPoint = new MyPoint(i,y,symbol);
                pointList.Add(newPoint);
            }
            
        }
        public void DrawHorizontlLine()
        {
            foreach(MyPoint point in pointList)
            {
                point.Draw();
            }
        }

    }
}
