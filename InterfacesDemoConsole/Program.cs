using System;
using TrigonometriLibrary;

namespace InterfacesDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IPythagoras p = TrigonomeriFactory.CreatePythagorasCalculator();

            double result = p.CalculateLengthOfC(3, 4);

            Console.WriteLine(result);
        }
    }
}
