using System;


namespace Main
{
    abstract class Figure
    {
        protected double Area;
        protected string Name { get; set; }
        public void Print()
        {
            Console.WriteLine(Name + " " + Area);
        }
        public double getArea()
        {
            return Area;
        }
        public string getName()
        {
            return Name;
        }
    }

    class Triangle : Figure
    {
        private bool isRect;
        public Triangle(double a, double b, double c) {
            Name = "Triangle";

            isRect = false;
            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                isRect = true;
            else if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                isRect = true;
            else if (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
                isRect = true;

            double p = ((a + b + c) / 2);
            Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
       }
        public bool isRectangular()
        {
            return isRect;
        }
    }

    class Circle : Figure
    {
        public Circle(double raduis) {
            Name = "Circle";
            Area = (Math.PI * Math.Pow(raduis, 2));
        }
    }

    
}
