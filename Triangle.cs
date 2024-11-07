using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_V.A_TARpv23
{
    class Triangle
    {
        public double a; // 1-ая сторона
        public double b; // 2-ая сторона
        public double c; // 3-я сторона
        public double alpha; // Придумайте еще: угол между сторонами a и b


        public Triangle(double A, double B, double C) // конструктор
        {
            a = A;
            b = B;
            c = C;
        }

        // Придумайте еще: Конструктор без параметров
        public Triangle(double A, double B, double C, double Alpha)
        {
            a = A;
            b = B;
            c = C;
            alpha = Alpha;
        }

        // Метод для вычисления полупериметра
        public double PoolPerimeeter()
        {
            return (a + b + c) / 2;
        }

        // Метод для вычисления площади через стороны и угол
        public double PindalaArvutamine()
        {
            return 0.5 * a * b * Math.Sin(alpha); // Площадь через две стороны и угол
        }

        // Добавим методы
        public string outputA()
        {
            return Convert.ToString(a);
        }

        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public string outputAlpha()
        {
            return Convert.ToString(alpha);
        }
        public double Perimeter()
        {
            double p = 0;
            p = a + b + c;
            return p;
        }
        public double Surface()
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }

        // Добавим свойства
        public double GetSetA
        {
            get
            { return a; }
            set
            { a = value; }
        }
        public double GetSetB
        {
            get { return b; }
            set { b = value; }
        }
        public double GetSetC
        {
            get { return c; }
            set { c = value; }
        }
        public bool ExistTriangle
        {
            get
            {
                if ((a>b+c) && (b>a+c) && (c>a+b))
                return false; 
                else return true;
            }
        }
        public string TriangleType
        {
            get
            {
                if (ExistTriangle)
                {
                    if (a == b && b == c && a == c)
                    {
                        return "Võrdkülgne";
                    }
                    else if (a == b || b == c || a == c)
            {
                        return "Võrdhaarne";
                    }
            else
                    {
                        return "Skaleeni kolmnurk";
                    }
                }
                else
                {
                    return "Tundmatu tüüp";
                }
            }
        }
    }
}
