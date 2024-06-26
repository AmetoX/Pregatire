using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregatireExamen.Clase
{
    internal class Fractie
    {
                    //sus      jos
        private int numarator, numitor;
        public Fractie() 
        {
            numitor = 1;
            numarator = 1;
        }
        public Fractie(int numarator, int numitor)
        {
            if (numitor == 0)
            {
                throw new ArgumentException("numitor cannot be zero.");
            }

            this.numarator = numarator;
            this.numitor = numitor;
            Simplify();
        }
        // Method to simplify the fraction
        private void Simplify()
        {
            int gcd = GCD(Math.Abs(numarator), Math.Abs(numitor));
            numarator /= gcd;
            numitor /= gcd;

            // Ensure the numitor is always positive
            if (numitor < 0)
            {
                numarator = -numarator;
                numitor = -numitor;
            }
        }
        // Method to find the greatest common divisor (GCD)
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public static Fractie operator +(Fractie a, Fractie b)
        {       
            int numarator = a.numarator * b.numitor + b.numarator * a.numitor;
            int numitor = a.numitor * b.numitor;
            return new Fractie(numarator, numitor);
        }

        // Subtraction
        public static Fractie operator -(Fractie a, Fractie b)
        {
            int numarator = a.numarator * b.numitor - b.numarator * a.numitor;
            int numitor = a.numitor * b.numitor;
            return new Fractie(numarator, numitor);
        }

        // Multiplication
        public static Fractie operator *(Fractie a, Fractie b)
        {
            int numarator = a.numarator * b.numarator;
            int numitor = a.numitor * b.numitor;
            return new Fractie(numarator, numitor);
        }

        // Division
        public static Fractie operator /(Fractie a, Fractie b)
        {
            if (b.numarator == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero fraction.");
            }
            int numarator = a.numarator * b.numitor;
            int numitor = a.numitor * b.numarator;
            return new Fractie(numarator, numitor);
        }

        public override string ToString()
        {
            return $"{numarator}/{numitor}";
        }

    }
}
