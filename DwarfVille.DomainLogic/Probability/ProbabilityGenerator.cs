using System;

namespace DwarfVille.DomainLogic.Probability
{
    public class ProbabilityGenerator : IProbabilityGenerator
    {
        private static Random _random = new Random();

        public double Generate(int minValue, int maxValue)
        {
           return minValue + _random.NextDouble() * (maxValue - minValue);
        }
    }
}