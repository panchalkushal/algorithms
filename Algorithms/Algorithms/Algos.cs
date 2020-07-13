using Data;
using System;

namespace Algorithms.Algorithms
{
    public static class Algos
    {
        public static void GenerateFibN1(int n)
        {
            var a = 0;
            var b = 1;
            var i = 2;
            var c = 0;

            UserInput.PrintWithSpace(a);
            UserInput.PrintWithSpace(b);

            while (i < n)
            {
                i++;
                c = a + b;
                a = b;
                b = c;
                UserInput.PrintWithSpace(c);
            }
        }

        // generate two fib numbers in one iteration
        public static void GenerateFibN2(int n)
        {
            var a = 0;
            var b = 1;
            var i = 2;            

            while (i < n)
            {
                UserInput.PrintWithSpace(a);
                UserInput.PrintWithSpace(b);

                i = i + 2;
                a = a + b;
                b = a + b;                
            }

            if (i == n)
            {
                UserInput.PrintWithSpace(a);
                UserInput.PrintWithSpace(b);
            }
            else 
            {
                UserInput.PrintWithSpace(a);
            }            
        }
    }
}
