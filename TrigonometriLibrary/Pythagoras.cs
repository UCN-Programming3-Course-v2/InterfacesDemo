using System;

namespace TrigonometriLibrary
{
    internal class Pythagoras : IPythagoras
    {
        public double CalculateLengthOfC(double a, double b)
        {
            return Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
        }
    }
}
