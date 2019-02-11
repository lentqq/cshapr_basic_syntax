using System;

namespace _01.DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.Write($"{a:d4} {b:d4} {c:d4} {d:d4}");
            Console.WriteLine();
        }
    }
}
