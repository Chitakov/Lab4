using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(0, 3);
            Point b = new Point(0, 0);
            Point c = new Point(3, 0);
            if (IsTriangleCanExist(a, b, c))
            {
                Triangle T = new Triangle(a, b, c);
                Console.WriteLine("Исходные координаты:");
                T.ShowTriangle();

                T.MoveLeft(1);
                Console.WriteLine("\nСдвиг влево");
                T.ShowTriangle();
                
                T.MoveRigth(1);
                Console.WriteLine("\nСдвиг вправо");
                T.ShowTriangle();
                
                T.MoveUp(1);
                Console.WriteLine("\nСдвиг вверх");
                T.ShowTriangle();
                
                T.MoveDown(1);
                Console.WriteLine("\nСдвиг вниз");
                T.ShowTriangle();
                
                T.TurnToAngle(90);
                Console.WriteLine("\nПоворот треугольника");
                T.ShowTriangle();

                T.ScaleBy(2);
                Console.WriteLine("\nИзменение размера треугольника");
                T.ShowTriangle();

                Console.ReadLine();
            }
            else 
            { 
                Console.WriteLine("Такого треугольника не может существовать.");
                Console.ReadLine();
            }
        }

        //проверка на возможность построения треугольника
        static bool IsTriangleCanExist(Point a, Point b, Point c)
        {
            if ((c.y - a.y) * (b.x - a.x) == (c.x - a.x) * (b.y - a.y)) return false;
            else return true;
        }
    }
}
