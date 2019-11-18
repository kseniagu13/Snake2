using System;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Point p1 = new Point(5, 5, '*');
            p1.Draw();

            Point p2 = new Point(6, 5, '*');
            p2.Draw();

            Point p3 = new Point(7, 5, '*');
            p3.Draw();
            Point p4 = new Point(8, 5, '*');
            p4.Draw();
            Point p5 = new Point(9, 5, '*');
            p5.Draw();
            Console.ReadLine();*/

            /*for(int i =5; i<10; i++)
            {
                MyPoint newPoint = new MyPoint(i, 5, '*');
                newPoint.Draw();
                MyPoint newPoint2 = new MyPoint(5, i, '#');
                newPoint2.Draw();
            } //list, mille sees on objektid, objekt klassis point*/

            //Console.SetWindowSize(80, 25); ei tööta
            //Console.SetBufferSize(80, 25);

            HorizontalLines topLine = new HorizontalLines(0, 78, 0, '*');
            topLine.DrawHorizontlLine();

            HorizontalLines bottomLine = new HorizontalLines(0, 78, 24, '*');
            bottomLine.DrawHorizontlLine();

            VerticalLine leftLine = new VerticalLine(0, 24, 0, '*');
            leftLine.DrawVerticallLine();

            VerticalLine rightLine = new VerticalLine(0, 24, 78, '*');
            rightLine.DrawVerticallLine();

            /*HorizontalLines hrLine = new HorizontalLines(5,10, 10,'*');
            hrLine.DrawHorizontlLine();

            VerticalLine vrLine = new VerticalLine(11, 20, 5, '#');
            vrLine.DrawVerticallLine();

            HorizontalLines hrLine2 = new HorizontalLines(10, 15, 10, '*');
            hrLine2.DrawHorizontlLine();

            VerticalLine vrLine2 = new VerticalLine(10, 15, 10, '#');
            vrLine2.DrawVerticallLine();*/
            Console.ReadLine();
        }
    }
}
