using System;

namespace SnakeDraft
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;
        public Point(int _x, int _y, char _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            //Declare point cordinates
            //Console.BackgroundColor = ConsoleColor.White;
           // Console.Clear();

            /*int x1 = 10;
            int y1 = 10;
            char symbol1 = '*';
            Draw(x1, y1, symbol1);*/
            Point p1= new Point(10, 10, '*');
            //Draw(p1.x, p1.y, p1.symbol);
            p1.Draw();

            //Console.SetCursorPosition(x1, y1);
            //Console.ForegroundColor = ConsoleColor.Red; - värve täna pole vaja
            //Console.Write(symbol1);

            /*int x2 = 5;
            int y2 = 5;
            char symbol2 = '#';
            Draw(x2, y2, symbol2);*/

            //Console.SetCursorPosition(x2, y2);
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write(symbol2);
            //Draw(5, 7,'@');
            Point p2 = new Point(5, 5, '#');
            p2.Draw();
        }
       
    }
}
