using System;

namespace _04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string nameProduct = Console.ReadLine();
            int volumeProduct = int.Parse(Console.ReadLine());
            int energyContentPer100ml = int.Parse(Console.ReadLine());
            double sugarContentPer100ml = double.Parse(Console.ReadLine());
            double energyContent = (volumeProduct / 100.0) * energyContentPer100ml;
            double sugarContent = (volumeProduct / 100.0) * sugarContentPer100ml;
            Console.WriteLine($"{volumeProduct}ml {nameProduct}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
        }
    }
}
