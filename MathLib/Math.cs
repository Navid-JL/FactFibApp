using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathLib
{
    public static class Math
    {
        public static int Factorial(int number) {
            if (number == 0) return 0;
            else if (number == 1) return 1;
            else
                return number * Factorial(number - 1);
        }
    
        public static int Fibonacci(int term) {
            if (term == 0) return 0;
            else if (term == 1 || term == 2) return 1;
            else
                return Fibonacci(term - 1) + Fibonacci(term - 2);
        }
    }
}