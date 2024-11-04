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

        public Triangle(double A, double B, double C) // конструктор
        {
            a = A;
            b = B;
            c = C;
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
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
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
    }
}
