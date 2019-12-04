using System;
using System.Collections.Generic;
namespace Point
{
    class Figure //public eest kustuta!
    {
        protected List<MyPoint> pointList = new List<MyPoint>(); //protected, saavad kasutada teised kasutajad aga ei saa midagi muuta seal
        public void DrawFigure()
        {
            foreach (MyPoint point in pointList)
            {
                point.Draw();
             
            }
        }

        public bool IsHitByPoint(MyPoint point)
        {
            foreach (MyPoint p in pointList) //kas selle punkti koordinaadid on samad mis takistuse punkti koordinaadid
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsHitByFigure (Figure figure)
        {
            foreach(MyPoint point in pointList)
            {
                if (figure.IsHitByPoint(point))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
