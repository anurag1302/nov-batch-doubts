using System;

namespace App.Utilities
{
    public abstract class BaseInterestProvider
    {
        public abstract double CalculateInterest(double p, double r, int t);

        public void Print()
        {
            Console.WriteLine("Print - BaseInterestProvider");
        }
    }

    public class SimpleInterest : BaseInterestProvider
    {
        public override double CalculateInterest(double p, double r, int t)
        {
            return (p * r * t) / 100;
        }
    }

    public class CompoundInterest : BaseInterestProvider
    {
        public override double CalculateInterest(double p, double r, int t)
        {
            return (p * r * t* 1.67) / 100;
        }
    }
}
