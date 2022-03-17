using System;

namespace basicMath
{
    public class Cal
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            return num1 /num2;
        }


        static void Main (string [] args)
        {
            double m;
            Cal a = new Cal();
            m = a.Add(2.5, 5.3);

            Console.WriteLine(m);
        }
    }
}