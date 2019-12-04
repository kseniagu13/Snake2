using System;
using System.Threading;


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

            /* HorizontalLines topLine = new HorizontalLines(0, 78, 0, '*');
             topLine.DrawFigure();

             HorizontalLines bottomLine = new HorizontalLines(0, 78, 24, '*');
             bottomLine.DrawFigure();

             VerticalLine leftLine = new VerticalLine(0, 24, 0, '*');
             leftLine.DrawFigure();

             VerticalLine rightLine = new VerticalLine(0, 24, 78, '*');
             rightLine.DrawFigure();*/
            decimal gameSpeed = 200m;

            Walls walls = new Walls(80, 25);
            walls.DrawWalls();

            MyPoint tail = new MyPoint(6, 5, '*');
            Snake snake = new Snake(tail, 4, Direction.RIGHT); //loome ussi
            snake.DrawFigure();
           

            FoodCatering foodCatered = new FoodCatering(80, 25, '$'); //loome söögi talle
            MyPoint food = foodCatered.CaterFood();
            food.Draw();
            Console.ForegroundColor = ConsoleColor.Blue;
            int score = 0;

            while (true)
            {
                if (walls.IsHitByFigure(snake))
                {
                    break;
                }

                if (snake.Eat(food)) //kui sööb ära
                {
                    food = foodCatered.CaterFood();
                    food.Draw();
                    score++;
                    gameSpeed *= .952m;
                    
                   
                    
                }
                else // kui uss pole midagi söönud, siis liigu edasi
                {
                    snake.MoveSnake();
                }
                System.Threading.Thread.Sleep(Convert.ToInt32(gameSpeed)); //vaikselt liiguks


                if (Console.KeyAvailable) //kui nupp oli vajutatud
                {
                    ConsoleKeyInfo key = Console.ReadKey(); //loeb vajutust
                    snake.ReadUserKey(key.Key);
                }

                
            }
          
            WriteGameOver(score); //teeme meetodi, et mäng on läbi

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
        public static void WriteGameOver(int score)
        {
            Console.Clear();
            int xOffset = 35; //kus kirjutab message
            int yOffset = 8;
            
            Console.ForegroundColor = ConsoleColor.DarkRed; //värvi valisime
            Console.SetCursorPosition(xOffset, yOffset++); //y++, et läheks järgmisele reale
            ShowMessage("*********", xOffset, yOffset++);
            ShowMessage("GAME OVER", xOffset, yOffset++);
            ShowMessage("*********", xOffset, yOffset++);
            ShowMessage($"Your score is {score}", xOffset, yOffset++);

        }
        public static void ShowMessage(string text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

        

    }
}
