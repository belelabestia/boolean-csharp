using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTester
{
    public static class Calculator
    {
        public static float Add(float a, float b) { return a + b; }
        public static float Subtract(float a, float b) { return a - b; }
        public static float Multiply(float a, float b) { return a * b; }

        public static float Divide(float a, float b) 
        {
            if (b is 0) throw new DivideByZeroException();
            return a / b; 
        }
    }
}
