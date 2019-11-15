using System;
using System.Collections.Generic;
using DeletionDistance.lib;

namespace DeletionDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            DeletionDistanceCalculator calc = new DeletionDistanceCalculator();
            int distance = calc.CalculateDistance("dog", "frog");
            Console.WriteLine($"Deletion distance between dog and frog is {distance}");
        }
    }
}
