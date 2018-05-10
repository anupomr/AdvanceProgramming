using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Rational(3, 5));
            Rational r1 = new Rational(2, 3);
            Rational r2 = new Rational(4, 7);
            Rational r3 = new Rational().Add(r2);

            Console.WriteLine($"{r1} + {r2}={r2.Add(r1)}");
            Console.WriteLine($"{r1+r2}");
        }
    }
    class Rational
    {
        public int Numerator { get; private set; }
        public int Denamerator { get; private set; }

        public Rational(int numerator = 0, int denemator = 1)
        {
            Numerator = numerator;
            Denamerator = denemator;
        }
        public override string ToString()
        => $"<{Numerator} / {Denamerator}>";

        public Rational Add(Rational other)
        {
            int denominator = this.Denamerator * other.Denamerator;
            int numerator = Numerator * other.Denamerator + Denamerator * other.Numerator;
            return new Rational(numerator, denominator);
        }
        public static Rational operator +(Rational hs, Rational rhs) {
            int denominator = hs.Denamerator * rhs.Denamerator;
            int numerator = hs.Numerator * rhs.Denamerator + hs.Denamerator * rhs.Numerator;
            return new Rational(numerator, denominator);
        }
    }
}
