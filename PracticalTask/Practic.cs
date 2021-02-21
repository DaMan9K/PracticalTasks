using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask
{
    public class Practic
    {
        //Площадь круга
        public double Circle(double r)
        {

            return 3.14 * Math.Pow(r, 2);
        }
        //Площадь треугольника
        public double Triangle(double a, double b, double c)
        {

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));


        }
        //Проверка Треугольника на наличие прямого угла
        public bool IsRightTriangle(double a, double b, double c)
        {
            return (a == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2))
                    || b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2))
                    || c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));

        }
    }
}
