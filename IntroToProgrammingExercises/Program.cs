using System;
using static System.Math;

namespace IntroToProgrammingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
//            StatCalc calc = new StatCalc();
//            
//            double input = Console.Read();
//            
//            while (input != 0)
//            {
//                calc.Enter(input);
//                input = Console.Read();
//            }
//            Console.WriteLine(calc.getMean());
//            Console.WriteLine(calc.getStandardDeviation());
//            Console.WriteLine(calc.GetMax());
//            Console.WriteLine(calc.GetMMin());
//            Console.WriteLine(calc.count);
//            Console.WriteLine(calc.sum);
            
            var headCount = new Counter();
            var tailCount = new Counter();
            Random random = new Random();

            for (int flip = 0; flip < 100; flip++)
            {
                if (random.NextDouble() < 0.5)
                {
                   headCount.Increment(); 
                }
                else
                {
                   tailCount.Increment();
                }
            }
            
            Console.WriteLine("There were " + headCount.GetValue + " heads.");
            Console.WriteLine("There were " + tailCount.GetValue + " tails.");
            
        }
    }
}