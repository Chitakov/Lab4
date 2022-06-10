using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Triangle
    {
        public Point A { set; get; }
        public Point B { set; get; }
        public Point C { set; get; }

        //конструктор
        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }
        //сдвиг вправо
        public void MoveRigth(double d)
        {
            A.x += d;
            B.x += d;
            C.x += d;
        }
        //сдвиг влево
        public void MoveLeft(double d)
        {
            A.x -= d;
            B.x -= d;
            C.x -= d;
        }
        //сдвиг верх
        public void MoveUp(double d)
        {
            A.y += d;
            B.y += d;
            C.y += d;
        }
        //сдвиг вниз
        public void MoveDown(double d)
        {
            A.y -= d;
            B.y -= d;
            C.y -= d;
        }
        //Нахождение длины стороны треугольника по двум точкам
        public double DistanceBetweenTwoPoints(Point a, Point b)
        {
            return Convert.ToDouble(Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2)));
        }
        //поворот на угол d
        public void TurnToAngle(double d)
        {
            double angleRadian = d * Math.PI / 180;
            Point M = new Point((A.x + B.x + C.x) / 3, (A.y + B.y + C.y) / 3);
            PointCoordinat0(M);
            double ax = A.x, ay = A.y, bx = B.x, by = B.y, cx = C.x, cy = C.y;
            A.x = ((ax - M.x) * Math.Cos(angleRadian) - (ay - M.y) * Math.Sin(angleRadian) + M.x);
            A.y = ((ax - M.x) * Math.Sin(angleRadian) + (ay - M.y) * Math.Cos(angleRadian) + M.y);
            PointCoordinat0(A);
            B.x = ((bx - M.x) * Math.Cos(angleRadian) - (by - M.y) * Math.Sin(angleRadian) + M.x);
            B.y = ((bx - M.x) * Math.Sin(angleRadian) + (by - M.y) * Math.Cos(angleRadian) + M.y);
            PointCoordinat0(B);
            C.x = ((cx - M.x) * Math.Cos(angleRadian) - (cy - M.y) * Math.Sin(angleRadian) + M.x);
            C.y = ((cx - M.x) * Math.Sin(angleRadian) + (cy - M.y) * Math.Cos(angleRadian) + M.y);
            PointCoordinat0(C);
        }
        //проверка не равна ли одна из координат точки 0
        public void PointCoordinat0(Point P)
        {
            if (P.x == 1.1102230246251565E-16) P.x = 0;
            if (P.y == 1.1102230246251565E-16) P.y = 0;
        }
        //изменение размера треугольника
        public void ScaleBy(double d)
        {
            A.x *= d;
            A.y *= d;
            B.x *= d;
            B.y *= d;
            C.x *= d;
            C.y *= d;
        }
        //вывод координат треугольника
        public void ShowTriangle()
        {
            Console.WriteLine("a(x; y) = ({0}; {1})\nb(x; y) = ({2}; {3})\nc(x; y) = ({4}; {5})", A.x, A.y, B.x, B.y, C.x, C.y);
        }
    }
}
