using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKC.Calculator.UI
{
    public class Calculator
    {
        public double Add(double x, double y)
        {
            // Addition
            return x + y;
        }

        public double SquareRoot(double x)
        {
            // Square Root (must be called as a double)
            return Math.Sqrt(x);
        }

        public double Reciprocal(double x)
        {
            // Reciprocal
            return 1 / x;
        }

        public double ChangeSign(double x)
        {
            // Change sign
            return -x;
        }

        public double Subtract(double x, double y)
        {
            // Subtraction
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            // Multiplication
            return x * y;
        }

        public double Divide(double x, double y)
        {
            // Division
            return x / y;
        }
    }
}
