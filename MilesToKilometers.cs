using System;

namespace _03.MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double mile = 1.60934;
            double kilometers = miles * mile;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
