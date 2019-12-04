using System;
using System.Collections.Generic;
using System.Linq;

namespace Point
{
    enum Direction // suurte tähtetega enum!
    {
        LEFT,
        RIGHT,
        UP,
        DOWN
    }
    class Snake : Figure
    {
        public Direction Direction;

        public Snake(MyPoint tail, int lenght, Direction _direction)
        {
            Direction = _direction;
            for (int i = 0; i < lenght; i++)
            {
                MyPoint newPoint = new MyPoint(tail);
                newPoint.MovePoint(i, Direction);
                pointList.Add(newPoint);
            }
        }
        public void MoveSnake()
        {
            MyPoint tail = pointList.First();
            pointList.Remove(tail);
            MyPoint head = GetNextPoint();
            pointList.Add(head);
            tail.Clear();
            head.Draw();
        }
        public MyPoint GetNextPoint()
        {
            MyPoint head = pointList.Last();
            MyPoint nextPoint = new MyPoint(head);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            nextPoint.MovePoint(1, Direction);
            return nextPoint;
        }

        public void ReadUserKey(ConsoleKey key) //parameter klahvi vajutus
        {
            if (key == ConsoleKey.LeftArrow)
            {
                Direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                Direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                Direction = Direction.UP;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                Direction = Direction.DOWN;
            }
        }


        public bool Eat(MyPoint food) //uss sööb point, millel on omad koordinaadid
        {
            MyPoint head = GetNextPoint();
            if (head.IsHit(food)) //kui see on true, siis ta lisab ussile kasvu
            {
                food.symbol = head.symbol; //kui ta sööb ära, siis uss suureneb
                pointList.Add(food);
                
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }

}
