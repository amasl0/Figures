using ConsoleApp1;
using System;
using Xunit;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit_tests test = new Unit_tests();
            test.Run();

            Figure triangle = new Triangle(10, 10, 10);
            triangle.Print();
        }
    }
}
